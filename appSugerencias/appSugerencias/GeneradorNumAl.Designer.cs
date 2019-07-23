namespace appSugerencias
{
    partial class GeneradorNumAl
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
            this.DG_numeros = new System.Windows.Forms.DataGridView();
            this.NUMEROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Generar = new System.Windows.Forms.Button();
            this.TB_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_exportar = new System.Windows.Forms.Button();
            this.BT_productos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_numeros)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_numeros
            // 
            this.DG_numeros.AllowUserToAddRows = false;
            this.DG_numeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_numeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMEROS});
            this.DG_numeros.Location = new System.Drawing.Point(28, 31);
            this.DG_numeros.Name = "DG_numeros";
            this.DG_numeros.Size = new System.Drawing.Size(143, 276);
            this.DG_numeros.TabIndex = 0;
            // 
            // NUMEROS
            // 
            this.NUMEROS.HeaderText = "NUMEROS";
            this.NUMEROS.Name = "NUMEROS";
            // 
            // BT_Generar
            // 
            this.BT_Generar.Location = new System.Drawing.Point(189, 38);
            this.BT_Generar.Name = "BT_Generar";
            this.BT_Generar.Size = new System.Drawing.Size(98, 50);
            this.BT_Generar.TabIndex = 1;
            this.BT_Generar.Text = "Generar";
            this.BT_Generar.UseVisualStyleBackColor = true;
            this.BT_Generar.Click += new System.EventHandler(this.BT_Generar_Click);
            // 
            // TB_cantidad
            // 
            this.TB_cantidad.Location = new System.Drawing.Point(189, 12);
            this.TB_cantidad.Name = "TB_cantidad";
            this.TB_cantidad.Size = new System.Drawing.Size(98, 20);
            this.TB_cantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Claves";
            // 
            // TB_exportar
            // 
            this.TB_exportar.Location = new System.Drawing.Point(189, 94);
            this.TB_exportar.Name = "TB_exportar";
            this.TB_exportar.Size = new System.Drawing.Size(98, 50);
            this.TB_exportar.TabIndex = 4;
            this.TB_exportar.Text = "Exportar";
            this.TB_exportar.UseVisualStyleBackColor = true;
            this.TB_exportar.Click += new System.EventHandler(this.TB_exportar_Click);
            // 
            // BT_productos
            // 
            this.BT_productos.Location = new System.Drawing.Point(189, 150);
            this.BT_productos.Name = "BT_productos";
            this.BT_productos.Size = new System.Drawing.Size(98, 50);
            this.BT_productos.TabIndex = 5;
            this.BT_productos.Text = "Claves productos";
            this.BT_productos.UseVisualStyleBackColor = true;
            this.BT_productos.Click += new System.EventHandler(this.BT_productos_Click);
            // 
            // GeneradorNumAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 329);
            this.Controls.Add(this.BT_productos);
            this.Controls.Add(this.TB_exportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_cantidad);
            this.Controls.Add(this.BT_Generar);
            this.Controls.Add(this.DG_numeros);
            this.Name = "GeneradorNumAl";
            this.Text = "Generador de Números Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.DG_numeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_numeros;
        private System.Windows.Forms.Button BT_Generar;
        private System.Windows.Forms.TextBox TB_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROS;
        private System.Windows.Forms.Button TB_exportar;
        private System.Windows.Forms.Button BT_productos;
    }
}