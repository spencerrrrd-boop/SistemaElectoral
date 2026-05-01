using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmPlanchas : Form
    {
        private Usuario _usuarioActual;
        private Plancha _planchaActual;

        public frmPlanchas(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmPlanchas_Load(object sender, EventArgs e)
        {
            CargarPuestos();

            if (UsuarioBLL.EsAdministrador(_usuarioActual))
            {
                // Administrador ve solo su plancha
                _planchaActual = PlanchaBLL.ObtenerMiPlancha(_usuarioActual.UsuarioID);
                if (_planchaActual != null)
                {
                    txtNombrePlancha.Text = _planchaActual.NombrePlancha;
                    txtLema.Text = _planchaActual.Lema;
                    txtLogoRuta.Text = _planchaActual.LogoRuta;
                    CargarCandidatos(_planchaActual.PlanchaID);
                }
            }
            else if (UsuarioBLL.EsDirector(_usuarioActual))
            {
                // Director puede crear nuevas planchas
                _planchaActual = null;
            }
        }

        private void CargarPuestos()
        {
            cmbPuesto.Items.Clear();
            cmbPuesto.Items.Add("Presidente");
            cmbPuesto.Items.Add("Vicepresidente");
            cmbPuesto.Items.Add("Secretario");
            cmbPuesto.Items.Add("Tesorero");
            cmbPuesto.Items.Add("Vocal");
            cmbPuesto.SelectedIndex = 0;
        }

        private void CargarCandidatos(int planchaID)
        {
            using (var cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT NombrePuesto, NombreCompleto, Matricula 
                                 FROM vw_CandidatosPorPlancha 
                                 WHERE PlanchaID = @PlanchaID";
                var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@PlanchaID", planchaID);
                cn.Open();
                var dt = new System.Data.DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvCandidatos.DataSource = dt;
            }
        }

        private void btnSeleccionarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Seleccionar Logo del Partido";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtLogoRuta.Text = ofd.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePlancha.Text))
            {
                MessageBox.Show("El nombre de la plancha es obligatorio.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_planchaActual == null)
            {
                // Crear nueva plancha (Director)
                Plancha p = new Plancha
                {
                    NombrePlancha = txtNombrePlancha.Text.Trim(),
                    Lema = txtLema.Text.Trim(),
                    LogoRuta = txtLogoRuta.Text.Trim(),
                    AdministradorID = _usuarioActual.UsuarioID
                };
                var resultado = PlanchaBLL.Registrar(p);
                MessageBox.Show(resultado.mensaje,
                    resultado.exito ? "Exito" : "Error",
                    MessageBoxButtons.OK,
                    resultado.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            else
            {
                // Actualizar plancha existente (Administrador)
                _planchaActual.NombrePlancha = txtNombrePlancha.Text.Trim();
                _planchaActual.Lema = txtLema.Text.Trim();
                _planchaActual.LogoRuta = txtLogoRuta.Text.Trim();
                var resultado = PlanchaBLL.Actualizar(_planchaActual, _usuarioActual.UsuarioID);
                MessageBox.Show(resultado.mensaje,
                    resultado.exito ? "Exito" : "Error",
                    MessageBoxButtons.OK,
                    resultado.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCandidato_Click(object sender, EventArgs e)
        {
            if (_planchaActual == null)
            {
                MessageBox.Show("Primero guarda la plancha antes de agregar candidatos.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCandidatoMatricula.Text))
            {
                MessageBox.Show("Ingresa la matricula del candidato.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Candidato agregado correctamente.",
                "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarCandidatos(_planchaActual.PlanchaID);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombrePlancha.Text = "";
            txtLema.Text = "";
            txtLogoRuta.Text = "";
            txtCandidatoMatricula.Text = "";
            cmbPuesto.SelectedIndex = 0;
        }
    }
}