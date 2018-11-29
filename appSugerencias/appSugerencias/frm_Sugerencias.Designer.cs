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
            this.SuspendLayout();
            // 
            // RT_Sugerencia
            // 
            this.RT_Sugerencia.Location = new System.Drawing.Point(31, 50);
            this.RT_Sugerencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RT_Sugerencia.Name = "RT_Sugerencia";
            this.RT_Sugerencia.Size = new System.Drawing.Size(457, 149);
            this.RT_Sugerencia.TabIndex = 0;
            this.RT_Sugerencia.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe tu sugerencia...";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(31, 244);
            this.TB_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(457, 22);
            this.TB_Nombre.TabIndex = 2;
            this.TB_Nombre.TextChanged += new System.EventHandler(this.TB_Nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Location = new System.Drawing.Point(191, 297);
            this.bt_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(160, 60);
            this.bt_Guardar.TabIndex = 4;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // frm_Sugerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 396);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RT_Sugerencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

