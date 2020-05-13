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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPT_SaldoProveedores));
            this.DG_reporte = new System.Windows.Forms.DataGridView();
            this.LB_estado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BT_saldos = new System.Windows.Forms.Button();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.CHK_saldo = new System.Windows.Forms.CheckBox();
            this.LB_bo = new System.Windows.Forms.Label();
            this.LB_va = new System.Windows.Forms.Label();
            this.LB_rena = new System.Windows.Forms.Label();
            this.LB_coloso = new System.Windows.Forms.Label();
            this.LB_velazquez = new System.Windows.Forms.Label();
            this.LB_pregot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_reporte
            // 
            this.DG_reporte.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DG_reporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_reporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_reporte.Location = new System.Drawing.Point(16, 50);
            this.DG_reporte.Name = "DG_reporte";
            this.DG_reporte.Size = new System.Drawing.Size(1212, 324);
            this.DG_reporte.TabIndex = 3;
            // 
            // LB_estado
            // 
            this.LB_estado.AutoSize = true;
            this.LB_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_estado.Location = new System.Drawing.Point(217, 16);
            this.LB_estado.Name = "LB_estado";
            this.LB_estado.Size = new System.Drawing.Size(0, 13);
            this.LB_estado.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1252, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_saldos
            // 
            this.BT_saldos.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_saldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_saldos.ForeColor = System.Drawing.Color.White;
            this.BT_saldos.Location = new System.Drawing.Point(1252, 50);
            this.BT_saldos.Name = "BT_saldos";
            this.BT_saldos.Size = new System.Drawing.Size(91, 63);
            this.BT_saldos.TabIndex = 10;
            this.BT_saldos.Text = "SALDOS";
            this.BT_saldos.UseVisualStyleBackColor = false;
            this.BT_saldos.Click += new System.EventHandler(this.BT_saldos_Click);
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(270, 380);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 11;
            this.DT_fecha.Visible = false;
            // 
            // CHK_saldo
            // 
            this.CHK_saldo.AutoSize = true;
            this.CHK_saldo.Location = new System.Drawing.Point(825, 16);
            this.CHK_saldo.Name = "CHK_saldo";
            this.CHK_saldo.Size = new System.Drawing.Size(135, 17);
            this.CHK_saldo.TabIndex = 12;
            this.CHK_saldo.Text = "Proveedores con saldo";
            this.CHK_saldo.UseVisualStyleBackColor = true;
            // 
            // LB_bo
            // 
            this.LB_bo.AutoSize = true;
            this.LB_bo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_bo.Location = new System.Drawing.Point(13, 15);
            this.LB_bo.Name = "LB_bo";
            this.LB_bo.Size = new System.Drawing.Size(58, 13);
            this.LB_bo.TabIndex = 13;
            this.LB_bo.Text = "BODEGA";
            // 
            // LB_va
            // 
            this.LB_va.AutoSize = true;
            this.LB_va.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_va.Location = new System.Drawing.Point(85, 15);
            this.LB_va.Name = "LB_va";
            this.LB_va.Size = new System.Drawing.Size(70, 13);
            this.LB_va.TabIndex = 14;
            this.LB_va.Text = "VALLARTA";
            // 
            // LB_rena
            // 
            this.LB_rena.AutoSize = true;
            this.LB_rena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_rena.Location = new System.Drawing.Point(168, 15);
            this.LB_rena.Name = "LB_rena";
            this.LB_rena.Size = new System.Drawing.Size(41, 13);
            this.LB_rena.TabIndex = 15;
            this.LB_rena.Text = "RENA";
            // 
            // LB_coloso
            // 
            this.LB_coloso.AutoSize = true;
            this.LB_coloso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_coloso.Location = new System.Drawing.Point(235, 15);
            this.LB_coloso.Name = "LB_coloso";
            this.LB_coloso.Size = new System.Drawing.Size(57, 13);
            this.LB_coloso.TabIndex = 16;
            this.LB_coloso.Text = "COLOSO";
            // 
            // LB_velazquez
            // 
            this.LB_velazquez.AutoSize = true;
            this.LB_velazquez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_velazquez.Location = new System.Drawing.Point(316, 15);
            this.LB_velazquez.Name = "LB_velazquez";
            this.LB_velazquez.Size = new System.Drawing.Size(80, 13);
            this.LB_velazquez.TabIndex = 17;
            this.LB_velazquez.Text = "VELAZQUEZ";
            // 
            // LB_pregot
            // 
            this.LB_pregot.AutoSize = true;
            this.LB_pregot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pregot.Location = new System.Drawing.Point(412, 15);
            this.LB_pregot.Name = "LB_pregot";
            this.LB_pregot.Size = new System.Drawing.Size(58, 13);
            this.LB_pregot.TabIndex = 18;
            this.LB_pregot.Text = "PREGOT";
            // 
            // RPT_SaldoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1354, 403);
            this.Controls.Add(this.LB_pregot);
            this.Controls.Add(this.LB_velazquez);
            this.Controls.Add(this.LB_coloso);
            this.Controls.Add(this.LB_rena);
            this.Controls.Add(this.LB_va);
            this.Controls.Add(this.LB_bo);
            this.Controls.Add(this.CHK_saldo);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.BT_saldos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LB_estado);
            this.Controls.Add(this.DG_reporte);
            this.Name = "RPT_SaldoProveedores";
            this.Text = "Resumen de Saldos";
            this.Load += new System.EventHandler(this.RPT_SaldoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_reporte;
        private System.Windows.Forms.Label LB_estado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_saldos;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.CheckBox CHK_saldo;
        private System.Windows.Forms.Label LB_bo;
        private System.Windows.Forms.Label LB_va;
        private System.Windows.Forms.Label LB_rena;
        private System.Windows.Forms.Label LB_coloso;
        private System.Windows.Forms.Label LB_velazquez;
        private System.Windows.Forms.Label LB_pregot;
    }
}