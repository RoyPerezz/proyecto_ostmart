namespace appSugerencias
{
    partial class frm_Sugerencias
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RT_Sugerencia = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.CB_cargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RT_Sugerencia
            // 
            this.RT_Sugerencia.Location = new System.Drawing.Point(23, 41);
            this.RT_Sugerencia.Name = "RT_Sugerencia";
            this.RT_Sugerencia.Size = new System.Drawing.Size(344, 122);
            this.RT_Sugerencia.TabIndex = 0;
            this.RT_Sugerencia.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe tu sugerencia...";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(23, 198);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(344, 20);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.TextChanged += new System.EventHandler(this.TB_Nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Location = new System.Drawing.Point(140, 285);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(120, 49);
            this.bt_Guardar.TabIndex = 4;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // CB_cargo
            // 
            this.CB_cargo.FormattingEnabled = true;
            this.CB_cargo.Items.AddRange(new object[] {
            "Asesora de Ventas",
            "Administrativo",
            "Cajera"});
            this.CB_cargo.Location = new System.Drawing.Point(22, 244);
            this.CB_cargo.Name = "CB_cargo";
            this.CB_cargo.Size = new System.Drawing.Size(161, 21);
            this.CB_cargo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirigida a";
            // 
            // CB_tipo
            // 
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Items.AddRange(new object[] {
            "General",
            "Mantenimiento",
            "Sistemas"});
            this.CB_tipo.Location = new System.Drawing.Point(206, 244);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(161, 21);
            this.CB_tipo.TabIndex = 7;
            // 
            // frm_Sugerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 352);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_cargo);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RT_Sugerencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Sugerencias";
            this.Text = "Sugerencias del personal";
            this.Load += new System.EventHandler(this.frm_Sugerencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RT_Sugerencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.ComboBox CB_cargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_tipo;
    }
}

