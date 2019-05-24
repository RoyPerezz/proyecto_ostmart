namespace appSugerencias
{
    partial class RPT_SaldoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPT_SaldoProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_reporte = new System.Windows.Forms.DataGridView();
            this.LB_estado = new System.Windows.Forms.Label();
            this.CHB_saldo = new System.Windows.Forms.CheckBox();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.TB_suc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "COLOSO",
            "RENA",
            "VALLARTA",
            "VELAZQUEZ"});
            this.CB_sucursal.Location = new System.Drawing.Point(91, 14);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(122, 21);
            this.CB_sucursal.TabIndex = 0;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUCURSAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(577, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "PDF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DG_reporte
            // 
            this.DG_reporte.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DG_reporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_reporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_reporte.Location = new System.Drawing.Point(13, 50);
            this.DG_reporte.Name = "DG_reporte";
            this.DG_reporte.Size = new System.Drawing.Size(638, 205);
            this.DG_reporte.TabIndex = 3;
            // 
            // LB_estado
            // 
            this.LB_estado.AutoSize = true;
            this.LB_estado.Location = new System.Drawing.Point(217, 16);
            this.LB_estado.Name = "LB_estado";
            this.LB_estado.Size = new System.Drawing.Size(0, 13);
            this.LB_estado.TabIndex = 4;
            // 
            // CHB_saldo
            // 
            this.CHB_saldo.AutoSize = true;
            this.CHB_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_saldo.Location = new System.Drawing.Point(429, 18);
            this.CHB_saldo.Name = "CHB_saldo";
            this.CHB_saldo.Size = new System.Drawing.Size(222, 17);
            this.CHB_saldo.TabIndex = 5;
            this.CHB_saldo.Text = "Solo incluir proveedores con saldo";
            this.CHB_saldo.UseVisualStyleBackColor = true;
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(219, 14);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 6;
            this.DT_fecha.Visible = false;
            // 
            // TB_suc
            // 
            this.TB_suc.Location = new System.Drawing.Point(15, 261);
            this.TB_suc.Name = "TB_suc";
            this.TB_suc.Size = new System.Drawing.Size(169, 20);
            this.TB_suc.TabIndex = 7;
            this.TB_suc.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(472, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RPT_SaldoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(663, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TB_suc);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.CHB_saldo);
            this.Controls.Add(this.LB_estado);
            this.Controls.Add(this.DG_reporte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_sucursal);
            this.Name = "RPT_SaldoProveedores";
            this.Text = "Resumen de Saldos";
            this.Load += new System.EventHandler(this.RPT_SaldoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DG_reporte;
        private System.Windows.Forms.Label LB_estado;
        private System.Windows.Forms.CheckBox CHB_saldo;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        public System.Windows.Forms.ComboBox CB_sucursal;
        public System.Windows.Forms.TextBox TB_suc;
        private System.Windows.Forms.Button button2;
    }
}