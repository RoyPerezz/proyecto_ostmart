namespace appSugerencias
{
    partial class ImprimirReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_sugerencias = new System.Windows.Forms.DataGridView();
            this.BT_Excel = new System.Windows.Forms.Button();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_cargo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_sugerencias)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(176, 27);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 0;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(176, 66);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Obtener Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DG_sugerencias
            // 
            this.DG_sugerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_sugerencias.Location = new System.Drawing.Point(52, 116);
            this.DG_sugerencias.Name = "DG_sugerencias";
            this.DG_sugerencias.Size = new System.Drawing.Size(421, 164);
            this.DG_sugerencias.TabIndex = 5;
            // 
            // BT_Excel
            // 
            this.BT_Excel.Location = new System.Drawing.Point(339, 358);
            this.BT_Excel.Name = "BT_Excel";
            this.BT_Excel.Size = new System.Drawing.Size(134, 61);
            this.BT_Excel.TabIndex = 6;
            this.BT_Excel.Text = "Generar Reporte";
            this.BT_Excel.UseVisualStyleBackColor = true;
            this.BT_Excel.Click += new System.EventHandler(this.BT_Excel_Click);
            // 
            // CB_tipo
            // 
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Items.AddRange(new object[] {
            "General",
            "Mantenimiento",
            "Sistemas",
            "Todas"});
            this.CB_tipo.Location = new System.Drawing.Point(316, 314);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(157, 21);
            this.CB_tipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sugerencias de";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cargo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CB_cargo
            // 
            this.CB_cargo.FormattingEnabled = true;
            this.CB_cargo.Items.AddRange(new object[] {
            "Asesora de Ventas",
            "Administrativo",
            "Cajera"});
            this.CB_cargo.Location = new System.Drawing.Point(46, 314);
            this.CB_cargo.Name = "CB_cargo";
            this.CB_cargo.Size = new System.Drawing.Size(157, 21);
            this.CB_cargo.TabIndex = 9;
            this.CB_cargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ImprimirReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.BT_Excel);
            this.Controls.Add(this.DG_sugerencias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "ImprimirReporte";
            this.Text = "ImprimirReporte";
            this.Load += new System.EventHandler(this.ImprimirReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_sugerencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DG_sugerencias;
        private System.Windows.Forms.Button BT_Excel;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_cargo;
    }
}