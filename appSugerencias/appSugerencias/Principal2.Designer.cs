namespace appSugerencias
{
    partial class Principal2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kARDEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.showMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificadorToolStripMenuItem,
            this.kARDEXToolStripMenuItem,
            this.showMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verificadorToolStripMenuItem
            // 
            this.verificadorToolStripMenuItem.Name = "verificadorToolStripMenuItem";
            this.verificadorToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.verificadorToolStripMenuItem.Text = "Verificador";
            this.verificadorToolStripMenuItem.Click += new System.EventHandler(this.verificadorToolStripMenuItem_Click);
            // 
            // kARDEXToolStripMenuItem
            // 
            this.kARDEXToolStripMenuItem.Name = "kARDEXToolStripMenuItem";
            this.kARDEXToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.kARDEXToolStripMenuItem.Text = "KARDEX";
            this.kARDEXToolStripMenuItem.Click += new System.EventHandler(this.kARDEXToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desarrollado por Ing. Daniel";
            // 
            // showMeToolStripMenuItem
            // 
            this.showMeToolStripMenuItem.Name = "showMeToolStripMenuItem";
            this.showMeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.showMeToolStripMenuItem.Text = "Show Me";
            this.showMeToolStripMenuItem.Click += new System.EventHandler(this.showMeToolStripMenuItem_Click);
            // 
            // Principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal2";
            this.Text = "Osmart Verificador By DaNxD 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verificadorToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem kARDEXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMeToolStripMenuItem;
    }
}