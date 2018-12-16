namespace appSugerencias
{
    partial class ReporteCalificaciones
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
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.BT_reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(273, 70);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 0;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(273, 96);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            // 
            // BT_reporte
            // 
            this.BT_reporte.Location = new System.Drawing.Point(273, 122);
            this.BT_reporte.Name = "BT_reporte";
            this.BT_reporte.Size = new System.Drawing.Size(200, 51);
            this.BT_reporte.TabIndex = 2;
            this.BT_reporte.Text = "Aceptar";
            this.BT_reporte.UseVisualStyleBackColor = true;
            this.BT_reporte.Click += new System.EventHandler(this.BT_reporte_Click);
            // 
            // ReporteCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_reporte);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "ReporteCalificaciones";
            this.Text = "ReporteCalificaciones";
            this.Load += new System.EventHandler(this.ReporteCalificaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button BT_reporte;
    }
}