namespace appSugerencias
{
    partial class ArticuloSinVentas
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
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDescrip = new System.Windows.Forms.TextBox();
            this.textboxPrecio = new System.Windows.Forms.TextBox();
            this.textboxProveedor = new System.Windows.Forms.TextBox();
            this.textboxPiezas = new System.Windows.Forms.TextBox();
            this.texboxNoSeVende = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(89, 36);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(130, 22);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxDescrip
            // 
            this.textboxDescrip.Location = new System.Drawing.Point(119, 131);
            this.textboxDescrip.Name = "textboxDescrip";
            this.textboxDescrip.Size = new System.Drawing.Size(369, 22);
            this.textboxDescrip.TabIndex = 2;
            this.textboxDescrip.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textboxPrecio
            // 
            this.textboxPrecio.Location = new System.Drawing.Point(119, 176);
            this.textboxPrecio.Name = "textboxPrecio";
            this.textboxPrecio.Size = new System.Drawing.Size(100, 22);
            this.textboxPrecio.TabIndex = 3;
            // 
            // textboxProveedor
            // 
            this.textboxProveedor.Location = new System.Drawing.Point(119, 219);
            this.textboxProveedor.Name = "textboxProveedor";
            this.textboxProveedor.Size = new System.Drawing.Size(100, 22);
            this.textboxProveedor.TabIndex = 4;
            // 
            // textboxPiezas
            // 
            this.textboxPiezas.Location = new System.Drawing.Point(119, 264);
            this.textboxPiezas.Name = "textboxPiezas";
            this.textboxPiezas.Size = new System.Drawing.Size(82, 22);
            this.textboxPiezas.TabIndex = 5;
            // 
            // texboxNoSeVende
            // 
            this.texboxNoSeVende.Location = new System.Drawing.Point(198, 319);
            this.texboxNoSeVende.Multiline = true;
            this.texboxNoSeVende.Name = "texboxNoSeVende";
            this.texboxNoSeVende.Size = new System.Drawing.Size(234, 70);
            this.texboxNoSeVende.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Provedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Piezas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motivo que no se Vendo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Departamento";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BISUTERIA",
            "COSMETICOS",
            "ESCOLAR",
            "JUGUETERIA",
            "MOSTRADOR",
            "PLASTICOS"});
            this.comboBox1.Location = new System.Drawing.Point(198, 424);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // ArticuloSinVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 526);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texboxNoSeVende);
            this.Controls.Add(this.textboxPiezas);
            this.Controls.Add(this.textboxProveedor);
            this.Controls.Add(this.textboxPrecio);
            this.Controls.Add(this.textboxDescrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigo);
            this.Name = "ArticuloSinVentas";
            this.Text = "ArticuloSinVentas";
            this.Load += new System.EventHandler(this.ArticuloSinVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDescrip;
        private System.Windows.Forms.TextBox textboxPrecio;
        private System.Windows.Forms.TextBox textboxProveedor;
        private System.Windows.Forms.TextBox textboxPiezas;
        private System.Windows.Forms.TextBox texboxNoSeVende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}