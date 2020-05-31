namespace appSugerencias
{
    partial class PagarA
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
            this.BT_registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.TB_banco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_persona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_registrar
            // 
            this.BT_registrar.Location = new System.Drawing.Point(463, 86);
            this.BT_registrar.Name = "BT_registrar";
            this.BT_registrar.Size = new System.Drawing.Size(75, 37);
            this.BT_registrar.TabIndex = 0;
            this.BT_registrar.Text = "Registrar";
            this.BT_registrar.UseVisualStyleBackColor = true;
            this.BT_registrar.Click += new System.EventHandler(this.BT_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDOR";
            // 
            // TB_nombre
            // 
            this.TB_nombre.Location = new System.Drawing.Point(119, 30);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(400, 20);
            this.TB_nombre.TabIndex = 2;
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Location = new System.Drawing.Point(119, 4);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(65, 20);
            this.TB_proveedor.TabIndex = 3;
            // 
            // TB_banco
            // 
            this.TB_banco.Location = new System.Drawing.Point(119, 56);
            this.TB_banco.Name = "TB_banco";
            this.TB_banco.Size = new System.Drawing.Size(108, 20);
            this.TB_banco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BANCO";
            // 
            // TB_persona
            // 
            this.TB_persona.Location = new System.Drawing.Point(46, 102);
            this.TB_persona.Name = "TB_persona";
            this.TB_persona.Size = new System.Drawing.Size(400, 20);
            this.TB_persona.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NOMBRE DE LA PERSONA A PAGAR";
            // 
            // PagarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 148);
            this.Controls.Add(this.TB_persona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_banco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.TB_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_registrar);
            this.Name = "PagarA";
            this.Text = "PagarA";
            this.Load += new System.EventHandler(this.PagarA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.TextBox TB_banco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_persona;
        private System.Windows.Forms.Label label3;
    }
}