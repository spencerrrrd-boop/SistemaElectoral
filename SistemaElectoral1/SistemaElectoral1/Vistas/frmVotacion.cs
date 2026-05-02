using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.LogicaNegocio;
using SistemaElectoral1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaElectoral1.Vistas
{
    public partial class frmVotacion : Form
    {
        private Usuario _usuarioActual;
        private int? _planchaSeleccionadaID = null;
        private List<Plancha> _planchas;

        public frmVotacion(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
        }

        private void frmVotacion_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuarioActual.NombreCompleto;

            // Verificar si ya voto
            if (VotoBLL.UsuarioYaVoto(_usuarioActual.UsuarioID))
            {
                MessageBox.Show("Ya has emitido tu voto. Gracias por participar.",
                    "Voto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnVotar.Enabled = false;
                btnVotoNulo.Enabled = false;
            }

            CargarPlanchas();
        }

        private void CargarPlanchas()
        {
            pnlPlanchas.AutoScroll = false;
            _planchas = PlanchaBLL.ObtenerTodas();
            pnlPlanchas.Controls.Clear();

            int x = 10;
            int y = 10;
            int ancho = 310;
            int alto = 200;
            int columna = 0;

            foreach (Plancha p in _planchas)
            {
                // Crear tarjeta de plancha
                Panel tarjeta = new Panel();
                tarjeta.Size = new Size(ancho, alto);
                tarjeta.Location = new Point(x + (columna * (ancho + 15)), y);
                tarjeta.BackColor = Color.FromArgb(30, 58, 95);
                tarjeta.BorderStyle = BorderStyle.FixedSingle;
                tarjeta.Tag = p.PlanchaID;
                tarjeta.Cursor = Cursors.Hand;

                // Nombre plancha
                Label lblNombre = new Label();
                lblNombre.Text = p.NombrePlancha;
                lblNombre.Font = new Font("Arial", 12, FontStyle.Bold);
                lblNombre.ForeColor = Color.White;
                lblNombre.Location = new Point(10, 10);
                lblNombre.AutoSize = true;
                lblNombre.Tag = p.PlanchaID;

                // Lema
                Label lblLema = new Label();
                lblLema.Text = p.Lema;
                lblLema.ForeColor = Color.LightGray;
                lblLema.Location = new Point(10, 35);
                lblLema.Size = new Size(280, 20);
                lblLema.Tag = p.PlanchaID;

                // Cargar candidatos de la plancha
                using (var cn = Conexion.ObtenerConexion())
                {
                    string query = @"SELECT NombrePuesto, NombreCompleto 
                     FROM vw_CandidatosPorPlancha 
                     WHERE PlanchaID = @PlanchaID
                     ORDER BY Orden";
                    var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@PlanchaID", p.PlanchaID);
                    cn.Open();
                    var dr = cmd.ExecuteReader();
                    int yLabel = 60;
                    while (dr.Read())
                    {
                        Label lblPuesto = new Label();
                        lblPuesto.Text = dr["NombrePuesto"].ToString();
                        lblPuesto.ForeColor = Color.LightGray;
                        lblPuesto.Font = new Font("Arial", 8);
                        lblPuesto.Location = new Point(10, yLabel);
                        lblPuesto.AutoSize = true;
                        lblPuesto.Tag = p.PlanchaID;
                        lblPuesto.Click += Tarjeta_Click;

                        Label lblCandidato = new Label();
                        lblCandidato.Text = dr["NombreCompleto"].ToString();
                        lblCandidato.ForeColor = Color.White;
                        lblCandidato.Font = new Font("Arial", 9, FontStyle.Bold);
                        lblCandidato.Location = new Point(10, yLabel + 15);
                        lblCandidato.AutoSize = true;
                        lblCandidato.Tag = p.PlanchaID;
                        lblCandidato.Click += Tarjeta_Click;

                        tarjeta.Controls.Add(lblPuesto);
                        tarjeta.Controls.Add(lblCandidato);
                        yLabel += 35;
                    }
                }

                // Logo si existe
                if (!string.IsNullOrEmpty(p.LogoRuta) && System.IO.File.Exists(p.LogoRuta))
                {
                    PictureBox logo = new PictureBox();
                    logo.Image = Image.FromFile(p.LogoRuta);
                    logo.Size = new Size(60, 60);
                    logo.Location = new Point(220, 10);
                    logo.SizeMode = PictureBoxSizeMode.Zoom;
                    logo.Tag = p.PlanchaID;
                    logo.Click += Tarjeta_Click;
                    tarjeta.Controls.Add(logo);
                }

                tarjeta.Controls.Add(lblNombre);
                tarjeta.Controls.Add(lblLema);

                // Evento click en la tarjetac
                tarjeta.Click += Tarjeta_Click;
                lblNombre.Click += Tarjeta_Click;
                lblLema.Click += Tarjeta_Click;

                pnlPlanchas.Controls.Add(tarjeta);
                tarjeta.MouseClick += (s, ev) => Tarjeta_Click(tarjeta, ev);

                columna++;
                if (columna == 2)
                {
                    columna = 0;
                    y += alto + 15;
                }
            }
        }

        private void Tarjeta_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            // Subir hasta encontrar el panel tarjeta
            while (ctrl.Parent != pnlPlanchas && ctrl.Parent != null)
                ctrl = ctrl.Parent;

            if (ctrl.Tag == null) return;

            int planchaID = (int)ctrl.Tag;
            _planchaSeleccionadaID = planchaID;

            // Resaltar plancha seleccionada
            foreach (Control c in pnlPlanchas.Controls)
            {
                if (c is Panel)
                {
                    c.BackColor = (int)c.Tag == planchaID
                        ? Color.FromArgb(37, 99, 235)
                        : Color.FromArgb(30, 58, 95);
                }
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (_planchaSeleccionadaID == null)
            {
                MessageBox.Show("Por favor selecciona una plancha antes de votar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estas seguro de votar por esta plancha? Esta accion no se puede deshacer.",
                "Confirmar Voto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var resultado = VotoBLL.EmitirVoto(_usuarioActual.UsuarioID, _planchaSeleccionadaID, false);
                MessageBox.Show(resultado.mensaje,
                    resultado.exito ? "Exito" : "Error",
                    MessageBoxButtons.OK,
                    resultado.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (resultado.exito)
                {
                    btnVotar.Enabled = false;
                    btnVotoNulo.Enabled = false;
                }
            }
        }

        private void btnVotoNulo_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "¿Estas seguro de emitir un voto nulo?",
                "Confirmar Voto Nulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var resultado = VotoBLL.EmitirVoto(_usuarioActual.UsuarioID, null, true);
                MessageBox.Show(resultado.mensaje,
                    resultado.exito ? "Exito" : "Error",
                    MessageBoxButtons.OK,
                    resultado.exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (resultado.exito)
                {
                    btnVotar.Enabled = false;
                    btnVotoNulo.Enabled = false;
                }
            }
        }
    }
}
