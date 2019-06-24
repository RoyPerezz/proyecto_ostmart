namespace appSugerencias
{
    partial class Principal_vitrina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_vitrina));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_existencias = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_entradas = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_saludo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_existencias,
            this.Menu_entradas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Menu_existencias
            // 
            this.Menu_existencias.Name = "Menu_existencias";
            this.Menu_existencias.Size = new System.Drawing.Size(75, 20);
            this.Menu_existencias.Text = "Existencias";
            this.Menu_existencias.Click += new System.EventHandler(this.existenciasToolStripMenuItem_Click);
            // 
            // Menu_entradas
            // 
            this.Menu_entradas.Name = "Menu_entradas";
            this.Menu_entradas.Size = new System.Drawing.Size(64, 20);
            this.Menu_entradas.Text = "Entradas";
            this.Menu_entradas.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // LB_saludo
            // 
            this.LB_saludo.AutoSize = true;
            this.LB_saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_saludo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_saludo.Location = new System.Drawing.Point(679, 112);
            this.LB_saludo.Name = "LB_saludo";
            this.LB_saludo.Size = new System.Drawing.Size(0, 25);
            this.LB_saludo.TabIndex = 1;
            this.LB_saludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal_vitrina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_saludo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal_vitrina";
            this.Text = "SOFTMART VITRINA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_vitrina_FormClosed);
            this.Load += new System.EventHandler(this.Principal_vitrina_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_existencias;
        private System.Windows.Forms.ToolStripMenuItem Menu_entradas;
        private System.Windows.Forms.Label LB_saludo;
    }
}