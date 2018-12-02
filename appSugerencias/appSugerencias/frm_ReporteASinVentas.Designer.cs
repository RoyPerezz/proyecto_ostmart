namespace appSugerencias
{
    partial class frm_ReporteASinVentas
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgASV = new System.Windows.Forms.DataGridView();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgASV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(47, 21);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(188, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(47, 67);
            this.dtFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(188, 20);
            this.dtFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin";
            // 
            // dgASV
            // 
            this.dgASV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgASV.Location = new System.Drawing.Point(10, 109);
            this.dgASV.Name = "dgASV";
            this.dgASV.Size = new System.Drawing.Size(896, 220);
            this.dgASV.TabIndex = 6;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(277, 21);
            this.btnDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(88, 45);
            this.btnDatos.TabIndex = 7;
            this.btnDatos.Text = "Obtener Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(419, 21);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(88, 45);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frm_ReporteASinVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 364);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.dgASV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ReporteASinVentas";
            this.Text = "frm_ReporteASinVentas";
            this.Load += new System.EventHandler(this.frm_ReporteASinVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgASV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgASV;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnReporte;
    }
}