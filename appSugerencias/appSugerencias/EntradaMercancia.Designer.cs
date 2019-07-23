namespace appSugerencias
{
    partial class EntradaMercancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaMercancia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.DG_entradas = new System.Windows.Forms.DataGridView();
            this.CB_vitrinas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DG_detalle = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_estado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(12, 44);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 0;
            // 
            // DG_entradas
            // 
            this.DG_entradas.AllowUserToAddRows = false;
            this.DG_entradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_entradas.Location = new System.Drawing.Point(11, 101);
            this.DG_entradas.Name = "DG_entradas";
            this.DG_entradas.Size = new System.Drawing.Size(200, 391);
            this.DG_entradas.TabIndex = 1;
            this.DG_entradas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_entradas_CellContentDoubleClick);
            // 
            // CB_vitrinas
            // 
            this.CB_vitrinas.FormattingEnabled = true;
            this.CB_vitrinas.Items.AddRange(new object[] {
            "RENA",
            "COLOSO",
            "VALLARTA",
            "VELAZQUEZ"});
            this.CB_vitrinas.Location = new System.Drawing.Point(79, 20);
            this.CB_vitrinas.Name = "CB_vitrinas";
            this.CB_vitrinas.Size = new System.Drawing.Size(132, 21);
            this.CB_vitrinas.TabIndex = 2;
            this.CB_vitrinas.SelectedIndexChanged += new System.EventHandler(this.CB_vitrinas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VITRINA";
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Image = ((System.Drawing.Image)(resources.GetObject("BT_buscar.Image")));
            this.BT_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_buscar.Location = new System.Drawing.Point(218, 20);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(89, 47);
            this.BT_buscar.TabIndex = 4;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DG_detalle
            // 
            this.DG_detalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DG_detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_detalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_detalle.Location = new System.Drawing.Point(218, 101);
            this.DG_detalle.Name = "DG_detalle";
            this.DG_detalle.Size = new System.Drawing.Size(514, 391);
            this.DG_detalle.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(316, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exportar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_usuario
            // 
            this.TB_usuario.Enabled = false;
            this.TB_usuario.Location = new System.Drawing.Point(600, 47);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(132, 20);
            this.TB_usuario.TabIndex = 7;
            this.TB_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Realizó";
            // 
            // LB_estado
            // 
            this.LB_estado.AutoSize = true;
            this.LB_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_estado.Location = new System.Drawing.Point(76, 76);
            this.LB_estado.Name = "LB_estado";
            this.LB_estado.Size = new System.Drawing.Size(0, 13);
            this.LB_estado.TabIndex = 9;
            // 
            // EntradaMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 504);
            this.Controls.Add(this.LB_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_usuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG_detalle);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_vitrinas);
            this.Controls.Add(this.DG_entradas);
            this.Controls.Add(this.DT_fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EntradaMercancia";
            this.Text = "EntradaMercancia";
            this.Load += new System.EventHandler(this.EntradaMercancia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.DataGridView DG_entradas;
        private System.Windows.Forms.ComboBox CB_vitrinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridView DG_detalle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_estado;
    }
}