namespace SistemaElectoral1.Vistas
{
    partial class frmMenu
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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnPlanchas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVotar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblBienvenida);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 90);
            this.panel1.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblRol.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(17, 61);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(150, 18);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Director";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(15, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(400, 31);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido, Juan perez";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(40, 109);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(390, 45);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "👥 Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanel.ForeColor = System.Drawing.Color.White;
            this.btnPanel.Location = new System.Drawing.Point(40, 230);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(390, 45);
            this.btnPanel.TabIndex = 2;
            this.btnPanel.Text = "📄 Panel de votacion";
            this.btnPanel.UseVisualStyleBackColor = false;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnPlanchas
            // 
            this.btnPlanchas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlanchas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanchas.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanchas.ForeColor = System.Drawing.Color.White;
            this.btnPlanchas.Location = new System.Drawing.Point(40, 170);
            this.btnPlanchas.Name = "btnPlanchas";
            this.btnPlanchas.Size = new System.Drawing.Size(390, 45);
            this.btnPlanchas.TabIndex = 3;
            this.btnPlanchas.Text = "🗳️ Planchas electorales";
            this.btnPlanchas.UseVisualStyleBackColor = false;
            this.btnPlanchas.Click += new System.EventHandler(this.btnPlanchas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(40, 290);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(390, 45);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "📄 Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodo.ForeColor = System.Drawing.Color.White;
            this.btnPeriodo.Location = new System.Drawing.Point(40, 353);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(390, 45);
            this.btnPeriodo.TabIndex = 5;
            this.btnPeriodo.Text = "⏱️ Gestionar Periodo";
            this.btnPeriodo.UseVisualStyleBackColor = false;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(40, 495);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(390, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "Cerrar sesion";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseCaptureChanged += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(40, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 10);
            this.panel2.TabIndex = 7;
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.Color.White;
            this.btnVotar.Location = new System.Drawing.Point(40, 418);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(390, 45);
            this.btnVotar.TabIndex = 8;
            this.btnVotar.Text = "🗳️ Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(454, 561);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnPeriodo);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnPlanchas);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnPlanchas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVotar;
    }
}