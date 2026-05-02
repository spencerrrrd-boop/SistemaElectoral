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
            MessageBox.Show("Funcionalidad de exportar PDF proximamente.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
