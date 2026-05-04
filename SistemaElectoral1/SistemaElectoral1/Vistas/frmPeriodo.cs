using Microsoft.Data.SqlClient;
using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmPeriodo : Form
    {
        private Usuario _usuarioActual;

        public frmPeriodo(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmPeriodo_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now.AddHours(8);
            CargarPeriodos();
        }

        private void CargarPeriodos()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT PeriodoID, Descripcion, FechaInicio, FechaFin,
                                 CASE WHEN Activo = 1 THEN 'Activo' ELSE 'Cerrado' END AS Estado
                                 FROM PeriodosVotacion
                                 ORDER BY FechaInicio DESC";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvPeriodos.DataSource = dt;

                if (dgvPeriodos.Columns["PeriodoID"] != null)
                    dgvPeriodos.Columns["PeriodoID"].Visible = false;
                if (dgvPeriodos.Columns["Descripcion"] != null)
                    dgvPeriodos.Columns["Descripcion"].HeaderText = "Descripción";
                if (dgvPeriodos.Columns["FechaInicio"] != null)
                    dgvPeriodos.Columns["FechaInicio"].HeaderText = "Inicio";
                if (dgvPeriodos.Columns["FechaFin"] != null)
                    dgvPeriodos.Columns["FechaFin"].HeaderText = "Fin";
            }

            // Agregar boton Abrir/Cerrar si no existe
            if (!dgvPeriodos.Columns.Contains("Accion"))
            {
                DataGridViewButtonColumn btnAccion = new DataGridViewButtonColumn();
                btnAccion.Name = "Accion";
                btnAccion.HeaderText = "Acción";
                btnAccion.Text = "Abrir/Cerrar";
                btnAccion.UseColumnTextForButtonValue = true;
                dgvPeriodos.Columns.Add(btnAccion);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFin.Value <= dtpInicio.Value)
            {
                MessageBox.Show("La fecha fin debe ser mayor a la fecha inicio.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO PeriodosVotacion 
                                (Descripcion, FechaInicio, FechaFin, Activo, CreadoPor)
                                VALUES (@Descripcion, @FechaInicio, @FechaFin, 0, @CreadoPor)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@FechaInicio", dtpInicio.Value);
                cmd.Parameters.AddWithValue("@FechaFin", dtpFin.Value);
                cmd.Parameters.AddWithValue("@CreadoPor", _usuarioActual.UsuarioID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Período creado exitosamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDescripcion.Text = "";
            CargarPeriodos();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dgvPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPeriodos.Columns[e.ColumnIndex].Name != "Accion") return;

            int periodoID = (int)dgvPeriodos.Rows[e.RowIndex].Cells["PeriodoID"].Value;
            string estado = dgvPeriodos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            bool abrir = estado == "Cerrado";

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_TogglePeriodo", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PeriodoID", periodoID);
                cmd.Parameters.AddWithValue("@Abrir", abrir ? 1 : 0);
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(abrir ? "Período abierto correctamente." : "Período cerrado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarPeriodos();
        }
    }
}

