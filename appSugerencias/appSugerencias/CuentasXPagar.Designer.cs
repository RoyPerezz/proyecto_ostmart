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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentasXPagar));
            this.CB_proveedor = new System.Windows.Forms.ComboBox();
            this.DG_datos = new System.Windows.Forms.DataGridView();
            this.IDMOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALDO_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.LB_bo = new System.Windows.Forms.Label();
            this.LB_va = new System.Windows.Forms.Label();
            this.LB_re = new System.Windows.Forms.Label();
            this.LB_co = new System.Windows.Forms.Label();
            this.LB_ve = new System.Windows.Forms.Label();
            this.LB_pre = new System.Windows.Forms.Label();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.TB_filtro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PN_conexiones = new System.Windows.Forms.Panel();
            this.IDPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_abonos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.PN_conexiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_proveedor
            // 
            this.CB_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_proveedor.FormattingEnabled = true;
            this.CB_proveedor.Location = new System.Drawing.Point(355, 97);
            this.CB_proveedor.Name = "CB_proveedor";
            this.CB_proveedor.Size = new System.Drawing.Size(996, 33);
            this.CB_proveedor.TabIndex = 1;
            this.CB_proveedor.SelectedIndexChanged += new System.EventHandler(this.CB_proveedor_SelectedIndexChanged);
            // 
            // DG_datos
            // 
            this.DG_datos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DG_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_datos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMOV,
            this.PROV,
            this.FECHA_,
            this.TIPO_DOCUMENTO,
            this.REFERENCIA,
            this.MOVIMIENTO,
            this.SUCURSAL,
            this.COMPRA,
            this.PAGO,
            this.SALDO_});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_datos.DefaultCellStyle = dataGridViewCellStyle6;
            this.DG_datos.EnableHeadersVisualStyles = false;
            this.DG_datos.Location = new System.Drawing.Point(2, 140);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.Size = new System.Drawing.Size(1680, 437);
            this.DG_datos.TabIndex = 2;
            this.DG_datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_datos_CellDoubleClick);
            // 
            // IDMOV
            // 
            this.IDMOV.HeaderText = "COMPRA";
            this.IDMOV.Name = "IDMOV";
            // 
            // PROV
            // 
            this.PROV.HeaderText = "PROVEEDOR";
            this.PROV.Name = "PROV";
            // 
            // FECHA_
            // 
            this.FECHA_.HeaderText = "FECHA";
            this.FECHA_.Name = "FECHA_";
            // 
            // TIPO_DOCUMENTO
            // 
            this.TIPO_DOCUMENTO.HeaderText = "TIPO_DOC";
            this.TIPO_DOCUMENTO.Name = "TIPO_DOCUMENTO";
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            // 
            // MOVIMIENTO
            // 
            this.MOVIMIENTO.HeaderText = "MOV";
            this.MOVIMIENTO.Name = "MOVIMIENTO";
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            // 
            // COMPRA
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.COMPRA.DefaultCellStyle = dataGridViewCellStyle3;
            this.COMPRA.HeaderText = "CARGO/COMPRA";
            this.COMPRA.Name = "COMPRA";
            this.COMPRA.Width = 300;
            // 
            // PAGO
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PAGO.DefaultCellStyle = dataGridViewCellStyle4;
            this.PAGO.HeaderText = "ABONO/PAGO";
            this.PAGO.Name = "PAGO";
            this.PAGO.Width = 200;
            // 
            // SALDO_
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SALDO_.DefaultCellStyle = dataGridViewCellStyle5;
            this.SALDO_.HeaderText = "SALDO";
            this.SALDO_.Name = "SALDO_";
            this.SALDO_.Width = 200;
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_proveedor.Location = new System.Drawing.Point(20, 18);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(100, 31);
            this.TB_proveedor.TabIndex = 3;
            this.TB_proveedor.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(350, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "PROVEEDOR";
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
            // BT_guardar
            // 
            this.BT_guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Image = ((System.Drawing.Image)(resources.GetObject("BT_guardar.Image")));
            this.BT_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_guardar.Location = new System.Drawing.Point(1480, 94);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(103, 36);
            this.BT_guardar.TabIndex = 9;
            this.BT_guardar.Text = "Exportar";
            this.BT_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // LB_bo
            // 
            this.LB_bo.AutoSize = true;
            this.LB_bo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_bo.ForeColor = System.Drawing.Color.Gray;
            this.LB_bo.Location = new System.Drawing.Point(8, 22);
            this.LB_bo.Name = "LB_bo";
            this.LB_bo.Size = new System.Drawing.Size(58, 13);
            this.LB_bo.TabIndex = 10;
            this.LB_bo.Text = "BODEGA";
            // 
            // LB_va
            // 
            this.LB_va.AutoSize = true;
            this.LB_va.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_va.ForeColor = System.Drawing.Color.Gray;
            this.LB_va.Location = new System.Drawing.Point(111, 22);
            this.LB_va.Name = "LB_va";
            this.LB_va.Size = new System.Drawing.Size(70, 13);
            this.LB_va.TabIndex = 11;
            this.LB_va.Text = "VALLARTA";
            // 
            // LB_re
            // 
            this.LB_re.AutoSize = true;
            this.LB_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_re.ForeColor = System.Drawing.Color.Gray;
            this.LB_re.Location = new System.Drawing.Point(223, 22);
            this.LB_re.Name = "LB_re";
            this.LB_re.Size = new System.Drawing.Size(41, 13);
            this.LB_re.TabIndex = 12;
            this.LB_re.Text = "RENA";
            // 
            // LB_co
            // 
            this.LB_co.AutoSize = true;
            this.LB_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_co.ForeColor = System.Drawing.Color.Gray;
            this.LB_co.Location = new System.Drawing.Point(319, 22);
            this.LB_co.Name = "LB_co";
            this.LB_co.Size = new System.Drawing.Size(57, 13);
            this.LB_co.TabIndex = 13;
            this.LB_co.Text = "COLOSO";
            // 
            // LB_ve
            // 
            this.LB_ve.AutoSize = true;
            this.LB_ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ve.ForeColor = System.Drawing.Color.Gray;
            this.LB_ve.Location = new System.Drawing.Point(420, 22);
            this.LB_ve.Name = "LB_ve";
            this.LB_ve.Size = new System.Drawing.Size(80, 13);
            this.LB_ve.TabIndex = 14;
            this.LB_ve.Text = "VELAZQUEZ";
            // 
            // LB_pre
            // 
            this.LB_pre.AutoSize = true;
            this.LB_pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pre.ForeColor = System.Drawing.Color.Gray;
            this.LB_pre.Location = new System.Drawing.Point(531, 22);
            this.LB_pre.Name = "LB_pre";
            this.LB_pre.Size = new System.Drawing.Size(58, 13);
            this.LB_pre.TabIndex = 15;
            this.LB_pre.Text = "PREGOT";
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_Buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Buscar.ForeColor = System.Drawing.Color.White;
            this.BT_Buscar.Location = new System.Drawing.Point(1383, 94);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(85, 36);
            this.BT_Buscar.TabIndex = 22;
            this.BT_Buscar.Text = "Buscar";
            this.BT_Buscar.UseVisualStyleBackColor = false;
            this.BT_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_filtro
            // 
            this.TB_filtro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TB_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_filtro.Location = new System.Drawing.Point(20, 97);
            this.TB_filtro.Name = "TB_filtro";
            this.TB_filtro.Size = new System.Drawing.Size(329, 31);
            this.TB_filtro.TabIndex = 24;
            this.TB_filtro.TextChanged += new System.EventHandler(this.TB_filtro_TextChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "FILTRO";
            // 
            // PN_conexiones
            // 
            this.PN_conexiones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PN_conexiones.BackColor = System.Drawing.Color.White;
            this.PN_conexiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_conexiones.Controls.Add(this.LB_pre);
            this.PN_conexiones.Controls.Add(this.LB_bo);
            this.PN_conexiones.Controls.Add(this.LB_va);
            this.PN_conexiones.Controls.Add(this.LB_re);
            this.PN_conexiones.Controls.Add(this.LB_co);
            this.PN_conexiones.Controls.Add(this.LB_ve);
            this.PN_conexiones.Location = new System.Drawing.Point(1081, 18);
            this.PN_conexiones.Name = "PN_conexiones";
            this.PN_conexiones.Size = new System.Drawing.Size(601, 57);
            this.PN_conexiones.TabIndex = 26;
            // 
            // IDPAGO
            // 
            this.IDPAGO.HeaderText = "ID";
            this.IDPAGO.Name = "IDPAGO";
            // 
            // IDPROVEEDOR
            // 
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
            // BT_abonos
            // 
            this.BT_abonos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BT_abonos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_abonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_abonos.ForeColor = System.Drawing.Color.White;
            this.BT_abonos.Location = new System.Drawing.Point(1597, 94);
            this.BT_abonos.Name = "BT_abonos";
            this.BT_abonos.Size = new System.Drawing.Size(85, 36);
            this.BT_abonos.TabIndex = 27;
            this.BT_abonos.Text = "Abonos";
            this.BT_abonos.UseVisualStyleBackColor = false;
            this.BT_abonos.Click += new System.EventHandler(this.BT_abonos_Click);
            // 
            // CuentasXPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1686, 589);
            this.Controls.Add(this.BT_abonos);
            this.Controls.Add(this.PN_conexiones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_filtro);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.DG_datos);
            this.Controls.Add(this.CB_proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CuentasXPagar";
            this.Text = "Cuentas Por Pagar";
            this.Load += new System.EventHandler(this.CuentasXPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.PN_conexiones.ResumeLayout(false);
            this.PN_conexiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_proveedor;
        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Label LB_bo;
        private System.Windows.Forms.Label LB_va;
        private System.Windows.Forms.Label LB_re;
        private System.Windows.Forms.Label LB_co;
        private System.Windows.Forms.Label LB_ve;
        private System.Windows.Forms.Label LB_pre;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.TextBox TB_filtro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PN_conexiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_MOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOV;
        private System.Windows.Forms.Button BT_abonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOVIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALDO_;
    }
}