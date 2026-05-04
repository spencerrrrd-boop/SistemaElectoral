namespace SistemaElectoral1.Vistas
{
    partial class frmPeriodo
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 22);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gestionar Período de Votación";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 21);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(34, 104);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(540, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(30, 140);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(95, 21);
            this.lblInicio.TabIndex = 6;
            this.lblInicio.Text = "Fecha Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = " dd/MM/yyyy HH:mm";
            this.dtpInicio.Location = new System.Drawing.Point(34, 164);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(250, 20);
            this.dtpInicio.TabIndex = 7;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.ForeColor = System.Drawing.Color.White;
            this.lblFin.Location = new System.Drawing.Point(310, 140);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(76, 21);
            this.lblFin.TabIndex = 8;
            this.lblFin.Text = "Fecha Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFin.Location = new System.Drawing.Point(314, 164);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(250, 20);
            this.dtpFin.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCrear.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(34, 205);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 35);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear Período";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 2);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Periodos registrados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPeriodos
            // 
            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodos.Location = new System.Drawing.Point(32, 283);
            this.dgvPeriodos.Name = "dgvPeriodos";
            this.dgvPeriodos.Size = new System.Drawing.Size(560, 200);
            this.dgvPeriodos.TabIndex = 12;
            this.dgvPeriodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeriodos_CellClick);
            // 
            // frmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(604, 511);
            this.Controls.Add(this.dgvPeriodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeriodo";
            this.Load += new System.EventHandler(this.frmPeriodo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPeriodos;
    }
}