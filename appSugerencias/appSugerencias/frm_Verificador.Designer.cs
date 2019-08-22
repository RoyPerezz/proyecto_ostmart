namespace appSugerencias
{
    partial class frm_Verificador
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
            this.components = new System.ComponentModel.Container();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.lblTienda = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLeyendaOferta = new System.Windows.Forms.Label();
            this.lblOferta1 = new System.Windows.Forms.Label();
            this.lblOferta2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.Black;
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtArticulo.Location = new System.Drawing.Point(35, 644);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(1142, 31);
            this.txtArticulo.TabIndex = 1;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtArticulo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyUp);
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTienda.Location = new System.Drawing.Point(175, 59);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(296, 73);
            this.lblTienda.TabIndex = 2;
            this.lblTienda.Text = "Empresa";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(129, 187);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 29);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Codigo:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(330, 170);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(319, 46);
            this.lblArticulo.TabIndex = 6;
            this.lblArticulo.Text = "5454545454545";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(332, 230);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(476, 46);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Esto es una Descripcion";
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio1.Location = new System.Drawing.Point(332, 290);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(164, 46);
            this.lblPrecio1.TabIndex = 8;
            this.lblPrecio1.Text = "Precio1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(129, 247);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(159, 29);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Descripcion:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(129, 367);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(121, 29);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Mayoreo:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(129, 307);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(129, 29);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Menudeo:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(129, 427);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(139, 29);
            this.lbl5.TabIndex = 14;
            this.lbl5.Text = "Existencia:";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio2.Location = new System.Drawing.Point(332, 350);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(164, 46);
            this.lblPrecio2.TabIndex = 15;
            this.lblPrecio2.Text = "Precio2";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.Location = new System.Drawing.Point(332, 410);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(214, 46);
            this.lblExistencia.TabIndex = 16;
            this.lblExistencia.Text = "Existencia";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(129, 487);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(184, 29);
            this.lbl6.TabIndex = 17;
            this.lbl6.Text = "Departamento:";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.Location = new System.Drawing.Point(332, 470);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(122, 46);
            this.lblLinea.TabIndex = 18;
            this.lblLinea.Text = "Linea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appSugerencias.Properties.Resources.PREGOT_RGB_negro1;
            this.pictureBox1.Location = new System.Drawing.Point(179, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 333);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblLeyendaOferta
            // 
            this.lblLeyendaOferta.AutoSize = true;
            this.lblLeyendaOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyendaOferta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLeyendaOferta.Location = new System.Drawing.Point(733, 395);
            this.lblLeyendaOferta.Name = "lblLeyendaOferta";
            this.lblLeyendaOferta.Size = new System.Drawing.Size(207, 20);
            this.lblLeyendaOferta.TabIndex = 21;
            this.lblLeyendaOferta.Text = "Producto con Descuento";
            // 
            // lblOferta1
            // 
            this.lblOferta1.AutoSize = true;
            this.lblOferta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOferta1.Location = new System.Drawing.Point(750, 293);
            this.lblOferta1.Name = "lblOferta1";
            this.lblOferta1.Size = new System.Drawing.Size(164, 46);
            this.lblOferta1.TabIndex = 22;
            this.lblOferta1.Text = "Precio1";
            // 
            // lblOferta2
            // 
            this.lblOferta2.AutoSize = true;
            this.lblOferta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOferta2.Location = new System.Drawing.Point(750, 349);
            this.lblOferta2.Name = "lblOferta2";
            this.lblOferta2.Size = new System.Drawing.Size(164, 46);
            this.lblOferta2.TabIndex = 23;
            this.lblOferta2.Text = "Precio2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 45);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(127, 547);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(144, 29);
            this.lbl7.TabIndex = 25;
            this.lbl7.Text = "Fabricante:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(330, 530);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(218, 46);
            this.lblFabricante.TabIndex = 26;
            this.lblFabricante.Text = "Fabricante";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "KARDEX";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_Verificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1215, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOferta2);
            this.Controls.Add(this.lblOferta1);
            this.Controls.Add(this.lblLeyendaOferta);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.lblPrecio2);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPrecio1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTienda);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Verificador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador Desarrollado DaNxD";
            this.Load += new System.EventHandler(this.frm_Verificador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLeyendaOferta;
        private System.Windows.Forms.Label lblOferta1;
        private System.Windows.Forms.Label lblOferta2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Button button1;
    }
}