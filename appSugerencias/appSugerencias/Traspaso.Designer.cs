namespace appSugerencias
{
    partial class Traspaso
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
            this.DG_datos = new System.Windows.Forms.DataGridView();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.TB_origen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_destino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.TB_motivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idtraspaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_datos
            // 
            this.DG_datos.AllowUserToAddRows = false;
            this.DG_datos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtraspaso,
            this.ARTICULO,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.EXISTENCIAS});
            this.DG_datos.Enabled = false;
            this.DG_datos.Location = new System.Drawing.Point(35, 183);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.RowHeadersWidth = 40;
            this.DG_datos.Size = new System.Drawing.Size(513, 150);
            this.DG_datos.TabIndex = 0;
            this.DG_datos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_datos_CellValueChanged);
            // 
            // TB_articulo
            // 
            this.TB_articulo.Enabled = false;
            this.TB_articulo.Location = new System.Drawing.Point(76, 157);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(171, 20);
            this.TB_articulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulo";
            // 
            // BT_agregar
            // 
            this.BT_agregar.Enabled = false;
            this.BT_agregar.Location = new System.Drawing.Point(316, 145);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(111, 34);
            this.BT_agregar.TabIndex = 3;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.UseVisualStyleBackColor = true;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // TB_origen
            // 
            this.TB_origen.Enabled = false;
            this.TB_origen.Location = new System.Drawing.Point(438, 15);
            this.TB_origen.Name = "TB_origen";
            this.TB_origen.Size = new System.Drawing.Size(111, 20);
            this.TB_origen.TabIndex = 4;
            this.TB_origen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Origen";
            // 
            // CB_destino
            // 
            this.CB_destino.FormattingEnabled = true;
            this.CB_destino.Items.AddRange(new object[] {
            "BO",
            "CO",
            "VA",
            "VE",
            "RE"});
            this.CB_destino.Location = new System.Drawing.Point(438, 41);
            this.CB_destino.Name = "CB_destino";
            this.CB_destino.Size = new System.Drawing.Size(111, 21);
            this.CB_destino.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destino";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Enabled = false;
            this.DT_fecha.Location = new System.Drawing.Point(35, 12);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(241, 20);
            this.DT_fecha.TabIndex = 8;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Enabled = false;
            this.BT_guardar.Location = new System.Drawing.Point(235, 355);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(111, 36);
            this.BT_guardar.TabIndex = 9;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = true;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // TB_motivo
            // 
            this.TB_motivo.Location = new System.Drawing.Point(35, 59);
            this.TB_motivo.Multiline = true;
            this.TB_motivo.Name = "TB_motivo";
            this.TB_motivo.Size = new System.Drawing.Size(241, 53);
            this.TB_motivo.TabIndex = 10;
            this.TB_motivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Motivo";
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.Enabled = false;
            this.BT_eliminar.Location = new System.Drawing.Point(437, 145);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(111, 34);
            this.BT_eliminar.TabIndex = 12;
            this.BT_eliminar.Text = "Quitar";
            this.BT_eliminar.UseVisualStyleBackColor = true;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Crear traspaso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idtraspaso
            // 
            this.idtraspaso.HeaderText = "ID";
            this.idtraspaso.Name = "idtraspaso";
            this.idtraspaso.Visible = false;
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.Visible = false;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // EXISTENCIAS
            // 
            this.EXISTENCIAS.HeaderText = "EXISTENCIAS";
            this.EXISTENCIAS.Name = "EXISTENCIAS";
            // 
            // Traspaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_motivo);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_origen);
            this.Controls.Add(this.BT_agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.DG_datos);
            this.Name = "Traspaso";
            this.Text = "Traspaso";
            this.Load += new System.EventHandler(this.Traspaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.TextBox TB_origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_destino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.TextBox TB_motivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtraspaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIAS;
    }
}