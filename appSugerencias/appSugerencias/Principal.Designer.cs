namespace appSugerencias
{
    partial class Principal
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
            this.traspasosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmCreaTraspaso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmAplicaTraspaso = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasosToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // traspasosToolStripMenuItem
            // 
            this.traspasosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsmCreaTraspaso,
            this.toolsmAplicaTraspaso});
            this.traspasosToolStripMenuItem.Name = "traspasosToolStripMenuItem";
            this.traspasosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.traspasosToolStripMenuItem.Text = "Traspasos";
            this.traspasosToolStripMenuItem.Click += new System.EventHandler(this.traspasosToolStripMenuItem_Click);
            // 
            // toolsmCreaTraspaso
            // 
            this.toolsmCreaTraspaso.Name = "toolsmCreaTraspaso";
            this.toolsmCreaTraspaso.Size = new System.Drawing.Size(160, 22);
            this.toolsmCreaTraspaso.Text = "Crear Traspaso";
            this.toolsmCreaTraspaso.Click += new System.EventHandler(this.crearTraspasoToolStripMenuItem_Click);
            // 
            // toolsmAplicaTraspaso
            // 
            this.toolsmAplicaTraspaso.Name = "toolsmAplicaTraspaso";
            this.toolsmAplicaTraspaso.Size = new System.Drawing.Size(160, 22);
            this.toolsmAplicaTraspaso.Text = "Aplicar Traspaso";
            this.toolsmAplicaTraspaso.Click += new System.EventHandler(this.aplicarTraspasoToolStripMenuItem_Click);
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            this.ofertasToolStripMenuItem.Click += new System.EventHandler(this.ofertasToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(81, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(45, 59);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(49, 13);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BD:";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(48, 75);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(34, 13);
            this.lblBD.TabIndex = 6;
            this.lblBD.Text = "Mysql";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.Text = "SoftMart 1.1.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem traspasosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsmCreaTraspaso;
        private System.Windows.Forms.ToolStripMenuItem toolsmAplicaTraspaso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBD;
    }
}