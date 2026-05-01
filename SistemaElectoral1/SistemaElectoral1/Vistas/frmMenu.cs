using SistemaElectoral1.Models;
using SistemaElectoral1.Vistas;
using System;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmMenu : Form
    {
        private Usuario _usuarioActual;

        public frmMenu(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Mostrar nombre del usuario
            lblBienvenida.Text = $"Bienvenido, {_usuarioActual.NombreCompleto}";
            lblRol.Text = $"Rol: {_usuarioActual.NombreRol}";

            // Mostrar botones segun el rol
            if (_usuarioActual.NombreRol == Rol.DIRECTOR)
                MostrarMenuDirector();
            else if (_usuarioActual.NombreRol == Rol.ADMINISTRADOR)
                MostrarMenuAdministrador();
        }

        private void MostrarMenuDirector()
        {
            btnUsuarios.Visible = true;
            btnPlanchas.Visible = true;
            btnPanel.Visible = true;
            btnReportes.Visible = true;
            btnPeriodo.Visible = true;
        }

        private void MostrarMenuAdministrador()
        {
            btnUsuarios.Visible = true;
            btnPlanchas.Visible = true;
            btnPanel.Visible = false;
            btnReportes.Visible = true;
            btnPeriodo.Visible = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios(_usuarioActual);
            frm.Show();
        }

        private void btnPlanchas_Click(object sender, EventArgs e)
        {
            frmPlanchas frm = new frmPlanchas(_usuarioActual);
            frm.Show();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            frmPanel frm = new frmPanel();
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes(_usuarioActual);
            frm.Show();
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            // Abrir gestion de periodo de votacion
            MessageBox.Show("Gestion de periodo proximamente.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
   }
}
