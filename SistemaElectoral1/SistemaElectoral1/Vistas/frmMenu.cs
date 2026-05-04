using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using SistemaElectoral1.Vistas;
using SistemaElectoral1.LogicaNegocio;
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
            else if (_usuarioActual.NombreRol == Rol.VOTANTE)
                MostrarMenuVotante();
        }

        private void MostrarMenuDirector()
        {
            btnUsuarios.Visible = true;
            btnPlanchas.Visible = true;
            btnPanel.Visible = true;
            btnReportes.Visible = true;
            btnPeriodo.Visible = true;
        }
        private void MostrarMenuVotante()
        {
            btnUsuarios.Visible = false;
            btnPlanchas.Visible = false;
            btnPanel.Visible = false;  // Oculto hasta que vote
            btnReportes.Visible = false;
            btnPeriodo.Visible = false;
            btnVotar.Visible = true;
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
            frmPanel frm = new frmPanel(_usuarioActual);
            frm.Show();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes(_usuarioActual);
            frm.Show();
        }

      private void btnPeriodo_Click(object sender, EventArgs e)
        {
            frmPeriodo frm = new frmPeriodo(_usuarioActual);
            frm.Show();
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            frmVotacion frm = new frmVotacion(_usuarioActual);
            frm.ShowDialog(); // ShowDialog en lugar de Show para esperar a que cierre

            // Despues de votar mostrar el panel
            if (VotoBLL.UsuarioYaVoto(_usuarioActual.UsuarioID))
            {
                btnPanel.Visible = true;
                btnVotar.Enabled = false;
                btnVotar.Text = "Ya votaste";
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
   }
}
