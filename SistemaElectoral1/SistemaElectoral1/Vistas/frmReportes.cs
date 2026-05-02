using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmReportes : Form
    {
        private Usuario _usuarioActual;

        public frmReportes(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Si es administrador ocultar plancha ganadora y participantes
            if (UsuarioBLL.EsAdministrador(_usuarioActual))
            {
                btnPlanchaGanadora.Visible = false;
                btnParticipantes.Visible = false;
            }
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Reporte General de Votos";
            using (var cn = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM vw_ResultadosPorPlancha ORDER BY TotalVotos DESC";
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, cn);
                cn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvReporte.DataSource = dt;
                FormatearColumnas();
            }
        }

        private void btnPlanchaGanadora_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Plancha Ganadora";
            using (var cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT TOP 1 NombrePlancha, TotalVotos, PorcentajeVotos 
                                 FROM vw_ResultadosPorPlancha 
                                 ORDER BY TotalVotos DESC";
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, cn);
                cn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvReporte.DataSource = dt;
                FormatearColumnas();
            }
        }

        private void btnIntegrantes_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Integrantes del Partido";
            using (var cn = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM vw_IntegrantesPorPlancha";

                // Si es administrador filtrar solo su plancha
                if (UsuarioBLL.EsAdministrador(_usuarioActual))
                {
                    var miPlancha = PlanchaBLL.ObtenerMiPlancha(_usuarioActual.UsuarioID);
                    if (miPlancha != null)
                        query += $" WHERE NombrePlancha = '{miPlancha.NombrePlancha}'";
                }

                var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, cn);
                cn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvReporte.DataSource = dt;
                FormatearColumnas();
            }
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Listado de Participantes";
            dgvReporte.DataSource = UsuarioBLL.ObtenerTodos();
            FormatearColumnas();
        }

        private void FormatearColumnas()
        {
            if (dgvReporte.Columns["PlanchaID"] != null)
                dgvReporte.Columns["PlanchaID"].Visible = false;
            if (dgvReporte.Columns["LogoRuta"] != null)
                dgvReporte.Columns["LogoRuta"].Visible = false;
            if (dgvReporte.Columns["NombrePlancha"] != null)
                dgvReporte.Columns["NombrePlancha"].HeaderText = "Plancha";
            if (dgvReporte.Columns["TotalVotos"] != null)
                dgvReporte.Columns["TotalVotos"].HeaderText = "Votos";
            if (dgvReporte.Columns["PorcentajeVotos"] != null)
                dgvReporte.Columns["PorcentajeVotos"].HeaderText = "Porcentaje %";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Selecciona un reporte primero.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF|*.pdf";
            sfd.FileName = lblResultado.Text;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc,
                        new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create));
                    doc.Open();

                    // Titulo
                    iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(
                        iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                    doc.Add(new iTextSharp.text.Paragraph(lblResultado.Text, fuenteTitulo));
                    doc.Add(new iTextSharp.text.Paragraph(
                        $"Generado: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}"));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // Contar columnas visibles
                    int colsVisibles = 0;
                    foreach (DataGridViewColumn col in dgvReporte.Columns)
                        if (col.Visible) colsVisibles++;

                    iTextSharp.text.pdf.PdfPTable tabla =
                        new iTextSharp.text.pdf.PdfPTable(colsVisibles);
                    tabla.WidthPercentage = 100;

                    // Encabezados
                    iTextSharp.text.Font fuenteHeader = new iTextSharp.text.Font(
                        iTextSharp.text.Font.FontFamily.HELVETICA, 10,
                        iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.WHITE);

                    foreach (DataGridViewColumn col in dgvReporte.Columns)
                    {
                        if (col.Visible)
                        {
                            iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(
                                new iTextSharp.text.Phrase(col.HeaderText, fuenteHeader));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(30, 58, 95);
                            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            cell.Padding = 5;
                            tabla.AddCell(cell);
                        }
                    }

                    // Filas
                    iTextSharp.text.Font fuenteFila = new iTextSharp.text.Font(
                        iTextSharp.text.Font.FontFamily.HELVETICA, 9);

                    foreach (DataGridViewRow row in dgvReporte.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (dgvReporte.Columns[cell.ColumnIndex].Visible)
                            {
                                iTextSharp.text.pdf.PdfPCell pdfCell =
                                    new iTextSharp.text.pdf.PdfPCell(
                                        new iTextSharp.text.Phrase(
                                            cell.Value?.ToString() ?? "", fuenteFila));
                                pdfCell.Padding = 4;
                                tabla.AddCell(pdfCell);
                            }
                        }
                    }

                    doc.Add(tabla);
                    doc.Close();

                    MessageBox.Show("PDF exportado exitosamente.",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
