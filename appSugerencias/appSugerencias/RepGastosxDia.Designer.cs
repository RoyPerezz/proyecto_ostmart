namespace appSugerencias
{
    partial class RepGastosxDia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_gastos = new System.Windows.Forms.DataGridView();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.BT_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_gastos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_gastos
            // 
            this.DG_gastos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DG_gastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE,
            this.DESCRIPCION,
            this.IMPORTE,
            this.IE,
            this.FECHA,
            this.HORA,
            this.USUARIO,
            this.ESTACION});
            this.DG_gastos.Location = new System.Drawing.Point(4, 59);
            this.DG_gastos.Name = "DG_gastos";
            this.DG_gastos.Size = new System.Drawing.Size(1025, 459);
            this.DG_gastos.TabIndex = 0;
            // 
            // CLAVE
            // 
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // IE
            // 
            this.IE.HeaderText = "IE";
            this.IE.Name = "IE";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // HORA
            // 
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // ESTACION
            // 
            this.ESTACION.HeaderText = "ESTACION";
            this.ESTACION.Name = "ESTACION";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Location = new System.Drawing.Point(722, 18);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 1;
            // 
            // BT_aceptar
            // 
            this.BT_aceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_aceptar.ForeColor = System.Drawing.Color.White;
            this.BT_aceptar.Location = new System.Drawing.Point(927, 6);
            this.BT_aceptar.Name = "BT_aceptar";
            this.BT_aceptar.Size = new System.Drawing.Size(101, 44);
            this.BT_aceptar.TabIndex = 2;
            this.BT_aceptar.Text = "Aceptar";
            this.BT_aceptar.UseVisualStyleBackColor = false;
            this.BT_aceptar.Click += new System.EventHandler(this.BT_aceptar_Click);
            // 
            // RepGastosxDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1033, 530);
            this.Controls.Add(this.BT_aceptar);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.DG_gastos);
            this.Name = "RepGastosxDia";
            this.Text = "RepGastosxDia";
            this.Load += new System.EventHandler(this.RepGastosxDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_gastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_gastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTACION;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Button BT_aceptar;
    }
}