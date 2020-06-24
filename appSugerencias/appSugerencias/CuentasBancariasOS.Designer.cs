namespace appSugerencias
{
    partial class CuentasBancariasOS
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
            this.CB_banco = new System.Windows.Forms.ComboBox();
            this.CB_tienda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_cuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_cliente = new System.Windows.Forms.TextBox();
            this.BT_registrar = new System.Windows.Forms.Button();
            this.DG_cuentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.TB_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANCO";
            // 
            // CB_banco
            // 
            this.CB_banco.FormattingEnabled = true;
            this.CB_banco.Items.AddRange(new object[] {
            "  ",
            "BANAMEX",
            "BANCOMER",
            "BANORTE",
            "BANBAJIO",
            "INBURSA",
            "SALDAZO/OXXO",
            "SANTANDER",
            "SCOTIABANK",
            "BANCO AZTECA",
            "LIVERPOOL (BANAMEX)",
            "CAJA GENERAL"});
            this.CB_banco.Location = new System.Drawing.Point(222, 12);
            this.CB_banco.Name = "CB_banco";
            this.CB_banco.Size = new System.Drawing.Size(182, 21);
            this.CB_banco.TabIndex = 1;
            // 
            // CB_tienda
            // 
            this.CB_tienda.FormattingEnabled = true;
            this.CB_tienda.Items.AddRange(new object[] {
            "  ",
            "BODEGA",
            "VALLARTA",
            "RENA",
            "COLOSO",
            "VELAZQUEZ",
            "PREGOT"});
            this.CB_tienda.Location = new System.Drawing.Point(51, 12);
            this.CB_tienda.Name = "CB_tienda";
            this.CB_tienda.Size = new System.Drawing.Size(108, 21);
            this.CB_tienda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIENDA";
            // 
            // TB_cuenta
            // 
            this.TB_cuenta.Location = new System.Drawing.Point(470, 13);
            this.TB_cuenta.Name = "TB_cuenta";
            this.TB_cuenta.Size = new System.Drawing.Size(182, 20);
            this.TB_cuenta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CUENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A NOMBRE DE";
            // 
            // TB_cliente
            // 
            this.TB_cliente.Location = new System.Drawing.Point(87, 48);
            this.TB_cliente.Name = "TB_cliente";
            this.TB_cliente.Size = new System.Drawing.Size(317, 20);
            this.TB_cliente.TabIndex = 6;
            // 
            // BT_registrar
            // 
            this.BT_registrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_registrar.ForeColor = System.Drawing.Color.White;
            this.BT_registrar.Location = new System.Drawing.Point(725, 51);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(80, 42);
            this.BT_registrar.TabIndex = 8;
            this.BT_registrar.Text = "Registrar";
            this.BT_registrar.UseVisualStyleBackColor = false;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // DG_cuentas
            // 
            this.DG_cuentas.AllowUserToAddRows = false;
            this.DG_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CLIENTE,
            this.TIENDA,
            this.BANCO,
            this.CUENTA});
            this.DG_cuentas.Location = new System.Drawing.Point(12, 96);
            this.DG_cuentas.Name = "DG_cuentas";
            this.DG_cuentas.Size = new System.Drawing.Size(793, 150);
            this.DG_cuentas.TabIndex = 9;
            this.DG_cuentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_cuentas_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.Name = "TIENDA";
            // 
            // BANCO
            // 
            this.BANCO.HeaderText = "BANCO";
            this.BANCO.Name = "BANCO";
            // 
            // CUENTA
            // 
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(523, 252);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(80, 42);
            this.BT_buscar.TabIndex = 10;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(623, 252);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(80, 42);
            this.BT_modificar.TabIndex = 11;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_limpiar.ForeColor = System.Drawing.Color.White;
            this.BT_limpiar.Location = new System.Drawing.Point(725, 252);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(80, 42);
            this.BT_limpiar.TabIndex = 12;
            this.BT_limpiar.Text = "Limpiar";
            this.BT_limpiar.UseVisualStyleBackColor = false;
            this.BT_limpiar.Click += new System.EventHandler(this.BT_limpiar_Click);
            // 
            // TB_id
            // 
            this.TB_id.Location = new System.Drawing.Point(12, 252);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(41, 20);
            this.TB_id.TabIndex = 13;
            this.TB_id.Visible = false;
            // 
            // CuentasBancariasOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(815, 298);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.BT_limpiar);
            this.Controls.Add(this.BT_modificar);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.DG_cuentas);
            this.Controls.Add(this.BT_registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_cuenta);
            this.Controls.Add(this.CB_tienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_banco);
            this.Controls.Add(this.label1);
            this.Name = "CuentasBancariasOS";
            this.Text = "CuentasBancariasOS";
            this.Load += new System.EventHandler(this.CuentasBancariasOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_banco;
        private System.Windows.Forms.ComboBox CB_tienda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_cliente;
        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.DataGridView DG_cuentas;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Button BT_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.TextBox TB_id;
    }
}