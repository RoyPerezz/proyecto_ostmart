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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProBo = new System.Windows.Forms.Label();
            this.lblProVa = new System.Windows.Forms.Label();
            this.lblProRe = new System.Windows.Forms.Label();
            this.lblProCo = new System.Windows.Forms.Label();
            this.lblProVe = new System.Windows.Forms.Label();
            this.lblPa = new System.Windows.Forms.Label();
            this.lblPaId = new System.Windows.Forms.Label();
            this.lblPaImpor = new System.Windows.Forms.Label();
            this.lblPaPro = new System.Windows.Forms.Label();
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
            "COLOSO",
            "PREGOT"});
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
            this.TBArchivo.TextChanged += new System.EventHandler(this.TBArchivo_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGCompra
            // 
            this.DGCompra.AllowUserToAddRows = false;
            this.DGCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCompra.Location = new System.Drawing.Point(21, 328);
            this.DGCompra.Name = "DGCompra";
            this.DGCompra.Size = new System.Drawing.Size(1411, 336);
            this.DGCompra.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(444, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cargar Compra";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "VALLARTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(847, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "RENA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(847, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "COLOSO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(847, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "VELAZQUEZ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(847, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "BODEGA";
            // 
            // lblVaId
            // 
            this.lblVaId.AutoSize = true;
            this.lblVaId.Location = new System.Drawing.Point(953, 89);
            this.lblVaId.Name = "lblVaId";
            this.lblVaId.Size = new System.Drawing.Size(22, 13);
            this.lblVaId.TabIndex = 32;
            this.lblVaId.Text = "-----";
            // 
            // lblBoImpor
            // 
            this.lblBoImpor.AutoSize = true;
            this.lblBoImpor.Location = new System.Drawing.Point(1046, 54);
            this.lblBoImpor.Name = "lblBoImpor";
            this.lblBoImpor.Size = new System.Drawing.Size(22, 13);
            this.lblBoImpor.TabIndex = 33;
            this.lblBoImpor.Text = "-----";
            // 
            // lblBoId
            // 
            this.lblBoId.AutoSize = true;
            this.lblBoId.Location = new System.Drawing.Point(953, 54);
            this.lblBoId.Name = "lblBoId";
            this.lblBoId.Size = new System.Drawing.Size(22, 13);
            this.lblBoId.TabIndex = 34;
            this.lblBoId.Text = "-----";
            // 
            // lblVaImpor
            // 
            this.lblVaImpor.AutoSize = true;
            this.lblVaImpor.Location = new System.Drawing.Point(1046, 89);
            this.lblVaImpor.Name = "lblVaImpor";
            this.lblVaImpor.Size = new System.Drawing.Size(22, 13);
            this.lblVaImpor.TabIndex = 35;
            this.lblVaImpor.Text = "-----";
            // 
            // lblReId
            // 
            this.lblReId.AutoSize = true;
            this.lblReId.Location = new System.Drawing.Point(953, 124);
            this.lblReId.Name = "lblReId";
            this.lblReId.Size = new System.Drawing.Size(22, 13);
            this.lblReId.TabIndex = 36;
            this.lblReId.Text = "-----";
            // 
            // lblReImpor
            // 
            this.lblReImpor.AutoSize = true;
            this.lblReImpor.Location = new System.Drawing.Point(1046, 124);
            this.lblReImpor.Name = "lblReImpor";
            this.lblReImpor.Size = new System.Drawing.Size(22, 13);
            this.lblReImpor.TabIndex = 37;
            this.lblReImpor.Text = "-----";
            // 
            // lblCoId
            // 
            this.lblCoId.AutoSize = true;
            this.lblCoId.Location = new System.Drawing.Point(953, 159);
            this.lblCoId.Name = "lblCoId";
            this.lblCoId.Size = new System.Drawing.Size(22, 13);
            this.lblCoId.TabIndex = 38;
            this.lblCoId.Text = "-----";
            // 
            // lblCoImpor
            // 
            this.lblCoImpor.AutoSize = true;
            this.lblCoImpor.Location = new System.Drawing.Point(1046, 159);
            this.lblCoImpor.Name = "lblCoImpor";
            this.lblCoImpor.Size = new System.Drawing.Size(22, 13);
            this.lblCoImpor.TabIndex = 39;
            this.lblCoImpor.Text = "-----";
            // 
            // lblVeId
            // 
            this.lblVeId.AutoSize = true;
            this.lblVeId.Location = new System.Drawing.Point(953, 194);
            this.lblVeId.Name = "lblVeId";
            this.lblVeId.Size = new System.Drawing.Size(22, 13);
            this.lblVeId.TabIndex = 40;
            this.lblVeId.Text = "-----";
            // 
            // lblVeImpor
            // 
            this.lblVeImpor.AutoSize = true;
            this.lblVeImpor.Location = new System.Drawing.Point(1046, 194);
            this.lblVeImpor.Name = "lblVeImpor";
            this.lblVeImpor.Size = new System.Drawing.Size(22, 13);
            this.lblVeImpor.TabIndex = 41;
            this.lblVeImpor.Text = "-----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(922, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "No. Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1030, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Importe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1115, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "Proveedor";
            // 
            // lblProBo
            // 
            this.lblProBo.AutoSize = true;
            this.lblProBo.Location = new System.Drawing.Point(1130, 54);
            this.lblProBo.Name = "lblProBo";
            this.lblProBo.Size = new System.Drawing.Size(22, 13);
            this.lblProBo.TabIndex = 46;
            this.lblProBo.Text = "-----";
            // 
            // lblProVa
            // 
            this.lblProVa.AutoSize = true;
            this.lblProVa.Location = new System.Drawing.Point(1130, 89);
            this.lblProVa.Name = "lblProVa";
            this.lblProVa.Size = new System.Drawing.Size(22, 13);
            this.lblProVa.TabIndex = 47;
            this.lblProVa.Text = "-----";
            // 
            // lblProRe
            // 
            this.lblProRe.AutoSize = true;
            this.lblProRe.Location = new System.Drawing.Point(1130, 124);
            this.lblProRe.Name = "lblProRe";
            this.lblProRe.Size = new System.Drawing.Size(22, 13);
            this.lblProRe.TabIndex = 48;
            this.lblProRe.Text = "-----";
            // 
            // lblProCo
            // 
            this.lblProCo.AutoSize = true;
            this.lblProCo.Location = new System.Drawing.Point(1130, 159);
            this.lblProCo.Name = "lblProCo";
            this.lblProCo.Size = new System.Drawing.Size(22, 13);
            this.lblProCo.TabIndex = 49;
            this.lblProCo.Text = "-----";
            // 
            // lblProVe
            // 
            this.lblProVe.AutoSize = true;
            this.lblProVe.Location = new System.Drawing.Point(1130, 194);
            this.lblProVe.Name = "lblProVe";
            this.lblProVe.Size = new System.Drawing.Size(22, 13);
            this.lblProVe.TabIndex = 50;
            this.lblProVe.Text = "-----";
            // 
            // lblPa
            // 
            this.lblPa.AutoSize = true;
            this.lblPa.Location = new System.Drawing.Point(847, 225);
            this.lblPa.Name = "lblPa";
            this.lblPa.Size = new System.Drawing.Size(66, 13);
            this.lblPa.TabIndex = 51;
            this.lblPa.Text = "PAPELERIA";
            // 
            // lblPaId
            // 
            this.lblPaId.AutoSize = true;
            this.lblPaId.Location = new System.Drawing.Point(953, 225);
            this.lblPaId.Name = "lblPaId";
            this.lblPaId.Size = new System.Drawing.Size(22, 13);
            this.lblPaId.TabIndex = 52;
            this.lblPaId.Text = "-----";
            // 
            // lblPaImpor
            // 
            this.lblPaImpor.AutoSize = true;
            this.lblPaImpor.Location = new System.Drawing.Point(1046, 225);
            this.lblPaImpor.Name = "lblPaImpor";
            this.lblPaImpor.Size = new System.Drawing.Size(22, 13);
            this.lblPaImpor.TabIndex = 53;
            this.lblPaImpor.Text = "-----";
            // 
            // lblPaPro
            // 
            this.lblPaPro.AutoSize = true;
            this.lblPaPro.Location = new System.Drawing.Point(1130, 225);
            this.lblPaPro.Name = "lblPaPro";
            this.lblPaPro.Size = new System.Drawing.Size(22, 13);
            this.lblPaPro.TabIndex = 54;
            this.lblPaPro.Text = "-----";
            // 
            // frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1444, 676);
            this.Controls.Add(this.lblPaPro);
            this.Controls.Add(this.lblPaImpor);
            this.Controls.Add(this.lblPaId);
            this.Controls.Add(this.lblPa);
            this.Controls.Add(this.lblProVe);
            this.Controls.Add(this.lblProCo);
            this.Controls.Add(this.lblProRe);
            this.Controls.Add(this.lblProVa);
            this.Controls.Add(this.lblProBo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
            this.Text = "Cargar Compras";
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProBo;
        private System.Windows.Forms.Label lblProVa;
        private System.Windows.Forms.Label lblProRe;
        private System.Windows.Forms.Label lblProCo;
        private System.Windows.Forms.Label lblProVe;
        private System.Windows.Forms.Label lblPa;
        private System.Windows.Forms.Label lblPaId;
        private System.Windows.Forms.Label lblPaImpor;
        private System.Windows.Forms.Label lblPaPro;
    }
}