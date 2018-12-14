namespace appSugerencias
{
    partial class frm_FormatoCajera
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxPiezas = new System.Windows.Forms.TextBox();
            this.textboxProveedor = new System.Windows.Forms.TextBox();
            this.textboxPrecio = new System.Windows.Forms.TextBox();
            this.textboxDescrip = new System.Windows.Forms.TextBox();
            this.comboboxAlter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(29, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "User";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(60, 43);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(125, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Piezas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Provedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripción";
            // 
            // textboxPiezas
            // 
            this.textboxPiezas.Location = new System.Drawing.Point(77, 184);
            this.textboxPiezas.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPiezas.Name = "textboxPiezas";
            this.textboxPiezas.Size = new System.Drawing.Size(62, 20);
            this.textboxPiezas.TabIndex = 14;
            // 
            // textboxProveedor
            // 
            this.textboxProveedor.Location = new System.Drawing.Point(77, 120);
            this.textboxProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.textboxProveedor.Name = "textboxProveedor";
            this.textboxProveedor.Size = new System.Drawing.Size(85, 20);
            this.textboxProveedor.TabIndex = 13;
            // 
            // textboxPrecio
            // 
            this.textboxPrecio.Location = new System.Drawing.Point(77, 150);
            this.textboxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textboxPrecio.Name = "textboxPrecio";
            this.textboxPrecio.Size = new System.Drawing.Size(62, 20);
            this.textboxPrecio.TabIndex = 12;
            // 
            // textboxDescrip
            // 
            this.textboxDescrip.Location = new System.Drawing.Point(77, 88);
            this.textboxDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.textboxDescrip.Name = "textboxDescrip";
            this.textboxDescrip.Size = new System.Drawing.Size(278, 20);
            this.textboxDescrip.TabIndex = 11;
            // 
            // comboboxAlter
            // 
            this.comboboxAlter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxAlter.FormattingEnabled = true;
            this.comboboxAlter.Items.AddRange(new object[] {
            "ART. EN CEROS",
            "SIN ETIQUETA",
            "ETIQUETA BORROSA"});
            this.comboboxAlter.Location = new System.Drawing.Point(75, 228);
            this.comboboxAlter.Name = "comboboxAlter";
            this.comboboxAlter.Size = new System.Drawing.Size(121, 21);
            this.comboboxAlter.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Alteracion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cantidad";
            // 
            // textboxCantidad
            // 
            this.textboxCantidad.Location = new System.Drawing.Point(77, 263);
            this.textboxCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textboxCantidad.Name = "textboxCantidad";
            this.textboxCantidad.Size = new System.Drawing.Size(62, 20);
            this.textboxCantidad.TabIndex = 23;
            // 
            // frm_FormatoCajera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 463);
            this.Controls.Add(this.textboxCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboboxAlter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxPiezas);
            this.Controls.Add(this.textboxProveedor);
            this.Controls.Add(this.textboxPrecio);
            this.Controls.Add(this.textboxDescrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frm_FormatoCajera";
            this.Text = "frm_FormatoCajera";
            this.Load += new System.EventHandler(this.frm_FormatoCajera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxPiezas;
        private System.Windows.Forms.TextBox textboxProveedor;
        private System.Windows.Forms.TextBox textboxPrecio;
        private System.Windows.Forms.TextBox textboxDescrip;
        private System.Windows.Forms.ComboBox comboboxAlter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxCantidad;
    }
}