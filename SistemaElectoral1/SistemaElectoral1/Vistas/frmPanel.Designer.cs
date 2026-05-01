namespace SistemaElectoral1.Vistas
{
    partial class frmPanel
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEnVivo = new System.Windows.Forms.Label();
            this.gbPadron = new System.Windows.Forms.GroupBox();
            this.gbVotos = new System.Windows.Forms.GroupBox();
            this.gbNulos = new System.Windows.Forms.GroupBox();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblPadronNum = new System.Windows.Forms.Label();
            this.lblPadronTxt = new System.Windows.Forms.Label();
            this.lblVotosTxt = new System.Windows.Forms.Label();
            this.lblNulosTxt = new System.Windows.Forms.Label();
            this.lblTiempoTxt = new System.Windows.Forms.Label();
            this.lblVotosNum = new System.Windows.Forms.Label();
            this.lblNulosNum = new System.Windows.Forms.Label();
            this.lblTiempoNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbPadron.SuspendLayout();
            this.gbVotos.SuspendLayout();
            this.gbNulos.SuspendLayout();
            this.gbTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblEnVivo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Panel de Votaciones";
            // 
            // lblEnVivo
            // 
            this.lblEnVivo.AutoSize = true;
            this.lblEnVivo.BackColor = System.Drawing.Color.SeaGreen;
            this.lblEnVivo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnVivo.ForeColor = System.Drawing.Color.White;
            this.lblEnVivo.Location = new System.Drawing.Point(600, 22);
            this.lblEnVivo.Name = "lblEnVivo";
            this.lblEnVivo.Size = new System.Drawing.Size(100, 22);
            this.lblEnVivo.TabIndex = 2;
            this.lblEnVivo.Text = "● EN VIVO";
            // 
            // gbPadron
            // 
            this.gbPadron.BackColor = System.Drawing.Color.Gray;
            this.gbPadron.Controls.Add(this.lblPadronTxt);
            this.gbPadron.Controls.Add(this.lblPadronNum);
            this.gbPadron.Location = new System.Drawing.Point(20, 80);
            this.gbPadron.Name = "gbPadron";
            this.gbPadron.Size = new System.Drawing.Size(155, 70);
            this.gbPadron.TabIndex = 2;
            this.gbPadron.TabStop = false;
            // 
            // gbVotos
            // 
            this.gbVotos.BackColor = System.Drawing.Color.Gray;
            this.gbVotos.Controls.Add(this.lblVotosNum);
            this.gbVotos.Controls.Add(this.lblVotosTxt);
            this.gbVotos.Location = new System.Drawing.Point(192, 80);
            this.gbVotos.Name = "gbVotos";
            this.gbVotos.Size = new System.Drawing.Size(155, 70);
            this.gbVotos.TabIndex = 3;
            this.gbVotos.TabStop = false;
            // 
            // gbNulos
            // 
            this.gbNulos.BackColor = System.Drawing.Color.Gray;
            this.gbNulos.Controls.Add(this.lblNulosNum);
            this.gbNulos.Controls.Add(this.lblNulosTxt);
            this.gbNulos.Location = new System.Drawing.Point(365, 80);
            this.gbNulos.Name = "gbNulos";
            this.gbNulos.Size = new System.Drawing.Size(155, 70);
            this.gbNulos.TabIndex = 3;
            this.gbNulos.TabStop = false;
            // 
            // gbTiempo
            // 
            this.gbTiempo.BackColor = System.Drawing.Color.Gray;
            this.gbTiempo.Controls.Add(this.lblTiempoNum);
            this.gbTiempo.Controls.Add(this.lblTiempoTxt);
            this.gbTiempo.Location = new System.Drawing.Point(535, 80);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(155, 70);
            this.gbTiempo.TabIndex = 3;
            this.gbTiempo.TabStop = false;
            // 
            // lblPadronNum
            // 
            this.lblPadronNum.AutoSize = true;
            this.lblPadronNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadronNum.ForeColor = System.Drawing.Color.White;
            this.lblPadronNum.Location = new System.Drawing.Point(61, 18);
            this.lblPadronNum.Name = "lblPadronNum";
            this.lblPadronNum.Size = new System.Drawing.Size(32, 33);
            this.lblPadronNum.TabIndex = 0;
            this.lblPadronNum.Text = "0";
            // 
            // lblPadronTxt
            // 
            this.lblPadronTxt.AutoSize = true;
            this.lblPadronTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblPadronTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadronTxt.ForeColor = System.Drawing.Color.White;
            this.lblPadronTxt.Location = new System.Drawing.Point(36, 51);
            this.lblPadronTxt.Name = "lblPadronTxt";
            this.lblPadronTxt.Size = new System.Drawing.Size(77, 15);
            this.lblPadronTxt.TabIndex = 2;
            this.lblPadronTxt.Text = "Padrón Total";
            // 
            // lblVotosTxt
            // 
            this.lblVotosTxt.AutoSize = true;
            this.lblVotosTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblVotosTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotosTxt.ForeColor = System.Drawing.Color.White;
            this.lblVotosTxt.Location = new System.Drawing.Point(33, 51);
            this.lblVotosTxt.Name = "lblVotosTxt";
            this.lblVotosTxt.Size = new System.Drawing.Size(88, 15);
            this.lblVotosTxt.TabIndex = 3;
            this.lblVotosTxt.Text = "Votos Emitidos";
            // 
            // lblNulosTxt
            // 
            this.lblNulosTxt.AutoSize = true;
            this.lblNulosTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblNulosTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulosTxt.ForeColor = System.Drawing.Color.White;
            this.lblNulosTxt.Location = new System.Drawing.Point(41, 51);
            this.lblNulosTxt.Name = "lblNulosTxt";
            this.lblNulosTxt.Size = new System.Drawing.Size(72, 15);
            this.lblNulosTxt.TabIndex = 4;
            this.lblNulosTxt.Text = "Votos Nulos";
            // 
            // lblTiempoTxt
            // 
            this.lblTiempoTxt.AutoSize = true;
            this.lblTiempoTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTxt.ForeColor = System.Drawing.Color.White;
            this.lblTiempoTxt.Location = new System.Drawing.Point(28, 51);
            this.lblTiempoTxt.Name = "lblTiempoTxt";
            this.lblTiempoTxt.Size = new System.Drawing.Size(101, 15);
            this.lblTiempoTxt.TabIndex = 5;
            this.lblTiempoTxt.Text = "Tiempo Restante";
            // 
            // lblVotosNum
            // 
            this.lblVotosNum.AutoSize = true;
            this.lblVotosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotosNum.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblVotosNum.Location = new System.Drawing.Point(61, 18);
            this.lblVotosNum.Name = "lblVotosNum";
            this.lblVotosNum.Size = new System.Drawing.Size(32, 33);
            this.lblVotosNum.TabIndex = 3;
            this.lblVotosNum.Text = "0";
            // 
            // lblNulosNum
            // 
            this.lblNulosNum.AutoSize = true;
            this.lblNulosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNulosNum.ForeColor = System.Drawing.Color.Salmon;
            this.lblNulosNum.Location = new System.Drawing.Point(61, 18);
            this.lblNulosNum.Name = "lblNulosNum";
            this.lblNulosNum.Size = new System.Drawing.Size(32, 33);
            this.lblNulosNum.TabIndex = 4;
            this.lblNulosNum.Text = "0";
            // 
            // lblTiempoNum
            // 
            this.lblTiempoNum.AutoSize = true;
            this.lblTiempoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoNum.ForeColor = System.Drawing.Color.Yellow;
            this.lblTiempoNum.Location = new System.Drawing.Point(14, 16);
            this.lblTiempoNum.Name = "lblTiempoNum";
            this.lblTiempoNum.Size = new System.Drawing.Size(135, 33);
            this.lblTiempoNum.TabIndex = 5;
            this.lblTiempoNum.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "PARTICIPACIÓN POR PLANCHA";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(20, 235);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(680, 220);
            this.dgvResultados.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(724, 511);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.gbNulos);
            this.Controls.Add(this.gbVotos);
            this.Controls.Add(this.gbPadron);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPanel";
            this.Load += new System.EventHandler(this.frmPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPadron.ResumeLayout(false);
            this.gbPadron.PerformLayout();
            this.gbVotos.ResumeLayout(false);
            this.gbVotos.PerformLayout();
            this.gbNulos.ResumeLayout(false);
            this.gbNulos.PerformLayout();
            this.gbTiempo.ResumeLayout(false);
            this.gbTiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEnVivo;
        private System.Windows.Forms.GroupBox gbPadron;
        private System.Windows.Forms.GroupBox gbVotos;
        private System.Windows.Forms.GroupBox gbNulos;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblPadronTxt;
        private System.Windows.Forms.Label lblPadronNum;
        private System.Windows.Forms.Label lblVotosTxt;
        private System.Windows.Forms.Label lblNulosTxt;
        private System.Windows.Forms.Label lblTiempoTxt;
        private System.Windows.Forms.Label lblVotosNum;
        private System.Windows.Forms.Label lblNulosNum;
        private System.Windows.Forms.Label lblTiempoNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Timer timer1;
    }
}