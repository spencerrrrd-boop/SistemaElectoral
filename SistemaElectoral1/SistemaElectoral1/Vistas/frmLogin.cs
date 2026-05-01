using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using System;
using System.Windows.Forms;

namespace SistemaElectoral1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor complete todos los campos.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = UsuarioBLL.Login(matricula, contrasena);

            if (usuario == null)
            {
                MessageBox.Show("Matricula o contrasena incorrectos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Redirigir segun el rol
            if (UsuarioBLL.EsDirector(usuario))
            {
                frmMenu menu = new frmMenu(usuario);
                menu.Show();
                this.Hide();
            }
            else if (UsuarioBLL.EsAdministrador(usuario))
            {
                frmMenu menu = new frmMenu(usuario);
                menu.Show();
                this.Hide();
            }
            else if (UsuarioBLL.EsVotante(usuario))
            {
                frmVotacion votacion = new frmVotacion(usuario);
                votacion.Show();
                this.Hide();
            }
        }
    }
}
