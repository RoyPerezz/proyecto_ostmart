namespace appSugerencias
{
    partial class Sugerencias
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
            this.BT_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_sugerencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_cajera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_guardar
            // 
            this.BT_guardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.Color.White;
            this.BT_guardar.Location = new System.Drawing.Point(118, 229);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(121, 49);
            this.BT_guardar.TabIndex = 0;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe tu sugerencia";
            // 
            // TB_sugerencia
            // 
            this.TB_sugerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_sugerencia.Location = new System.Drawing.Point(12, 147);
            this.TB_sugerencia.Multiline = true;
            this.TB_sugerencia.Name = "TB_sugerencia";
            this.TB_sugerencia.Size = new System.Drawing.Size(332, 64);
            this.TB_sugerencia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cajera:";
            // 
            // LB_cajera
            // 
            this.LB_cajera.AutoSize = true;
            this.LB_cajera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_cajera.Location = new System.Drawing.Point(72, 128);
            this.LB_cajera.Name = "LB_cajera";
            this.LB_cajera.Size = new System.Drawing.Size(0, 16);
            this.LB_cajera.TabIndex = 4;
            // 
            // Sugerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(357, 305);
            this.Controls.Add(this.LB_cajera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_sugerencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_guardar);
            this.Name = "Sugerencias";
            this.Text = "Sugerencias";
            this.Load += new System.EventHandler(this.Sugerencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_sugerencia;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LB_cajera;
    }
}