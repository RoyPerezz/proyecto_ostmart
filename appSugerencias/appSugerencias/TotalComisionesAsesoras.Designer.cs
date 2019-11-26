namespace appSugerencias
{
    partial class TotalComisionesAsesoras
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
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETIQUETAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONRISA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPARACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUGERENCIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROBOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESULTADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_importar = new System.Windows.Forms.Button();
            this.BT_calcular = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_datos
            // 
            this.DG_datos.AllowUserToAddRows = false;
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIO,
            this.DEPARTAMENTO,
            this.PUESTO,
            this.IMPORTE,
            this.ETIQUETAS,
            this.PRECIO,
            this.SONRISA,
            this.ATENCION,
            this.REPARACION,
            this.ORDEN,
            this.SUGERENCIAS,
            this.ROBOS,
            this.RESULTADOS,
            this.EXTRA,
            this.TOTAL});
            this.DG_datos.Location = new System.Drawing.Point(12, 96);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.Size = new System.Drawing.Size(1540, 288);
            this.DG_datos.TabIndex = 0;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            // 
            // PUESTO
            // 
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // ETIQUETAS
            // 
            this.ETIQUETAS.HeaderText = "ETIQUETAS";
            this.ETIQUETAS.Name = "ETIQUETAS";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO EXHIBIDO";
            this.PRECIO.Name = "PRECIO";
            // 
            // SONRISA
            // 
            this.SONRISA.HeaderText = "SONRISA AL CLIENTE";
            this.SONRISA.Name = "SONRISA";
            // 
            // ATENCION
            // 
            this.ATENCION.HeaderText = "ATENCION AL CLIENTE";
            this.ATENCION.Name = "ATENCION";
            // 
            // REPARACION
            // 
            this.REPARACION.HeaderText = "REP. MERC.";
            this.REPARACION.Name = "REPARACION";
            // 
            // ORDEN
            // 
            this.ORDEN.HeaderText = "EXHIBIDO Y ORDEN";
            this.ORDEN.Name = "ORDEN";
            // 
            // SUGERENCIAS
            // 
            this.SUGERENCIAS.HeaderText = "SUGERENCIAS";
            this.SUGERENCIAS.Name = "SUGERENCIAS";
            // 
            // ROBOS
            // 
            this.ROBOS.HeaderText = "DETECT. ROBOS";
            this.ROBOS.Name = "ROBOS";
            // 
            // RESULTADOS
            // 
            this.RESULTADOS.HeaderText = "SUG. RESULTADOS";
            this.RESULTADOS.Name = "RESULTADOS";
            // 
            // EXTRA
            // 
            this.EXTRA.HeaderText = "EXTRA";
            this.EXTRA.Name = "EXTRA";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(77, 16);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(77, 49);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fin";
            // 
            // BT_importar
            // 
            this.BT_importar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_importar.ForeColor = System.Drawing.Color.White;
            this.BT_importar.Location = new System.Drawing.Point(302, 16);
            this.BT_importar.Name = "BT_importar";
            this.BT_importar.Size = new System.Drawing.Size(115, 53);
            this.BT_importar.TabIndex = 5;
            this.BT_importar.Text = "Importar Datos";
            this.BT_importar.UseVisualStyleBackColor = false;
            // 
            // BT_calcular
            // 
            this.BT_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calcular.ForeColor = System.Drawing.Color.White;
            this.BT_calcular.Location = new System.Drawing.Point(442, 16);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(115, 53);
            this.BT_calcular.TabIndex = 6;
            this.BT_calcular.Text = "Calcular";
            this.BT_calcular.UseVisualStyleBackColor = false;
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(581, 16);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(115, 53);
            this.BT_exportar.TabIndex = 7;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            // 
            // TotalComisionesAsesoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1565, 397);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_calcular);
            this.Controls.Add(this.BT_importar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Controls.Add(this.DG_datos);
            this.Name = "TotalComisionesAsesoras";
            this.Text = "TotalComisionesAsesoras";
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETIQUETAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONRISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPARACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUGERENCIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROBOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESULTADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_importar;
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.Button BT_exportar;
    }
}