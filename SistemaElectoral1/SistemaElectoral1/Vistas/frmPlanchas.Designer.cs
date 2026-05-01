namespace SistemaElectoral1.Vistas
{
    partial class frmPlanchas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombrePlancha = new System.Windows.Forms.Label();
            this.lblLema = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.txtNombrePlancha = new System.Windows.Forms.TextBox();
            this.txtLema = new System.Windows.Forms.TextBox();
            this.txtLogoRuta = new System.Windows.Forms.TextBox();
            this.btnSeleccionarLogo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCandidatos = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblCandidatoMat = new System.Windows.Forms.Label();
            this.txtCandidatoMatricula = new System.Windows.Forms.TextBox();
            this.btnAgregarCandidato = new System.Windows.Forms.Button();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Planchas Electorales";
            // 
            // lblNombrePlancha
            // 
            this.lblNombrePlancha.AutoSize = true;
            this.lblNombrePlancha.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlancha.ForeColor = System.Drawing.Color.White;
            this.lblNombrePlancha.Location = new System.Drawing.Point(30, 80);
            this.lblNombrePlancha.Name = "lblNombrePlancha";
            this.lblNombrePlancha.Size = new System.Drawing.Size(169, 21);
            this.lblNombrePlancha.TabIndex = 1;
            this.lblNombrePlancha.Text = "Nombre de la Plancha";
            // 
            // lblLema
            // 
            this.lblLema.AutoSize = true;
            this.lblLema.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLema.ForeColor = System.Drawing.Color.White;
            this.lblLema.Location = new System.Drawing.Point(380, 80);
            this.lblLema.Name = "lblLema";
            this.lblLema.Size = new System.Drawing.Size(49, 21);
            this.lblLema.TabIndex = 2;
            this.lblLema.Text = "Lema";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(30, 140);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(132, 21);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "Logo del Partido";
            // 
            // txtNombrePlancha
            // 
            this.txtNombrePlancha.Location = new System.Drawing.Point(34, 104);
            this.txtNombrePlancha.Name = "txtNombrePlancha";
            this.txtNombrePlancha.Size = new System.Drawing.Size(280, 20);
            this.txtNombrePlancha.TabIndex = 4;
            // 
            // txtLema
            // 
            this.txtLema.Location = new System.Drawing.Point(384, 104);
            this.txtLema.Name = "txtLema";
            this.txtLema.Size = new System.Drawing.Size(280, 20);
            this.txtLema.TabIndex = 5;
            // 
            // txtLogoRuta
            // 
            this.txtLogoRuta.Location = new System.Drawing.Point(34, 164);
            this.txtLogoRuta.Name = "txtLogoRuta";
            this.txtLogoRuta.ReadOnly = true;
            this.txtLogoRuta.Size = new System.Drawing.Size(380, 20);
            this.txtLogoRuta.TabIndex = 6;
            // 
            // btnSeleccionarLogo
            // 
            this.btnSeleccionarLogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeleccionarLogo.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarLogo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLogo.Location = new System.Drawing.Point(420, 160);
            this.btnSeleccionarLogo.Name = "btnSeleccionarLogo";
            this.btnSeleccionarLogo.Size = new System.Drawing.Size(120, 25);
            this.btnSeleccionarLogo.TabIndex = 7;
            this.btnSeleccionarLogo.Text = "Seleccionar";
            this.btnSeleccionarLogo.UseVisualStyleBackColor = false;
            this.btnSeleccionarLogo.Click += new System.EventHandler(this.btnSeleccionarLogo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 205);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 35);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(160, 205);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 2);
            this.panel2.TabIndex = 10;
            // 
            // lblCandidatos
            // 
            this.lblCandidatos.AutoSize = true;
            this.lblCandidatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidatos.ForeColor = System.Drawing.Color.White;
            this.lblCandidatos.Location = new System.Drawing.Point(30, 270);
            this.lblCandidatos.Name = "lblCandidatos";
            this.lblCandidatos.Size = new System.Drawing.Size(199, 20);
            this.lblCandidatos.TabIndex = 11;
            this.lblCandidatos.Text = "Candidatos de la Plancha";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(30, 300);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(60, 21);
            this.lblPuesto.TabIndex = 12;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(34, 324);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(200, 21);
            this.cmbPuesto.TabIndex = 13;
            // 
            // lblCandidatoMat
            // 
            this.lblCandidatoMat.AutoSize = true;
            this.lblCandidatoMat.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidatoMat.ForeColor = System.Drawing.Color.White;
            this.lblCandidatoMat.Location = new System.Drawing.Point(280, 300);
            this.lblCandidatoMat.Name = "lblCandidatoMat";
            this.lblCandidatoMat.Size = new System.Drawing.Size(184, 21);
            this.lblCandidatoMat.TabIndex = 15;
            this.lblCandidatoMat.Text = "Matrícula del Candidato";
            // 
            // txtCandidatoMatricula
            // 
            this.txtCandidatoMatricula.Location = new System.Drawing.Point(284, 325);
            this.txtCandidatoMatricula.Name = "txtCandidatoMatricula";
            this.txtCandidatoMatricula.Size = new System.Drawing.Size(200, 20);
            this.txtCandidatoMatricula.TabIndex = 16;
            // 
            // btnAgregarCandidato
            // 
            this.btnAgregarCandidato.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAgregarCandidato.CausesValidation = false;
            this.btnAgregarCandidato.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCandidato.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCandidato.Location = new System.Drawing.Point(34, 360);
            this.btnAgregarCandidato.Name = "btnAgregarCandidato";
            this.btnAgregarCandidato.Size = new System.Drawing.Size(171, 35);
            this.btnAgregarCandidato.TabIndex = 17;
            this.btnAgregarCandidato.Text = "Agregar Candidato";
            this.btnAgregarCandidato.UseVisualStyleBackColor = false;
            this.btnAgregarCandidato.Click += new System.EventHandler(this.btnAgregarCandidato_Click);
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.CausesValidation = false;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(30, 410);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.Size = new System.Drawing.Size(680, 200);
            this.dgvCandidatos.TabIndex = 18;
            // 
            // frmPlanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(724, 641);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.btnAgregarCandidato);
            this.Controls.Add(this.txtCandidatoMatricula);
            this.Controls.Add(this.lblCandidatoMat);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblCandidatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionarLogo);
            this.Controls.Add(this.txtLogoRuta);
            this.Controls.Add(this.txtLema);
            this.Controls.Add(this.txtNombrePlancha);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblLema);
            this.Controls.Add(this.lblNombrePlancha);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlanchas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlanchas";
            this.Load += new System.EventHandler(this.frmPlanchas_Load);
            this.Click += new System.EventHandler(this.frmPlanchas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombrePlancha;
        private System.Windows.Forms.Label lblLema;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtNombrePlancha;
        private System.Windows.Forms.TextBox txtLema;
        private System.Windows.Forms.TextBox txtLogoRuta;
        private System.Windows.Forms.Button btnSeleccionarLogo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCandidatos;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblCandidatoMat;
        private System.Windows.Forms.TextBox txtCandidatoMatricula;
        private System.Windows.Forms.Button btnAgregarCandidato;
        private System.Windows.Forms.DataGridView dgvCandidatos;
    }
}