namespace appSugerencias
{
    partial class InvFisicoxLinea
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
            this.CB_lineas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_recalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_lineas
            // 
            this.CB_lineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_lineas.FormattingEnabled = true;
            this.CB_lineas.Location = new System.Drawing.Point(99, 39);
            this.CB_lineas.Name = "CB_lineas";
            this.CB_lineas.Size = new System.Drawing.Size(185, 28);
            this.CB_lineas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LINEAS";
            // 
            // BT_recalcular
            // 
            this.BT_recalcular.Location = new System.Drawing.Point(99, 73);
            this.BT_recalcular.Name = "BT_recalcular";
            this.BT_recalcular.Size = new System.Drawing.Size(185, 49);
            this.BT_recalcular.TabIndex = 2;
            this.BT_recalcular.Text = "Recalcular Linea";
            this.BT_recalcular.UseVisualStyleBackColor = true;
            // 
            // InvFisicoxLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.BT_recalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_lineas);
            this.Name = "InvFisicoxLinea";
            this.Text = "InvFisicoxLinea";
            this.Load += new System.EventHandler(this.InvFisicoxLinea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_lineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_recalcular;
    }
}