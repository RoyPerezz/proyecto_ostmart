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
            this.BT_calcular = new System.Windows.Forms.Button();
            this.CAJERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETIQUETAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCENTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_comisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_comisiones
            // 
            this.DG_comisiones.AllowUserToAddRows = false;
            this.DG_comisiones.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DG_comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_comisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAJERA,
            this.FECHA1,
            this.FECHA2,
            this.FECHA3,
            this.FECHA4,
            this.FECHA5,
            this.FECHA6,
            this.FECHA7,
            this.ETIQUETAS,
            this.INCENTIVO,
            this.REPORTES,
            this.TOTAL});
            this.DG_comisiones.Location = new System.Drawing.Point(12, 71);
            this.DG_comisiones.Name = "DG_comisiones";
            this.DG_comisiones.Size = new System.Drawing.Size(1234, 259);
            this.DG_comisiones.TabIndex = 0;
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
            this.BT_comisiones.Location = new System.Drawing.Point(884, 12);
            this.BT_comisiones.Name = "BT_comisiones";
            this.BT_comisiones.Size = new System.Drawing.Size(109, 50);
            this.BT_comisiones.TabIndex = 5;
            this.BT_comisiones.Text = "Importar Datos";
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
            this.BT_exportar.Location = new System.Drawing.Point(1138, 11);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(109, 50);
            this.BT_exportar.TabIndex = 10;
            this.BT_exportar.Text = "Exportar Datos";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // BT_calcular
            // 
            this.BT_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calcular.ForeColor = System.Drawing.Color.White;
            this.BT_calcular.Location = new System.Drawing.Point(1012, 11);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(109, 50);
            this.BT_calcular.TabIndex = 11;
            this.BT_calcular.Text = "Calcular";
            this.BT_calcular.UseVisualStyleBackColor = false;
            this.BT_calcular.Click += new System.EventHandler(this.BT_calcular_Click);
            // 
            // CAJERA
            // 
            this.CAJERA.HeaderText = "CAJERA";
            this.CAJERA.Name = "CAJERA";
            // 
            // FECHA1
            // 
            this.FECHA1.HeaderText = "FECHA1";
            this.FECHA1.Name = "FECHA1";
            // 
            // FECHA2
            // 
            this.FECHA2.HeaderText = "FECHA2";
            this.FECHA2.Name = "FECHA2";
            // 
            // FECHA3
            // 
            this.FECHA3.HeaderText = "FECHA3";
            this.FECHA3.Name = "FECHA3";
            // 
            // FECHA4
            // 
            this.FECHA4.HeaderText = "FECHA4";
            this.FECHA4.Name = "FECHA4";
            // 
            // FECHA5
            // 
            this.FECHA5.HeaderText = "FECHA5";
            this.FECHA5.Name = "FECHA5";
            // 
            // FECHA6
            // 
            this.FECHA6.HeaderText = "FECHA6";
            this.FECHA6.Name = "FECHA6";
            // 
            // FECHA7
            // 
            this.FECHA7.HeaderText = "FECHA7";
            this.FECHA7.Name = "FECHA7";
            // 
            // ETIQUETAS
            // 
            this.ETIQUETAS.HeaderText = "ETIQUETAS";
            this.ETIQUETAS.Name = "ETIQUETAS";
            // 
            // INCENTIVO
            // 
            this.INCENTIVO.HeaderText = "INCENTIVO";
            this.INCENTIVO.Name = "INCENTIVO";
            // 
            // REPORTES
            // 
            this.REPORTES.HeaderText = "REPORTES";
            this.REPORTES.Name = "REPORTES";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // PagoComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1258, 472);
            this.Controls.Add(this.BT_calcular);
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
            this.Text = "Pago de comisiones de Cajeras";
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
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAJERA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETIQUETAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCENTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTES;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}