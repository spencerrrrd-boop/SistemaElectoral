using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmUsuarios : Form
    {
        private Usuario _usuarioActual;

        public frmUsuarios(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            CargarPadrones();
            CargarUsuarios();
        }

        private void CargarRoles()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Votante");
            if (UsuarioBLL.EsDirector(_usuarioActual))
            {
                cmbRol.Items.Add("Administrador");
            }
            cmbRol.SelectedIndex = 0;
        }

        private void CargarPadrones()
        {
            cmbPadron.DataSource = PadronBLL.ObtenerTodos();
            cmbPadron.DisplayMember = "NombreCompleto";
            cmbPadron.ValueMember = "PadronID";
        }

        private void CargarUsuarios()
        {
            List<Usuario> lista = UsuarioBLL.ObtenerTodos();
            dgvUsuarios.DataSource = lista;

            // Renombrar columnas
            if (dgvUsuarios.Columns["Matricula"] != null)
                dgvUsuarios.Columns["Matricula"].HeaderText = "Matrícula";
            if (dgvUsuarios.Columns["NombreCompleto"] != null)
                dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
            if (dgvUsuarios.Columns["NombreRol"] != null)
                dgvUsuarios.Columns["NombreRol"].HeaderText = "Rol";
            if (dgvUsuarios.Columns["Curso"] != null)
                dgvUsuarios.Columns["Curso"].HeaderText = "Curso";
            if (dgvUsuarios.Columns["Seccion"] != null)
                dgvUsuarios.Columns["Seccion"].HeaderText = "Sección";

            // Ocultar columnas innecesarias
            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
            {
                if (col.Name != "Matricula" && col.Name != "NombreCompleto" &&
                    col.Name != "NombreRol" && col.Name != "Curso" && col.Name != "Seccion")
                    col.Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                Matricula = txtMatricula.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                RolID = cmbRol.SelectedIndex + 3,
                PadronID = (int)cmbPadron.SelectedValue
            };

            var resultado = UsuarioBLL.Registrar(u, txtContrasena.Text.Trim());
            MessageBox.Show(resultado.mensaje,
                resultado.exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                resultado.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado.exito)
            {
                LimpiarCampos();
                CargarUsuarios();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtContrasena.Text = "";
            cmbRol.SelectedIndex = 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            List<Usuario> lista = UsuarioBLL.ObtenerTodos();
            dgvUsuarios.DataSource = lista.FindAll(u =>
                u.Matricula.ToLower().Contains(busqueda) ||
                u.NombreCompleto.ToLower().Contains(busqueda));
        }
    }
}