namespace appSugerencias
{
    partial class ExistenciaXProveedor
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
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_vallarta = new System.Windows.Forms.DataGridView();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_sucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_status = new System.Windows.Forms.Label();
            this.DG_rena = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_coloso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_velazquez = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_bodega = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_vallarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_rena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_coloso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_velazquez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_bodega)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.ItemHeight = 13;
            this.CB_proveedores.Location = new System.Drawing.Point(120, 39);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(415, 21);
            this.CB_proveedores.TabIndex = 0;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // DG_vallarta
            // 
            this.DG_vallarta.AllowUserToAddRows = false;
            this.DG_vallarta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_vallarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_vallarta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARTICULO,
            this.DESCRIPCION,
            this.VALLARTA});
            this.DG_vallarta.EnableHeadersVisualStyles = false;
            this.DG_vallarta.Location = new System.Drawing.Point(53, 112);
            this.DG_vallarta.Name = "DG_vallarta";
            this.DG_vallarta.Size = new System.Drawing.Size(471, 281);
            this.DG_vallarta.TabIndex = 2;
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // VALLARTA
            // 
            this.VALLARTA.HeaderText = "VALLARTA";
            this.VALLARTA.Name = "VALLARTA";
            // 
            // CB_sucursal
            // 
            this.CB_sucursal.FormattingEnabled = true;
            this.CB_sucursal.ItemHeight = 13;
            this.CB_sucursal.Items.AddRange(new object[] {
            "BODEGA",
            "COLOSO",
            "RENA",
            "VALLARTA",
            "VELAZQUEZ"});
            this.CB_sucursal.Location = new System.Drawing.Point(120, 11);
            this.CB_sucursal.Name = "CB_sucursal";
            this.CB_sucursal.Size = new System.Drawing.Size(415, 21);
            this.CB_sucursal.TabIndex = 3;
            this.CB_sucursal.SelectedIndexChanged += new System.EventHandler(this.CB_sucursal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sucursal";
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(808, 40);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(132, 20);
            this.TB_proveedor.TabIndex = 5;
            this.TB_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(805, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código Proveedor";
            // 
            // LB_status
            // 
            this.LB_status.AutoSize = true;
            this.LB_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_status.Location = new System.Drawing.Point(592, 32);
            this.LB_status.Name = "LB_status";
            this.LB_status.Size = new System.Drawing.Size(0, 16);
            this.LB_status.TabIndex = 7;
            // 
            // DG_rena
            // 
            this.DG_rena.AllowUserToAddRows = false;
            this.DG_rena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_rena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_rena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.RENA});
            this.DG_rena.EnableHeadersVisualStyles = false;
            this.DG_rena.Location = new System.Drawing.Point(536, 112);
            this.DG_rena.Name = "DG_rena";
            this.DG_rena.Size = new System.Drawing.Size(471, 281);
            this.DG_rena.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ARTICULO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // RENA
            // 
            this.RENA.HeaderText = "RENA";
            this.RENA.Name = "RENA";
            this.RENA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DG_coloso
            // 
            this.DG_coloso.AllowUserToAddRows = false;
            this.DG_coloso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_coloso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_coloso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.COLOSO});
            this.DG_coloso.EnableHeadersVisualStyles = false;
            this.DG_coloso.Location = new System.Drawing.Point(1018, 112);
            this.DG_coloso.Name = "DG_coloso";
            this.DG_coloso.Size = new System.Drawing.Size(471, 281);
            this.DG_coloso.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ARTICULO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // COLOSO
            // 
            this.COLOSO.HeaderText = "COLOSO";
            this.COLOSO.Name = "COLOSO";
            this.COLOSO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DG_velazquez
            // 
            this.DG_velazquez.AllowUserToAddRows = false;
            this.DG_velazquez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_velazquez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_velazquez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.VELAZQUEZ});
            this.DG_velazquez.EnableHeadersVisualStyles = false;
            this.DG_velazquez.Location = new System.Drawing.Point(276, 445);
            this.DG_velazquez.Name = "DG_velazquez";
            this.DG_velazquez.Size = new System.Drawing.Size(471, 281);
            this.DG_velazquez.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ARTICULO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // VELAZQUEZ
            // 
            this.VELAZQUEZ.HeaderText = "VELAZQUEZ";
            this.VELAZQUEZ.Name = "VELAZQUEZ";
            this.VELAZQUEZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DG_bodega
            // 
            this.DG_bodega.AllowUserToAddRows = false;
            this.DG_bodega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_bodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_bodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.BOD});
            this.DG_bodega.EnableHeadersVisualStyles = false;
            this.DG_bodega.Location = new System.Drawing.Point(760, 445);
            this.DG_bodega.Name = "DG_bodega";
            this.DG_bodega.Size = new System.Drawing.Size(471, 281);
            this.DG_bodega.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ARTICULO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // BOD
            // 
            this.BOD.HeaderText = "BODEGA";
            this.BOD.Name = "BOD";
            this.BOD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BT_exportar
            // 
            this.BT_exportar.Location = new System.Drawing.Point(693, 744);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(110, 45);
            this.BT_exportar.TabIndex = 12;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = true;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // ExistenciaXProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1532, 790);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.DG_bodega);
            this.Controls.Add(this.DG_velazquez);
            this.Controls.Add(this.DG_coloso);
            this.Controls.Add(this.DG_rena);
            this.Controls.Add(this.LB_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_sucursal);
            this.Controls.Add(this.DG_vallarta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExistenciaXProveedor";
            this.Text = "Productos por Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExistenciaXProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_vallarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_rena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_coloso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_velazquez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_bodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_vallarta;
        private System.Windows.Forms.ComboBox CB_sucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALLARTA;
        private System.Windows.Forms.DataGridView DG_rena;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENA;
        private System.Windows.Forms.DataGridView DG_coloso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOSO;
        private System.Windows.Forms.DataGridView DG_velazquez;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn VELAZQUEZ;
        private System.Windows.Forms.DataGridView DG_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOD;
        private System.Windows.Forms.Button BT_exportar;
    }
}