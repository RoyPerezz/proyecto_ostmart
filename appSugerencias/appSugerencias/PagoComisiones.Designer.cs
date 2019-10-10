namespace appSugerencias
{
    partial class PagoComisiones
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
            this.DG_comisiones = new System.Windows.Forms.DataGridView();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.LB_inicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_comisiones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_comisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_comisiones
            // 
            this.DG_comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_comisiones.Location = new System.Drawing.Point(42, 71);
            this.DG_comisiones.Name = "DG_comisiones";
            this.DG_comisiones.Size = new System.Drawing.Size(616, 259);
            this.DG_comisiones.TabIndex = 0;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(76, 41);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(76, 15);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // LB_inicio
            // 
            this.LB_inicio.AutoSize = true;
            this.LB_inicio.Location = new System.Drawing.Point(38, 18);
            this.LB_inicio.Name = "LB_inicio";
            this.LB_inicio.Size = new System.Drawing.Size(32, 13);
            this.LB_inicio.TabIndex = 3;
            this.LB_inicio.Text = "Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fin";
            // 
            // BT_comisiones
            // 
            this.BT_comisiones.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_comisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_comisiones.ForeColor = System.Drawing.Color.White;
            this.BT_comisiones.Location = new System.Drawing.Point(549, 15);
            this.BT_comisiones.Name = "BT_comisiones";
            this.BT_comisiones.Size = new System.Drawing.Size(109, 50);
            this.BT_comisiones.TabIndex = 5;
            this.BT_comisiones.Text = "Comisiones";
            this.BT_comisiones.UseVisualStyleBackColor = false;
            this.BT_comisiones.Click += new System.EventHandler(this.BT_comisiones_Click);
            // 
            // PagoComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(703, 360);
            this.Controls.Add(this.BT_comisiones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_inicio);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DG_comisiones);
            this.Name = "PagoComisiones";
            this.Text = "PagoComisiones";
            this.Load += new System.EventHandler(this.PagoComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_comisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_comisiones;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.Label LB_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_comisiones;
    }
}