namespace appSugerencias
{
    partial class frm_GastosExternos
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
            this.cbTienda = new System.Windows.Forms.ComboBox();
            this.cbGastos = new System.Windows.Forms.ComboBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.dtGastos = new System.Windows.Forms.DateTimePicker();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_pagara = new System.Windows.Forms.ComboBox();
            this.TB_saldobanco = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CB_cuentasOsmart = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CB_bancosOsmart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbTienda
            // 
            this.cbTienda.FormattingEnabled = true;
            this.cbTienda.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO",
            "PREGOT"});
            this.cbTienda.Location = new System.Drawing.Point(12, 43);
            this.cbTienda.Name = "cbTienda";
            this.cbTienda.Size = new System.Drawing.Size(121, 21);
            this.cbTienda.TabIndex = 0;
            this.cbTienda.SelectedIndexChanged += new System.EventHandler(this.cbTienda_SelectedIndexChanged);
            // 
            // cbGastos
            // 
            this.cbGastos.FormattingEnabled = true;
            this.cbGastos.Location = new System.Drawing.Point(179, 43);
            this.cbGastos.Name = "cbGastos";
            this.cbGastos.Size = new System.Drawing.Size(232, 21);
            this.cbGastos.TabIndex = 1;
            this.cbGastos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tbImporte
            // 
            this.tbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImporte.Location = new System.Drawing.Point(388, 226);
            this.tbImporte.Multiline = true;
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(189, 29);
            this.tbImporte.TabIndex = 2;
            this.tbImporte.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtGastos
            // 
            this.dtGastos.Location = new System.Drawing.Point(452, 44);
            this.dtGastos.Name = "dtGastos";
            this.dtGastos.Size = new System.Drawing.Size(200, 20);
            this.dtGastos.TabIndex = 3;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservaciones.Location = new System.Drawing.Point(12, 321);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(399, 46);
            this.tbObservaciones.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Referencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tienda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // CB_pagara
            // 
            this.CB_pagara.FormattingEnabled = true;
            this.CB_pagara.Location = new System.Drawing.Point(12, 247);
            this.CB_pagara.Name = "CB_pagara";
            this.CB_pagara.Size = new System.Drawing.Size(229, 21);
            this.CB_pagara.TabIndex = 52;
            // 
            // TB_saldobanco
            // 
            this.TB_saldobanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_saldobanco.Location = new System.Drawing.Point(388, 138);
            this.TB_saldobanco.Multiline = true;
            this.TB_saldobanco.Name = "TB_saldobanco";
            this.TB_saldobanco.Size = new System.Drawing.Size(189, 31);
            this.TB_saldobanco.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(385, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 18);
            this.label17.TabIndex = 48;
            this.label17.Text = "Saldo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 46;
            this.label16.Text = "Depositar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 18);
            this.label15.TabIndex = 45;
            this.label15.Text = "Cuenta";
            // 
            // CB_cuentasOsmart
            // 
            this.CB_cuentasOsmart.FormattingEnabled = true;
            this.CB_cuentasOsmart.Items.AddRange(new object[] {
            "  "});
            this.CB_cuentasOsmart.Location = new System.Drawing.Point(12, 190);
            this.CB_cuentasOsmart.Name = "CB_cuentasOsmart";
            this.CB_cuentasOsmart.Size = new System.Drawing.Size(148, 21);
            this.CB_cuentasOsmart.TabIndex = 44;
            this.CB_cuentasOsmart.SelectedIndexChanged += new System.EventHandler(this.CB_cuentasOsmart_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 42;
            this.label14.Text = "Banco";
            // 
            // CB_bancosOsmart
            // 
            this.CB_bancosOsmart.FormattingEnabled = true;
            this.CB_bancosOsmart.Items.AddRange(new object[] {
            "  "});
            this.CB_bancosOsmart.Location = new System.Drawing.Point(12, 124);
            this.CB_bancosOsmart.Name = "CB_bancosOsmart";
            this.CB_bancosOsmart.Size = new System.Drawing.Size(148, 21);
            this.CB_bancosOsmart.TabIndex = 40;
            this.CB_bancosOsmart.SelectedIndexChanged += new System.EventHandler(this.CB_bancosOsmart_SelectedIndexChanged);
            // 
            // frm_GastosExternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(665, 387);
            this.Controls.Add(this.CB_pagara);
            this.Controls.Add(this.TB_saldobanco);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CB_cuentasOsmart);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CB_bancosOsmart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.dtGastos);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.cbGastos);
            this.Controls.Add(this.cbTienda);
            this.Name = "frm_GastosExternos";
            this.Text = "frm_GastosExternos";
            this.Load += new System.EventHandler(this.frm_GastosExternos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTienda;
        private System.Windows.Forms.ComboBox cbGastos;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.DateTimePicker dtGastos;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_pagara;
        private System.Windows.Forms.TextBox TB_saldobanco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CB_cuentasOsmart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CB_bancosOsmart;
    }
}