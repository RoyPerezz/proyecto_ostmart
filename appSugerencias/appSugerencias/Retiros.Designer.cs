namespace appSugerencias
{
    partial class Retiros
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_num_op = new System.Windows.Forms.TextBox();
            this.TB_importe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_estacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_aplicar = new System.Windows.Forms.Button();
            this.LB_usuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_operacion = new System.Windows.Forms.Label();
            this.LB_importe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. Operación";
            // 
            // TB_num_op
            // 
            this.TB_num_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_num_op.Location = new System.Drawing.Point(147, 141);
            this.TB_num_op.Name = "TB_num_op";
            this.TB_num_op.Size = new System.Drawing.Size(271, 26);
            this.TB_num_op.TabIndex = 1;
            // 
            // TB_importe
            // 
            this.TB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_importe.Location = new System.Drawing.Point(147, 173);
            this.TB_importe.Name = "TB_importe";
            this.TB_importe.Size = new System.Drawing.Size(271, 26);
            this.TB_importe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // CB_estacion
            // 
            this.CB_estacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_estacion.FormattingEnabled = true;
            this.CB_estacion.Items.AddRange(new object[] {
            "  ",
            "CAJA1",
            "CAJA2",
            "CAJA3",
            "CAJA4",
            "CAJA5",
            "CAJA6",
            "CAJA7"});
            this.CB_estacion.Location = new System.Drawing.Point(147, 107);
            this.CB_estacion.Name = "CB_estacion";
            this.CB_estacion.Size = new System.Drawing.Size(271, 28);
            this.CB_estacion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estación";
            // 
            // BT_aplicar
            // 
            this.BT_aplicar.Location = new System.Drawing.Point(318, 205);
            this.BT_aplicar.Name = "BT_aplicar";
            this.BT_aplicar.Size = new System.Drawing.Size(100, 45);
            this.BT_aplicar.TabIndex = 6;
            this.BT_aplicar.Text = "Aplicar";
            this.BT_aplicar.UseVisualStyleBackColor = true;
            this.BT_aplicar.Click += new System.EventHandler(this.BT_aplicar_Click);
            // 
            // LB_usuario
            // 
            this.LB_usuario.AutoSize = true;
            this.LB_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_usuario.Location = new System.Drawing.Point(16, 9);
            this.LB_usuario.Name = "LB_usuario";
            this.LB_usuario.Size = new System.Drawing.Size(61, 20);
            this.LB_usuario.TabIndex = 7;
            this.LB_usuario.Text = "usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_importe);
            this.groupBox1.Controls.Add(this.LB_operacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(210, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ultima Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Num. Operación";
            // 
            // LB_operacion
            // 
            this.LB_operacion.AutoSize = true;
            this.LB_operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_operacion.Location = new System.Drawing.Point(117, 35);
            this.LB_operacion.Name = "LB_operacion";
            this.LB_operacion.Size = new System.Drawing.Size(0, 15);
            this.LB_operacion.TabIndex = 11;
            // 
            // LB_importe
            // 
            this.LB_importe.AutoSize = true;
            this.LB_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_importe.Location = new System.Drawing.Point(115, 65);
            this.LB_importe.Name = "LB_importe";
            this.LB_importe.Size = new System.Drawing.Size(0, 15);
            this.LB_importe.TabIndex = 12;
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB_usuario);
            this.Controls.Add(this.BT_aplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_estacion);
            this.Controls.Add(this.TB_importe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_num_op);
            this.Controls.Add(this.label1);
            this.Name = "Retiros";
            this.Text = "Retiros con Tarjeta";
            this.Load += new System.EventHandler(this.Retiros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_num_op;
        private System.Windows.Forms.TextBox TB_importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_estacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_aplicar;
        private System.Windows.Forms.Label LB_usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_importe;
        private System.Windows.Forms.Label LB_operacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}