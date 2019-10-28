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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_incentivo = new System.Windows.Forms.Label();
            this.LB_comision = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_comisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_comisiones
            // 
            this.DG_comisiones.AllowUserToAddRows = false;
            this.DG_comisiones.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DG_comisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_comisiones.Location = new System.Drawing.Point(12, 71);
            this.DG_comisiones.Name = "DG_comisiones";
            this.DG_comisiones.Size = new System.Drawing.Size(1234, 259);
            this.DG_comisiones.TabIndex = 0;
            this.DG_comisiones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_comisiones_CellEndEdit);
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(59, 45);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(59, 19);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // LB_inicio
            // 
            this.LB_inicio.AutoSize = true;
            this.LB_inicio.Location = new System.Drawing.Point(21, 22);
            this.LB_inicio.Name = "LB_inicio";
            this.LB_inicio.Size = new System.Drawing.Size(32, 13);
            this.LB_inicio.TabIndex = 3;
            this.LB_inicio.Text = "Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
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
            this.BT_comisiones.Location = new System.Drawing.Point(1016, 17);
            this.BT_comisiones.Name = "BT_comisiones";
            this.BT_comisiones.Size = new System.Drawing.Size(109, 50);
            this.BT_comisiones.TabIndex = 5;
            this.BT_comisiones.Text = "Comisiones";
            this.BT_comisiones.UseVisualStyleBackColor = false;
            this.BT_comisiones.Click += new System.EventHandler(this.BT_comisiones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(839, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL INCENTIVO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(844, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "COMISION TOTAL";
            // 
            // LB_incentivo
            // 
            this.LB_incentivo.AutoSize = true;
            this.LB_incentivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_incentivo.Location = new System.Drawing.Point(960, 356);
            this.LB_incentivo.Name = "LB_incentivo";
            this.LB_incentivo.Size = new System.Drawing.Size(0, 25);
            this.LB_incentivo.TabIndex = 8;
            // 
            // LB_comision
            // 
            this.LB_comision.AutoSize = true;
            this.LB_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_comision.Location = new System.Drawing.Point(960, 387);
            this.LB_comision.Name = "LB_comision";
            this.LB_comision.Size = new System.Drawing.Size(0, 25);
            this.LB_comision.TabIndex = 9;
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(1131, 17);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(109, 50);
            this.BT_exportar.TabIndex = 10;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // PagoComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1258, 472);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.LB_comision);
            this.Controls.Add(this.LB_incentivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_incentivo;
        private System.Windows.Forms.Label LB_comision;
        private System.Windows.Forms.Button BT_exportar;
    }
}