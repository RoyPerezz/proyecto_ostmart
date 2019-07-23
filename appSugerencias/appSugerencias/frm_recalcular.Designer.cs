namespace appSugerencias
{
    partial class frm_recalcular
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
            this.CBTienda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGArticulos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TBArchivo = new System.Windows.Forms.TextBox();
            this.LBConexion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // CBTienda
            // 
            this.CBTienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTienda.FormattingEnabled = true;
            this.CBTienda.Items.AddRange(new object[] {
            "BODEGA",
            "VALLARTA",
            "RENA",
            "VELAZQUEZ",
            "COLOSO"});
            this.CBTienda.Location = new System.Drawing.Point(82, 83);
            this.CBTienda.Margin = new System.Windows.Forms.Padding(2);
            this.CBTienda.Name = "CBTienda";
            this.CBTienda.Size = new System.Drawing.Size(239, 21);
            this.CBTienda.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tienda";
            // 
            // DGArticulos
            // 
            this.DGArticulos.AllowUserToAddRows = false;
            this.DGArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGArticulos.Location = new System.Drawing.Point(30, 196);
            this.DGArticulos.Name = "DGArticulos";
            this.DGArticulos.Size = new System.Drawing.Size(362, 502);
            this.DGArticulos.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBArchivo
            // 
            this.TBArchivo.Location = new System.Drawing.Point(153, 143);
            this.TBArchivo.Name = "TBArchivo";
            this.TBArchivo.Size = new System.Drawing.Size(239, 20);
            this.TBArchivo.TabIndex = 26;
            // 
            // LBConexion
            // 
            this.LBConexion.AutoSize = true;
            this.LBConexion.Location = new System.Drawing.Point(346, 88);
            this.LBConexion.Name = "LBConexion";
            this.LBConexion.Size = new System.Drawing.Size(0, 13);
            this.LBConexion.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 721);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_recalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 766);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LBConexion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBArchivo);
            this.Controls.Add(this.DGArticulos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBTienda);
            this.Name = "frm_recalcular";
            this.Text = "frm_recalcular";
            this.Load += new System.EventHandler(this.frm_recalcular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGArticulos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBArchivo;
        private System.Windows.Forms.Label LBConexion;
        private System.Windows.Forms.Button button2;
    }
}