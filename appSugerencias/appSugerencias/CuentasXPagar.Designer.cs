namespace appSugerencias
{
    partial class CuentasXPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.DG_datos = new System.Windows.Forms.DataGridView();
            this.IDPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO_CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.TB_filtro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(111, 104);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(1069, 28);
            this.CB_proveedor.TabIndex = 1;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            // 
            // DG_datos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DG_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_datos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPAGO,
            this.IDPROVEEDOR,
            this.FECHA_MOV,
            this.TIPO_DOC,
            this.REF,
            this.MOV,
            this.IMP,
            this.SALDO_CUENTA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_datos.EnableHeadersVisualStyles = false;
            this.DG_datos.Location = new System.Drawing.Point(20, 142);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.Size = new System.Drawing.Size(1164, 336);
            this.DG_datos.TabIndex = 2;
            this.DG_datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_datos_CellDoubleClick_1);
            // 
            // IDPAGO
            // 
            this.IDPAGO.HeaderText = "ID";
            this.IDPAGO.Name = "IDPAGO";
            // 
            // IDPROVEEDOR
            // 
            this.IDPROVEEDOR.HeaderText = "PROVEEDOR";
            this.IDPROVEEDOR.Name = "IDPROVEEDOR";
            // 
            // FECHA_MOV
            // 
            this.FECHA_MOV.HeaderText = "FECHA";
            this.FECHA_MOV.Name = "FECHA_MOV";
            // 
            // TIPO_DOC
            // 
            this.TIPO_DOC.HeaderText = "TIPO_DOC";
            this.TIPO_DOC.Name = "TIPO_DOC";
            // 
            // REF
            // 
            this.REF.HeaderText = "DESCRIPCION";
            this.REF.Name = "REF";
            // 
            // MOV
            // 
            this.MOV.HeaderText = "MOV";
            this.MOV.Name = "MOV";
            // 
            // IMP
            // 
            this.IMP.HeaderText = "IMPORTE";
            this.IMP.Name = "IMP";
            // 
            // SALDO_CUENTA
            // 
            this.SALDO_CUENTA.HeaderText = "SALDO";
            this.SALDO_CUENTA.Name = "SALDO_CUENTA";
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(1080, 78);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(100, 20);
            this.TB_proveedor.TabIndex = 3;
            // 
            // TB_filtro
            // 
            this.TB_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_filtro.Location = new System.Drawing.Point(111, 72);
            this.TB_filtro.Name = "TB_filtro";
            this.TB_filtro.Size = new System.Drawing.Size(265, 26);
            this.TB_filtro.TabIndex = 4;
            this.TB_filtro.TextChanged += new System.EventHandler(this.TB_filtro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // CB_sucursal
            // 
            this.CB_sucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "COLOSO",
            "RENA",
            "VALLARTA",
            "VELAZQUEZ"});
            this.CB_sucursal.Location = new System.Drawing.Point(111, 38);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(265, 28);
            this.CB_sucursal.TabIndex = 6;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sucursal";
            // 
            // CuentasXPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1196, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_filtro);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.DG_datos);
            this.Controls.Add(this.CB_proveedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CuentasXPagar";
            this.Text = "Cuentas Por Pagar";
            this.Load += new System.EventHandler(this.CuentasXPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.TextBox TB_filtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO_CUENTA;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label3;
    }
}