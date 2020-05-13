namespace appSugerencias
{
    partial class InvFisicoxLinea
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
            this.CB_lineas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_recalcular = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BT_cargarArchivo = new System.Windows.Forms.Button();
            this.TB_mensaje = new System.Windows.Forms.TextBox();
            this.DG1 = new System.Windows.Forms.DataGridView();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTOU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_CantItems = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dlGuardar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_lineas
            // 
            this.CB_lineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_lineas.FormattingEnabled = true;
            this.CB_lineas.Location = new System.Drawing.Point(19, 56);
            this.CB_lineas.Name = "CB_lineas";
            this.CB_lineas.Size = new System.Drawing.Size(185, 28);
            this.CB_lineas.TabIndex = 0;
            this.CB_lineas.SelectedIndexChanged += new System.EventHandler(this.CB_lineas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LINEAS";
            // 
            // BT_recalcular
            // 
            this.BT_recalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_recalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_recalcular.ForeColor = System.Drawing.Color.White;
            this.BT_recalcular.Location = new System.Drawing.Point(19, 90);
            this.BT_recalcular.Name = "BT_recalcular";
            this.BT_recalcular.Size = new System.Drawing.Size(185, 49);
            this.BT_recalcular.TabIndex = 2;
            this.BT_recalcular.Text = "1.- Recalcular Linea";
            this.BT_recalcular.UseVisualStyleBackColor = false;
            this.BT_recalcular.Click += new System.EventHandler(this.BT_recalcular_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(19, 145);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(185, 49);
            this.BT_exportar.TabIndex = 3;
            this.BT_exportar.Text = "2.- Exportar artículos con existencia";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "4.- Articulos en ceros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_cargarArchivo
            // 
            this.BT_cargarArchivo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_cargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cargarArchivo.ForeColor = System.Drawing.Color.White;
            this.BT_cargarArchivo.Location = new System.Drawing.Point(19, 304);
            this.BT_cargarArchivo.Name = "BT_cargarArchivo";
            this.BT_cargarArchivo.Size = new System.Drawing.Size(185, 45);
            this.BT_cargarArchivo.TabIndex = 5;
            this.BT_cargarArchivo.Text = "5.- Cargar Archivo";
            this.BT_cargarArchivo.UseVisualStyleBackColor = false;
            this.BT_cargarArchivo.Click += new System.EventHandler(this.BT_cargarArchivo_Click);
            // 
            // TB_mensaje
            // 
            this.TB_mensaje.BackColor = System.Drawing.Color.Black;
            this.TB_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_mensaje.ForeColor = System.Drawing.Color.Lime;
            this.TB_mensaje.Location = new System.Drawing.Point(225, 323);
            this.TB_mensaje.Name = "TB_mensaje";
            this.TB_mensaje.Size = new System.Drawing.Size(545, 26);
            this.TB_mensaje.TabIndex = 6;
            // 
            // DG1
            // 
            this.DG1.AllowUserToAddRows = false;
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE,
            this.DESCRIP,
            this.COSTOU,
            this.CANT,
            this.TOTAL_});
            this.DG1.Location = new System.Drawing.Point(225, 56);
            this.DG1.Name = "DG1";
            this.DG1.Size = new System.Drawing.Size(545, 261);
            this.DG1.TabIndex = 7;
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "ARTICULO";
            this.CLAVE.Name = "CLAVE";
            // 
            // DESCRIP
            // 
            this.DESCRIP.HeaderText = "DESCRIPCION";
            this.DESCRIP.Name = "DESCRIP";
            // 
            // COSTOU
            // 
            this.COSTOU.HeaderText = "COSTO UNITARIO";
            this.COSTOU.Name = "COSTOU";
            // 
            // CANT
            // 
            this.CANT.HeaderText = "EXISTENCIA";
            this.CANT.Name = "CANT";
            // 
            // TOTAL_
            // 
            this.TOTAL_.HeaderText = "TOTAL";
            this.TOTAL_.Name = "TOTAL_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Items:";
            // 
            // TB_CantItems
            // 
            this.TB_CantItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CantItems.Location = new System.Drawing.Point(670, 24);
            this.TB_CantItems.Name = "TB_CantItems";
            this.TB_CantItems.Size = new System.Drawing.Size(100, 26);
            this.TB_CantItems.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(19, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "3.- Archivo TxT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InvFisicoxLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(790, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TB_CantItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG1);
            this.Controls.Add(this.TB_mensaje);
            this.Controls.Add(this.BT_cargarArchivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_recalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_lineas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvFisicoxLinea";
            this.Text = "Inventario Físico";
            this.Load += new System.EventHandler(this.InvFisicoxLinea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_lineas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_recalcular;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BT_cargarArchivo;
        private System.Windows.Forms.TextBox TB_mensaje;
        private System.Windows.Forms.DataGridView DG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTOU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_CantItems;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog dlGuardar;
    }
}