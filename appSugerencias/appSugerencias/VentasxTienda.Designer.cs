namespace appSugerencias
{
    partial class VentasxTienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasxTienda));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALLARTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VELAZQUEZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREGOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.VALLARTA,
            this.RENA,
            this.VELAZQUEZ,
            this.COLOSO,
            this.PREGOT,
            this.TOTAL_DIA});
            this.dgvVentas.Location = new System.Drawing.Point(29, 95);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(749, 683);
            this.dgvVentas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de ventas de las sucursales";
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Image = ((System.Drawing.Image)(resources.GetObject("BT_exportar.Image")));
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_exportar.Location = new System.Drawing.Point(519, 23);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(112, 51);
            this.BT_exportar.TabIndex = 4;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // FECHA
            // 
            this.FECHA.Frozen = true;
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // VALLARTA
            // 
            this.VALLARTA.Frozen = true;
            this.VALLARTA.HeaderText = "Vallarta";
            this.VALLARTA.Name = "VALLARTA";
            this.VALLARTA.ReadOnly = true;
            // 
            // RENA
            // 
            this.RENA.Frozen = true;
            this.RENA.HeaderText = "Rena";
            this.RENA.Name = "RENA";
            // 
            // VELAZQUEZ
            // 
            this.VELAZQUEZ.HeaderText = "Velazquez";
            this.VELAZQUEZ.Name = "VELAZQUEZ";
            this.VELAZQUEZ.ReadOnly = true;
            // 
            // COLOSO
            // 
            this.COLOSO.HeaderText = "Coloso";
            this.COLOSO.Name = "COLOSO";
            this.COLOSO.ReadOnly = true;
            // 
            // PREGOT
            // 
            this.PREGOT.HeaderText = "Pregot";
            this.PREGOT.Name = "PREGOT";
            // 
            // TOTAL_DIA
            // 
            this.TOTAL_DIA.HeaderText = "Total del Dia";
            this.TOTAL_DIA.Name = "TOTAL_DIA";
            // 
            // VentasxTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 846);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVentas);
            this.Name = "VentasxTienda";
            this.Text = "VentasxTienda";
            this.Load += new System.EventHandler(this.VentasxTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALLARTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VELAZQUEZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREGOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_DIA;
    }
}