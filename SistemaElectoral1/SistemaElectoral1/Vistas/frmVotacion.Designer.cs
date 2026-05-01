namespace SistemaElectoral1.Vistas
{
    partial class frmVotacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblInstruccion;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPlanchas = new System.Windows.Forms.Panel();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVotoNulo = new System.Windows.Forms.Button();
            lblInstruccion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblInstruccion.ForeColor = System.Drawing.Color.White;
            lblInstruccion.Location = new System.Drawing.Point(214, 77);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new System.Drawing.Size(299, 21);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Selecciona una plancha para emitir tu voto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(500, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(26, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "aa";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(252, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema Electoral - Votación";
            // 
            // pnlPlanchas
            // 
            this.pnlPlanchas.AutoScroll = true;
            this.pnlPlanchas.Location = new System.Drawing.Point(24, 111);
            this.pnlPlanchas.Name = "pnlPlanchas";
            this.pnlPlanchas.Size = new System.Drawing.Size(680, 350);
            this.pnlPlanchas.TabIndex = 2;
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVotar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.Color.White;
            this.btnVotar.Location = new System.Drawing.Point(99, 476);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(280, 40);
            this.btnVotar.TabIndex = 3;
            this.btnVotar.Text = "Votar por Plancha Seleccionada";
            this.btnVotar.UseVisualStyleBackColor = false;
            // 
            // btnVotoNulo
            // 
            this.btnVotoNulo.BackColor = System.Drawing.Color.Gray;
            this.btnVotoNulo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotoNulo.ForeColor = System.Drawing.Color.White;
            this.btnVotoNulo.Location = new System.Drawing.Point(406, 476);
            this.btnVotoNulo.Name = "btnVotoNulo";
            this.btnVotoNulo.Size = new System.Drawing.Size(150, 40);
            this.btnVotoNulo.TabIndex = 4;
            this.btnVotoNulo.Text = "Voto Nulo";
            this.btnVotoNulo.UseVisualStyleBackColor = false;
            // 
            // frmVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.btnVotoNulo);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.pnlPlanchas);
            this.Controls.Add(lblInstruccion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVotacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVotacion";
            this.Load += new System.EventHandler(this.frmVotacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlPlanchas;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnVotoNulo;
    }
}