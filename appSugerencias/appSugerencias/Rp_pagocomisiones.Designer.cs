namespace appSugerencias
{
    partial class Rp_pagocomisiones
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(17, 16);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 0;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(17, 42);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(53, 68);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(107, 35);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Reporte";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(3, 109);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(703, 13);
            this.tabla.TabIndex = 3;
            this.tabla.Visible = false;
            // 
            // Rp_pagocomisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 130);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "Rp_pagocomisiones";
            this.Text = "Rp_pagocomisiones";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.DataGridView tabla;
    }
}