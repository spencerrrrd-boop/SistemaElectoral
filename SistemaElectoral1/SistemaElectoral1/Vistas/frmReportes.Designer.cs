namespace SistemaElectoral1.Vistas
{
    partial class frmReportes
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
            this.btnReporteGeneral = new System.Windows.Forms.Button();
            this.btnPlanchaGanadora = new System.Windows.Forms.Button();
            this.btnIntegrantes = new System.Windows.Forms.Button();
            this.btnParticipantes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
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
            this.lblTitulo.Location = new System.Drawing.Point(21, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 22);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Reportes del Sistema";
            // 
            // btnReporteGeneral
            // 
            this.btnReporteGeneral.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReporteGeneral.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGeneral.ForeColor = System.Drawing.Color.White;
            this.btnReporteGeneral.Location = new System.Drawing.Point(30, 80);
            this.btnReporteGeneral.Name = "btnReporteGeneral";
            this.btnReporteGeneral.Size = new System.Drawing.Size(320, 60);
            this.btnReporteGeneral.TabIndex = 1;
            this.btnReporteGeneral.Text = "📊 Reporte General de Votos";
            this.btnReporteGeneral.UseVisualStyleBackColor = false;
            this.btnReporteGeneral.Click += new System.EventHandler(this.btnReporteGeneral_Click);
            // 
            // btnPlanchaGanadora
            // 
            this.btnPlanchaGanadora.BackColor = System.Drawing.Color.Gold;
            this.btnPlanchaGanadora.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanchaGanadora.ForeColor = System.Drawing.Color.Black;
            this.btnPlanchaGanadora.Location = new System.Drawing.Point(370, 80);
            this.btnPlanchaGanadora.Name = "btnPlanchaGanadora";
            this.btnPlanchaGanadora.Size = new System.Drawing.Size(320, 60);
            this.btnPlanchaGanadora.TabIndex = 2;
            this.btnPlanchaGanadora.Text = "🏆 Plancha Ganadora";
            this.btnPlanchaGanadora.UseVisualStyleBackColor = false;
            this.btnPlanchaGanadora.Click += new System.EventHandler(this.btnPlanchaGanadora_Click);
            // 
            // btnIntegrantes
            // 
            this.btnIntegrantes.BackColor = System.Drawing.Color.MediumBlue;
            this.btnIntegrantes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegrantes.ForeColor = System.Drawing.Color.White;
            this.btnIntegrantes.Location = new System.Drawing.Point(30, 155);
            this.btnIntegrantes.Name = "btnIntegrantes";
            this.btnIntegrantes.Size = new System.Drawing.Size(320, 60);
            this.btnIntegrantes.TabIndex = 3;
            this.btnIntegrantes.Text = "👥 Integrantes del Partido";
            this.btnIntegrantes.UseVisualStyleBackColor = false;
            this.btnIntegrantes.Click += new System.EventHandler(this.btnIntegrantes_Click);
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.BackColor = System.Drawing.Color.MediumBlue;
            this.btnParticipantes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipantes.ForeColor = System.Drawing.Color.White;
            this.btnParticipantes.Location = new System.Drawing.Point(370, 155);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(320, 60);
            this.btnParticipantes.TabIndex = 4;
            this.btnParticipantes.Text = "📋 Listado de Participantes";
            this.btnParticipantes.UseVisualStyleBackColor = false;
            this.btnParticipantes.Click += new System.EventHandler(this.btnParticipantes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 2);
            this.panel2.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(21, 254);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(171, 20);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado del Reporte";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExportar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(592, 251);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 30);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar PDF";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(25, 287);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(680, 280);
            this.dgvReporte.TabIndex = 14;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(724, 581);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnParticipantes);
            this.Controls.Add(this.btnIntegrantes);
            this.Controls.Add(this.btnPlanchaGanadora);
            this.Controls.Add(this.btnReporteGeneral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.Click += new System.EventHandler(this.frmReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReporteGeneral;
        private System.Windows.Forms.Button btnPlanchaGanadora;
        private System.Windows.Forms.Button btnIntegrantes;
        private System.Windows.Forms.Button btnParticipantes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}