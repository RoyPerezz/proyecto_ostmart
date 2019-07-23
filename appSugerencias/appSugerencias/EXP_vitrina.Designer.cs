namespace appSugerencias
{
    partial class EXP_vitrina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXP_vitrina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_proveedores = new System.Windows.Forms.ComboBox();
            this.DG_existencias = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_estadoVallarta = new System.Windows.Forms.Label();
            this.LB_Rena = new System.Windows.Forms.Label();
            this.LB_Coloso = new System.Windows.Forms.Label();
            this.LB_estadoVelazquez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_existencias)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Image = ((System.Drawing.Image)(resources.GetObject("BT_exportar.Image")));
            this.BT_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_exportar.Location = new System.Drawing.Point(835, 452);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(112, 51);
            this.BT_exportar.TabIndex = 7;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-119, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proveedores";
            // 
            // CB_proveedores
            // 
            this.CB_proveedores.FormattingEnabled = true;
            this.CB_proveedores.Location = new System.Drawing.Point(137, 22);
            this.CB_proveedores.Name = "CB_proveedores";
            this.CB_proveedores.Size = new System.Drawing.Size(810, 21);
            this.CB_proveedores.TabIndex = 5;
            this.CB_proveedores.SelectedIndexChanged += new System.EventHandler(this.CB_proveedores_SelectedIndexChanged);
            // 
            // DG_existencias
            // 
            this.DG_existencias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DG_existencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_existencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_existencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_existencias.EnableHeadersVisualStyles = false;
            this.DG_existencias.Location = new System.Drawing.Point(12, 67);
            this.DG_existencias.Name = "DG_existencias";
            this.DG_existencias.Size = new System.Drawing.Size(935, 379);
            this.DG_existencias.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proveedores";
            // 
            // LB_estadoVallarta
            // 
            this.LB_estadoVallarta.AutoSize = true;
            this.LB_estadoVallarta.Location = new System.Drawing.Point(533, 47);
            this.LB_estadoVallarta.Name = "LB_estadoVallarta";
            this.LB_estadoVallarta.Size = new System.Drawing.Size(0, 13);
            this.LB_estadoVallarta.TabIndex = 9;
            this.LB_estadoVallarta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Rena
            // 
            this.LB_Rena.AutoSize = true;
            this.LB_Rena.Location = new System.Drawing.Point(641, 47);
            this.LB_Rena.Name = "LB_Rena";
            this.LB_Rena.Size = new System.Drawing.Size(0, 13);
            this.LB_Rena.TabIndex = 10;
            this.LB_Rena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Coloso
            // 
            this.LB_Coloso.AutoSize = true;
            this.LB_Coloso.Location = new System.Drawing.Point(836, 46);
            this.LB_Coloso.Name = "LB_Coloso";
            this.LB_Coloso.Size = new System.Drawing.Size(0, 13);
            this.LB_Coloso.TabIndex = 11;
            this.LB_Coloso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_estadoVelazquez
            // 
            this.LB_estadoVelazquez.AutoSize = true;
            this.LB_estadoVelazquez.Location = new System.Drawing.Point(742, 47);
            this.LB_estadoVelazquez.Name = "LB_estadoVelazquez";
            this.LB_estadoVelazquez.Size = new System.Drawing.Size(0, 13);
            this.LB_estadoVelazquez.TabIndex = 12;
            this.LB_estadoVelazquez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EXP_vitrina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(959, 501);
            this.Controls.Add(this.LB_estadoVelazquez);
            this.Controls.Add(this.LB_Coloso);
            this.Controls.Add(this.LB_Rena);
            this.Controls.Add(this.LB_estadoVallarta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_proveedores);
            this.Controls.Add(this.DG_existencias);
            this.Name = "EXP_vitrina";
            this.Text = "Existencias Vitrina";
            this.Load += new System.EventHandler(this.EXP_vitrina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_existencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_proveedores;
        private System.Windows.Forms.DataGridView DG_existencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_estadoVallarta;
        private System.Windows.Forms.Label LB_Rena;
        private System.Windows.Forms.Label LB_Coloso;
        private System.Windows.Forms.Label LB_estadoVelazquez;
    }
}