namespace appSugerencias
{
    partial class CuentasBancarias
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_cuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.DG_cuentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA_BANCARIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_filtro = new System.Windows.Forms.TextBox();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDOR";
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(108, 41);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(329, 21);
            this.CB_proveedor.TabIndex = 1;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(449, 42);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(85, 20);
            this.TB_proveedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BANCO";
            // 
            // TB_cuenta
            // 
            this.TB_cuenta.Location = new System.Drawing.Point(108, 98);
            this.TB_cuenta.Name = "TB_cuenta";
            this.TB_cuenta.Size = new System.Drawing.Size(426, 20);
            this.TB_cuenta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUM. CUENTA";
            // 
            // BT_buscar
            // 
            this.BT_buscar.Location = new System.Drawing.Point(190, 366);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(106, 35);
            this.BT_buscar.TabIndex = 19;
            this.BT_buscar.Text = "BUSCAR";
            this.BT_buscar.UseVisualStyleBackColor = true;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_guardar
            // 
            this.BT_guardar.Location = new System.Drawing.Point(310, 366);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(106, 35);
            this.BT_guardar.TabIndex = 20;
            this.BT_guardar.Text = "GUARDAR";
            this.BT_guardar.UseVisualStyleBackColor = true;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // DG_cuentas
            // 
            this.DG_cuentas.AllowUserToAddRows = false;
            this.DG_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PROVEEDOR,
            this.BANCO,
            this.CUENTA_BANCARIA});
            this.DG_cuentas.Location = new System.Drawing.Point(22, 186);
            this.DG_cuentas.Name = "DG_cuentas";
            this.DG_cuentas.Size = new System.Drawing.Size(512, 174);
            this.DG_cuentas.TabIndex = 21;
            this.DG_cuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_cuentas_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // CUENTA_BANCARIA
            // 
            this.CUENTA_BANCARIA.HeaderText = "CUENTA BANCARIA";
            this.CUENTA_BANCARIA.Name = "CUENTA_BANCARIA";
            // 
            // BT_agregar
            // 
            this.BT_agregar.Location = new System.Drawing.Point(242, 134);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(120, 46);
            this.BT_agregar.TabIndex = 22;
            this.BT_agregar.Text = "AGREGAR";
            this.BT_agregar.UseVisualStyleBackColor = true;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Items.AddRange(new object[] {
            "  ",
            "BANAMEX",
            "BANBAJIO",
            "BANCOMER",
            "BANORTE",
            "BANCOPPEL",
            "HSBC",
            "INBURSA",
            "LIVERPOOL",
            "SALDAZO/OXXO",
            "SANTANDER",
            "SCOTIANBANK"});
            this.CB_banco.Location = new System.Drawing.Point(108, 71);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(426, 21);
            this.CB_banco.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "FILTRO";
            // 
            // TB_filtro
            // 
            this.TB_filtro.Location = new System.Drawing.Point(108, 15);
            this.TB_filtro.Name = "TB_filtro";
            this.TB_filtro.Size = new System.Drawing.Size(426, 20);
            this.TB_filtro.TabIndex = 25;
            this.TB_filtro.TextChanged += new System.EventHandler(this.TB_filtro_TextChanged);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(23, 366);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(85, 20);
            this.TB_id.TabIndex = 26;
            this.TB_id.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "REGISTRAR PERSONAS A PAGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(561, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.TB_filtro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_banco);
            this.Controls.Add(this.BT_agregar);
            this.Controls.Add(this.DG_cuentas);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.TB_cuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.CB_proveedor);
            this.Controls.Add(this.label1);
            this.Name = "CuentasBancarias";
            this.Text = "CuentasBancarias";
            this.Load += new System.EventHandler(this.CuentasBancarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.DataGridView DG_cuentas;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_filtro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA_BANCARIA;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}