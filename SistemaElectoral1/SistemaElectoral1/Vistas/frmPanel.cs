using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmPanel : Form
    {
        private Usuario _usuarioActual;

        public frmPanel(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmPanel_Load(object sender, EventArgs e)
        {
            ActualizarPanel();
            timer1.Start();
        }

        private void ActualizarPanel()
        {
            PanelGeneral panel = VotoBLL.ObtenerPanelGeneral();

            lblPadronNum.Text = panel.TotalPadron.ToString();
            lblVotosNum.Text = panel.VotosEmitidos.ToString();
            lblNulosNum.Text = panel.VotosNulos.ToString();
            lblTiempoNum.Text = panel.TiempoRestante;

            var resultados = VotoBLL.ObtenerResultados();

            // Si es administrador filtrar solo su plancha
            if (UsuarioBLL.EsAdministrador(_usuarioActual))
            {
                var miPlancha = PlanchaBLL.ObtenerMiPlancha(_usuarioActual.UsuarioID);
                if (miPlancha != null)
                    resultados = resultados.FindAll(r => r.PlanchaID == miPlancha.PlanchaID);
            }

            dgvResultados.DataSource = resultados;

            if (dgvResultados.Columns["PlanchaID"] != null)
                dgvResultados.Columns["PlanchaID"].Visible = false;
            if (dgvResultados.Columns["LogoRuta"] != null)
                dgvResultados.Columns["LogoRuta"].Visible = false;
            if (dgvResultados.Columns["NombrePlancha"] != null)
                dgvResultados.Columns["NombrePlancha"].HeaderText = "Plancha";
            if (dgvResultados.Columns["TotalVotos"] != null)
                dgvResultados.Columns["TotalVotos"].HeaderText = "Votos";
            if (dgvResultados.Columns["PorcentajeVotos"] != null)
                dgvResultados.Columns["PorcentajeVotos"].HeaderText = "Porcentaje %";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarPanel();
        }
    }
}