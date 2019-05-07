namespace appSugerencias
{
    partial class frm_Compras
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
            this.Factura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFactura = new System.Windows.Forms.TextBox();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.CBFabricante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBTienda = new System.Windows.Forms.ComboBox();
            this.LBConexion = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TBArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DGCompra = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVaId = new System.Windows.Forms.Label();
            this.lblBoImpor = new System.Windows.Forms.Label();
            this.lblBoId = new System.Windows.Forms.Label();
            this.lblVaImpor = new System.Windows.Forms.Label();
            this.lblReId = new System.Windows.Forms.Label();
            this.lblReImpor = new System.Windows.Forms.Label();
            this.lblCoId = new System.Windows.Forms.Label();
            this.lblCoImpor = new System.Windows.Forms.Label();
            this.lblVeId = new System.Windows.Forms.Label();
            this.lblVeImpor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // Factura
            // 
            this.Factura.AutoSize = true;
            this.Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factura.Location = new System.Drawing.Point(18, 106);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(60, 16);
            this.Factura.TabIndex = 1;
            this.Factura.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Observaciones";
            // 
            // tbFactura
            // 
            this.tbFactura.Location = new System.Drawing.Point(147, 104);
            this.tbFactura.Name = "tbFactura";
            this.tbFactura.Size = new System.Drawing.Size(239, 20);
            this.tbFactura.TabIndex = 4;
            // 
            // tbDescuento
            // 
            this.tbDescuento.Location = new System.Drawing.Point(147, 144);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(239, 20);
            this.tbDescuento.TabIndex = 5;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(147, 179);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(239, 59);
            this.tbObservaciones.TabIndex = 6;
            // 
            // CBFabricante
            // 
            this.CBFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFabricante.FormattingEnabled = true;
            this.CBFabricante.Location = new System.Drawing.Point(147, 63);
            this.CBFabricante.Margin = new System.Windows.Forms.Padding(2);
            this.CBFabricante.Name = "CBFabricante";
            this.CBFabricante.Size = new System.Drawing.Size(239, 21);
            this.CBFabricante.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tienda";
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
            this.CBTienda.Location = new System.Drawing.Point(147, 24);
            this.CBTienda.Margin = new System.Windows.Forms.Padding(2);
            this.CBTienda.Name = "CBTienda";
            this.CBTienda.Size = new System.Drawing.Size(239, 21);
            this.CBTienda.TabIndex = 20;
            this.CBTienda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LBConexion
            // 
            this.LBConexion.AutoSize = true;
            this.LBConexion.Location = new System.Drawing.Point(421, 29);
            this.LBConexion.Name = "LBConexion";
            this.LBConexion.Size = new System.Drawing.Size(51, 13);
            this.LBConexion.TabIndex = 21;
            this.LBConexion.Text = "Conexion";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TBArchivo
            // 
            this.TBArchivo.Location = new System.Drawing.Point(147, 266);
            this.TBArchivo.Name = "TBArchivo";
            this.TBArchivo.Size = new System.Drawing.Size(239, 20);
            this.TBArchivo.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGCompra
            // 
            this.DGCompra.AllowUserToAddRows = false;
            this.DGCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCompra.Location = new System.Drawing.Point(21, 328);
            this.DGCompra.Name = "DGCompra";
            this.DGCompra.Size = new System.Drawing.Size(976, 336);
            this.DGCompra.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cargar Compra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 26;
            this.button3.Text = "Aprietame DaN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "VALLARTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "RENA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "COLOSO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "VELAZQUEZ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "BODEGA";
            // 
            // lblVaId
            // 
            this.lblVaId.AutoSize = true;
            this.lblVaId.Location = new System.Drawing.Point(796, 90);
            this.lblVaId.Name = "lblVaId";
            this.lblVaId.Size = new System.Drawing.Size(22, 13);
            this.lblVaId.TabIndex = 32;
            this.lblVaId.Text = "-----";
            // 
            // lblBoImpor
            // 
            this.lblBoImpor.AutoSize = true;
            this.lblBoImpor.Location = new System.Drawing.Point(866, 51);
            this.lblBoImpor.Name = "lblBoImpor";
            this.lblBoImpor.Size = new System.Drawing.Size(22, 13);
            this.lblBoImpor.TabIndex = 33;
            this.lblBoImpor.Text = "-----";
            // 
            // lblBoId
            // 
            this.lblBoId.AutoSize = true;
            this.lblBoId.Location = new System.Drawing.Point(796, 51);
            this.lblBoId.Name = "lblBoId";
            this.lblBoId.Size = new System.Drawing.Size(22, 13);
            this.lblBoId.TabIndex = 34;
            this.lblBoId.Text = "-----";
            // 
            // lblVaImpor
            // 
            this.lblVaImpor.AutoSize = true;
            this.lblVaImpor.Location = new System.Drawing.Point(866, 90);
            this.lblVaImpor.Name = "lblVaImpor";
            this.lblVaImpor.Size = new System.Drawing.Size(22, 13);
            this.lblVaImpor.TabIndex = 35;
            this.lblVaImpor.Text = "-----";
            // 
            // lblReId
            // 
            this.lblReId.AutoSize = true;
            this.lblReId.Location = new System.Drawing.Point(796, 127);
            this.lblReId.Name = "lblReId";
            this.lblReId.Size = new System.Drawing.Size(22, 13);
            this.lblReId.TabIndex = 36;
            this.lblReId.Text = "-----";
            // 
            // lblReImpor
            // 
            this.lblReImpor.AutoSize = true;
            this.lblReImpor.Location = new System.Drawing.Point(866, 127);
            this.lblReImpor.Name = "lblReImpor";
            this.lblReImpor.Size = new System.Drawing.Size(22, 13);
            this.lblReImpor.TabIndex = 37;
            this.lblReImpor.Text = "-----";
            // 
            // lblCoId
            // 
            this.lblCoId.AutoSize = true;
            this.lblCoId.Location = new System.Drawing.Point(796, 158);
            this.lblCoId.Name = "lblCoId";
            this.lblCoId.Size = new System.Drawing.Size(22, 13);
            this.lblCoId.TabIndex = 38;
            this.lblCoId.Text = "-----";
            // 
            // lblCoImpor
            // 
            this.lblCoImpor.AutoSize = true;
            this.lblCoImpor.Location = new System.Drawing.Point(866, 158);
            this.lblCoImpor.Name = "lblCoImpor";
            this.lblCoImpor.Size = new System.Drawing.Size(22, 13);
            this.lblCoImpor.TabIndex = 39;
            this.lblCoImpor.Text = "-----";
            // 
            // lblVeId
            // 
            this.lblVeId.AutoSize = true;
            this.lblVeId.Location = new System.Drawing.Point(796, 191);
            this.lblVeId.Name = "lblVeId";
            this.lblVeId.Size = new System.Drawing.Size(22, 13);
            this.lblVeId.TabIndex = 40;
            this.lblVeId.Text = "-----";
            // 
            // lblVeImpor
            // 
            this.lblVeImpor.AutoSize = true;
            this.lblVeImpor.Location = new System.Drawing.Point(866, 191);
            this.lblVeImpor.Name = "lblVeImpor";
            this.lblVeImpor.Size = new System.Drawing.Size(22, 13);
            this.lblVeImpor.TabIndex = 41;
            this.lblVeImpor.Text = "-----";
            // 
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 676);
            this.Controls.Add(this.lblVeImpor);
            this.Controls.Add(this.lblVeId);
            this.Controls.Add(this.lblCoImpor);
            this.Controls.Add(this.lblCoId);
            this.Controls.Add(this.lblReImpor);
            this.Controls.Add(this.lblReId);
            this.Controls.Add(this.lblVaImpor);
            this.Controls.Add(this.lblBoId);
            this.Controls.Add(this.lblBoImpor);
            this.Controls.Add(this.lblVaId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGCompra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBArchivo);
            this.Controls.Add(this.LBConexion);
            this.Controls.Add(this.CBTienda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBFabricante);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.tbDescuento);
            this.Controls.Add(this.tbFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.label1);
            this.Name = "frm_Compras";
            this.Text = "frm_Compras";
            this.Load += new System.EventHandler(this.frm_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Factura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFactura;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.ComboBox CBFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBTienda;
        private System.Windows.Forms.Label LBConexion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TBArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGCompra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVaId;
        private System.Windows.Forms.Label lblBoImpor;
        private System.Windows.Forms.Label lblBoId;
        private System.Windows.Forms.Label lblVaImpor;
        private System.Windows.Forms.Label lblReId;
        private System.Windows.Forms.Label lblReImpor;
        private System.Windows.Forms.Label lblCoId;
        private System.Windows.Forms.Label lblCoImpor;
        private System.Windows.Forms.Label lblVeId;
        private System.Windows.Forms.Label lblVeImpor;
    }
}