namespace appSugerencias
{
    partial class frm_clientes
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
            this.tbRFCBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRFC = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.tbRS = new System.Windows.Forms.TextBox();
            this.tbCalle = new System.Windows.Forms.TextBox();
            this.tbColonia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbInterior = new System.Windows.Forms.TextBox();
            this.tbExterior = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFC)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRFCBusqueda
            // 
            this.tbRFCBusqueda.Location = new System.Drawing.Point(63, 35);
            this.tbRFCBusqueda.Name = "tbRFCBusqueda";
            this.tbRFCBusqueda.Size = new System.Drawing.Size(169, 20);
            this.tbRFCBusqueda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RFC";
            // 
            // dgvRFC
            // 
            this.dgvRFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRFC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column1});
            this.dgvRFC.Location = new System.Drawing.Point(15, 99);
            this.dgvRFC.Name = "dgvRFC";
            this.dgvRFC.ReadOnly = true;
            this.dgvRFC.Size = new System.Drawing.Size(593, 461);
            this.dgvRFC.TabIndex = 2;
            this.dgvRFC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRFC_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CLIENTE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Razon Social";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 290;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RFC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRFC
            // 
            this.tbRFC.Location = new System.Drawing.Point(727, 40);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(129, 20);
            this.tbRFC.TabIndex = 4;
            // 
            // tbRS
            // 
            this.tbRS.Location = new System.Drawing.Point(727, 74);
            this.tbRS.Name = "tbRS";
            this.tbRS.Size = new System.Drawing.Size(405, 20);
            this.tbRS.TabIndex = 5;
            // 
            // tbCalle
            // 
            this.tbCalle.Location = new System.Drawing.Point(727, 108);
            this.tbCalle.Multiline = true;
            this.tbCalle.Name = "tbCalle";
            this.tbCalle.Size = new System.Drawing.Size(405, 36);
            this.tbCalle.TabIndex = 6;
            // 
            // tbColonia
            // 
            this.tbColonia.Location = new System.Drawing.Point(727, 158);
            this.tbColonia.Multiline = true;
            this.tbColonia.Name = "tbColonia";
            this.tbColonia.Size = new System.Drawing.Size(405, 32);
            this.tbColonia.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razon Social *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "RFC *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Colonia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pais";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Codigo Postal *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Correo Electronico *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(627, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Localidad";
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(727, 306);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(164, 20);
            this.tbLocalidad.TabIndex = 11;
            this.tbLocalidad.Text = "ACAPULCO DE JUAREZ";
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(727, 340);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(118, 20);
            this.tbPais.TabIndex = 12;
            this.tbPais.Text = "MEXICO";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(727, 374);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(118, 20);
            this.tbTelefono.TabIndex = 13;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(727, 408);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(73, 20);
            this.tbCP.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(727, 447);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(259, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(727, 272);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(118, 20);
            this.tbEstado.TabIndex = 10;
            this.tbEstado.Text = "GUERRERO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(627, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "No. Interior";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(628, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "No. Exterior";
            // 
            // tbInterior
            // 
            this.tbInterior.Location = new System.Drawing.Point(727, 204);
            this.tbInterior.Name = "tbInterior";
            this.tbInterior.Size = new System.Drawing.Size(118, 20);
            this.tbInterior.TabIndex = 8;
            // 
            // tbExterior
            // 
            this.tbExterior.Location = new System.Drawing.Point(727, 238);
            this.tbExterior.Name = "tbExterior";
            this.tbExterior.Size = new System.Drawing.Size(118, 20);
            this.tbExterior.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 27;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(983, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 28;
            this.button3.Text = "Nuevo Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(814, 502);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 45);
            this.button4.TabIndex = 29;
            this.button4.Text = "Actualizar Datos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1069, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Desarrollado por Ing. Daniel";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(862, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Sin guiones ni  caracteres -#$/()";
            // 
            // frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 591);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbExterior);
            this.Controls.Add(this.tbInterior);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbColonia);
            this.Controls.Add(this.tbCalle);
            this.Controls.Add(this.tbRS);
            this.Controls.Add(this.tbRFC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRFC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRFCBusqueda);
            this.Name = "frm_clientes";
            this.Text = "Modifica Cliente [DaNxD]";
            this.Load += new System.EventHandler(this.frm_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFCBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRFC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.TextBox tbRS;
        private System.Windows.Forms.TextBox tbCalle;
        private System.Windows.Forms.TextBox tbColonia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbInterior;
        private System.Windows.Forms.TextBox tbExterior;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}