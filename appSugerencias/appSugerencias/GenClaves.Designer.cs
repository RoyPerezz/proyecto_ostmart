namespace appSugerencias
{
    partial class GenClaves
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
            this.components = new System.ComponentModel.Container();
            this.DG_numeros = new System.Windows.Forms.DataGridView();
            this.CLAVES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_depto = new System.Windows.Forms.TextBox();
            this.TB_proveedor = new System.Windows.Forms.TextBox();
            this.BT_generar = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_generadas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_estatusVallarta = new System.Windows.Forms.TextBox();
            this.TB_estatusRena = new System.Windows.Forms.TextBox();
            this.TB_estatusColoso = new System.Windows.Forms.TextBox();
            this.TB_estatusVelazquez = new System.Windows.Forms.TextBox();
            this.TB_estatusBodega = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PB_proceso = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_mensaje = new System.Windows.Forms.Label();
            this.TB_estatuspregot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_numeros)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_numeros
            // 
            this.DG_numeros.AllowUserToAddRows = false;
            this.DG_numeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_numeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVES});
            this.DG_numeros.Location = new System.Drawing.Point(19, 12);
            this.DG_numeros.Name = "DG_numeros";
            this.DG_numeros.Size = new System.Drawing.Size(173, 426);
            this.DG_numeros.TabIndex = 0;
            // 
            // CLAVES
            // 
            this.CLAVES.HeaderText = "CLAVES";
            this.CLAVES.Name = "CLAVES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proveedor";
            // 
            // TB_depto
            // 
            this.TB_depto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_depto.Location = new System.Drawing.Point(242, 233);
            this.TB_depto.Name = "TB_depto";
            this.TB_depto.Size = new System.Drawing.Size(67, 24);
            this.TB_depto.TabIndex = 5;
            // 
            // TB_proveedor
            // 
            this.TB_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_proveedor.Location = new System.Drawing.Point(343, 233);
            this.TB_proveedor.Name = "TB_proveedor";
            this.TB_proveedor.Size = new System.Drawing.Size(67, 24);
            this.TB_proveedor.TabIndex = 6;
            // 
            // BT_generar
            // 
            this.BT_generar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_generar.ForeColor = System.Drawing.Color.White;
            this.BT_generar.Location = new System.Drawing.Point(204, 277);
            this.BT_generar.Name = "BT_generar";
            this.BT_generar.Size = new System.Drawing.Size(105, 59);
            this.BT_generar.TabIndex = 7;
            this.BT_generar.Text = "Generar Claves";
            this.BT_generar.UseVisualStyleBackColor = false;
            this.BT_generar.Click += new System.EventHandler(this.BT_generar_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(332, 277);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(107, 59);
            this.BT_exportar.TabIndex = 9;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Claves Generadas";
            // 
            // LB_generadas
            // 
            this.LB_generadas.AutoSize = true;
            this.LB_generadas.Location = new System.Drawing.Point(437, 12);
            this.LB_generadas.Name = "LB_generadas";
            this.LB_generadas.Size = new System.Drawing.Size(0, 13);
            this.LB_generadas.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "VALLARTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "RENA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "COLOSO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "VELAZQUEZ";
            // 
            // TB_estatusVallarta
            // 
            this.TB_estatusVallarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_estatusVallarta.Location = new System.Drawing.Point(197, 38);
            this.TB_estatusVallarta.Name = "TB_estatusVallarta";
            this.TB_estatusVallarta.Size = new System.Drawing.Size(25, 24);
            this.TB_estatusVallarta.TabIndex = 18;
            // 
            // TB_estatusRena
            // 
            this.TB_estatusRena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_estatusRena.Location = new System.Drawing.Point(197, 63);
            this.TB_estatusRena.Name = "TB_estatusRena";
            this.TB_estatusRena.Size = new System.Drawing.Size(25, 24);
            this.TB_estatusRena.TabIndex = 19;
            // 
            // TB_estatusColoso
            // 
            this.TB_estatusColoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_estatusColoso.Location = new System.Drawing.Point(197, 88);
            this.TB_estatusColoso.Name = "TB_estatusColoso";
            this.TB_estatusColoso.Size = new System.Drawing.Size(25, 24);
            this.TB_estatusColoso.TabIndex = 20;
            // 
            // TB_estatusVelazquez
            // 
            this.TB_estatusVelazquez.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_estatusVelazquez.Location = new System.Drawing.Point(197, 113);
            this.TB_estatusVelazquez.Name = "TB_estatusVelazquez";
            this.TB_estatusVelazquez.Size = new System.Drawing.Size(25, 24);
            this.TB_estatusVelazquez.TabIndex = 21;
            // 
            // TB_estatusBodega
            // 
            this.TB_estatusBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_estatusBodega.Location = new System.Drawing.Point(197, 12);
            this.TB_estatusBodega.Name = "TB_estatusBodega";
            this.TB_estatusBodega.Size = new System.Drawing.Size(25, 24);
            this.TB_estatusBodega.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "BODEGA";
            // 
            // PB_proceso
            // 
            this.PB_proceso.Location = new System.Drawing.Point(204, 393);
            this.PB_proceso.Name = "PB_proceso";
            this.PB_proceso.Size = new System.Drawing.Size(235, 31);
            this.PB_proceso.TabIndex = 24;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_mensaje
            // 
            this.LB_mensaje.AutoSize = true;
            this.LB_mensaje.Location = new System.Drawing.Point(350, 427);
            this.LB_mensaje.Name = "LB_mensaje";
            this.LB_mensaje.Size = new System.Drawing.Size(0, 13);
            this.LB_mensaje.TabIndex = 25;
            // 
            // TB_estatuspregot
            // 
            this.TB_estatuspregot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_estatuspregot.Location = new System.Drawing.Point(197, 138);
            this.TB_estatuspregot.Name = "TB_estatuspregot";
            this.TB_estatuspregot.Size = new System.Drawing.Size(25, 24);
            this.TB_estatuspregot.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "PREGOT";
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_limpiar.ForeColor = System.Drawing.Color.White;
            this.BT_limpiar.Location = new System.Drawing.Point(204, 342);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(235, 46);
            this.BT_limpiar.TabIndex = 28;
            this.BT_limpiar.Text = "Limpiar";
            this.BT_limpiar.UseVisualStyleBackColor = false;
            this.BT_limpiar.Click += new System.EventHandler(this.BT_limpiar_Click);
            // 
            // GenClaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.BT_limpiar);
            this.Controls.Add(this.TB_estatuspregot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_mensaje);
            this.Controls.Add(this.PB_proceso);
            this.Controls.Add(this.TB_estatusBodega);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_estatusVelazquez);
            this.Controls.Add(this.TB_estatusColoso);
            this.Controls.Add(this.TB_estatusRena);
            this.Controls.Add(this.TB_estatusVallarta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LB_generadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_generar);
            this.Controls.Add(this.TB_proveedor);
            this.Controls.Add(this.TB_depto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_numeros);
            this.Name = "GenClaves";
            this.Text = "GenClaves";
            this.Load += new System.EventHandler(this.GenClaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_numeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_numeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_depto;
        private System.Windows.Forms.TextBox TB_proveedor;
        private System.Windows.Forms.Button BT_generar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVES;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_generadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_estatusVallarta;
        private System.Windows.Forms.TextBox TB_estatusRena;
        private System.Windows.Forms.TextBox TB_estatusColoso;
        private System.Windows.Forms.TextBox TB_estatusVelazquez;
        private System.Windows.Forms.TextBox TB_estatusBodega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar PB_proceso;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LB_mensaje;
        private System.Windows.Forms.TextBox TB_estatuspregot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_limpiar;
    }
}