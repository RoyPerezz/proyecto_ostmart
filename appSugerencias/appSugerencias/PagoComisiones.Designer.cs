namespace appSugerencias
{
    partial class PagoComisiones
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
            this.CB_usuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DGV_comisiones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_extra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_ctotal = new System.Windows.Forms.TextBox();
            this.BTN_aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_semana = new System.Windows.Forms.TextBox();
            this.BT_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_comisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_usuario
            // 
            this.CB_usuario.FormattingEnabled = true;
            this.CB_usuario.Location = new System.Drawing.Point(58, 21);
            this.CB_usuario.Name = "CB_usuario";
            this.CB_usuario.Size = new System.Drawing.Size(133, 21);
            this.CB_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(299, 24);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 2;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(299, 50);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 3;
            // 
            // DGV_comisiones
            // 
            this.DGV_comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_comisiones.Location = new System.Drawing.Point(12, 63);
            this.DGV_comisiones.Name = "DGV_comisiones";
            this.DGV_comisiones.Size = new System.Drawing.Size(240, 196);
            this.DGV_comisiones.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fin";
            // 
            // TB_extra
            // 
            this.TB_extra.Location = new System.Drawing.Point(343, 213);
            this.TB_extra.Name = "TB_extra";
            this.TB_extra.Size = new System.Drawing.Size(156, 20);
            this.TB_extra.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comisión Extra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comisión Total";
            // 
            // TB_ctotal
            // 
            this.TB_ctotal.Location = new System.Drawing.Point(343, 239);
            this.TB_ctotal.Name = "TB_ctotal";
            this.TB_ctotal.Size = new System.Drawing.Size(156, 20);
            this.TB_ctotal.TabIndex = 9;
            // 
            // BTN_aceptar
            // 
            this.BTN_aceptar.Location = new System.Drawing.Point(12, 275);
            this.BTN_aceptar.Name = "BTN_aceptar";
            this.BTN_aceptar.Size = new System.Drawing.Size(156, 47);
            this.BTN_aceptar.TabIndex = 11;
            this.BTN_aceptar.Text = "Aceptar";
            this.BTN_aceptar.UseVisualStyleBackColor = true;
            this.BTN_aceptar.Click += new System.EventHandler(this.BTN_aceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Semana";
            // 
            // TB_semana
            // 
            this.TB_semana.Location = new System.Drawing.Point(344, 187);
            this.TB_semana.Name = "TB_semana";
            this.TB_semana.Size = new System.Drawing.Size(156, 20);
            this.TB_semana.TabIndex = 12;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Location = new System.Drawing.Point(341, 276);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(156, 46);
            this.BT_guardar.TabIndex = 14;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = true;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // PagoComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 330);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_semana);
            this.Controls.Add(this.BTN_aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_ctotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_extra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_comisiones);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_usuario);
            this.Name = "PagoComisiones";
            this.Text = "PagoComisiones";
            this.Load += new System.EventHandler(this.PagoComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_comisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DataGridView DGV_comisiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_extra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_ctotal;
        private System.Windows.Forms.Button BTN_aceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_semana;
        private System.Windows.Forms.Button BT_guardar;
    }
}