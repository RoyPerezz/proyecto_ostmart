namespace appSugerencias
{
    partial class Rep_pagoproveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_reporte = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_disponible = new System.Windows.Forms.TextBox();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_reporte
            // 
            this.DG_reporte.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_reporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_reporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DG_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROVEEDOR,
            this.PAGARA,
            this.MONTO,
            this.BANCO,
            this.CUENTA,
            this.FECHA,
            this.TIENDA,
            this.COMPRA});
            this.DG_reporte.Location = new System.Drawing.Point(12, 80);
            this.DG_reporte.Name = "DG_reporte";
            this.DG_reporte.Size = new System.Drawing.Size(1272, 287);
            this.DG_reporte.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(74, 13);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(74, 45);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1069, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Efectivo Disponible";
            // 
            // TB_disponible
            // 
            this.TB_disponible.Location = new System.Drawing.Point(1173, 45);
            this.TB_disponible.Name = "TB_disponible";
            this.TB_disponible.Size = new System.Drawing.Size(109, 20);
            this.TB_disponible.TabIndex = 7;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            // 
            // PAGARA
            // 
            this.PAGARA.HeaderText = "DEPOSITAR A";
            this.PAGARA.Name = "PAGARA";
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
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
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // TIENDA
            // 
            this.TIENDA.HeaderText = "TIENDA";
            this.TIENDA.Name = "TIENDA";
            // 
            // COMPRA
            // 
            this.COMPRA.HeaderText = "COMPRA";
            this.COMPRA.Name = "COMPRA";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(1084, 10);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(945, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Efectivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exportar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rep_pagoproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 379);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.TB_disponible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG_reporte);
            this.Name = "Rep_pagoproveedores";
            this.Text = "Rep_pagoproveedores";
            this.Load += new System.EventHandler(this.Rep_pagoproveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_reporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPRA;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}