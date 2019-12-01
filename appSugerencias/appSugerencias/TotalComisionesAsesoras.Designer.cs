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
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_importar = new System.Windows.Forms.Button();
            this.BT_calcular = new System.Windows.Forms.Button();
            this.BT_exportar = new System.Windows.Forms.Button();
            this.DG_comisiones = new System.Windows.Forms.DataGridView();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPARACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONRISA_CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENCION_CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDEN_CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANASTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROBO_CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESULTADOS_CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXTRA_CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MERC_CEROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTES_CAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_comisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_inicio
            // 
            this.DT_inicio.Location = new System.Drawing.Point(41, 18);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(200, 20);
            this.DT_inicio.TabIndex = 1;
            // 
            // DT_fin
            // 
            this.DT_fin.Location = new System.Drawing.Point(41, 51);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(200, 20);
            this.DT_fin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
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
            this.BT_importar.Location = new System.Drawing.Point(335, 18);
            this.BT_importar.Name = "BT_importar";
            this.BT_importar.Size = new System.Drawing.Size(100, 53);
            this.BT_importar.TabIndex = 5;
            this.BT_importar.Text = "Importar Datos";
            this.BT_importar.UseVisualStyleBackColor = false;
            this.BT_importar.Click += new System.EventHandler(this.BT_importar_Click);
            // 
            // BT_calcular
            // 
            this.BT_calcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_calcular.ForeColor = System.Drawing.Color.White;
            this.BT_calcular.Location = new System.Drawing.Point(441, 18);
            this.BT_calcular.Name = "BT_calcular";
            this.BT_calcular.Size = new System.Drawing.Size(100, 53);
            this.BT_calcular.TabIndex = 6;
            this.BT_calcular.Text = "Calcular";
            this.BT_calcular.UseVisualStyleBackColor = false;
            this.BT_calcular.Click += new System.EventHandler(this.BT_calcular_Click);
            // 
            // BT_exportar
            // 
            this.BT_exportar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_exportar.ForeColor = System.Drawing.Color.White;
            this.BT_exportar.Location = new System.Drawing.Point(547, 18);
            this.BT_exportar.Name = "BT_exportar";
            this.BT_exportar.Size = new System.Drawing.Size(100, 53);
            this.BT_exportar.TabIndex = 7;
            this.BT_exportar.Text = "Exportar";
            this.BT_exportar.UseVisualStyleBackColor = false;
            this.BT_exportar.Click += new System.EventHandler(this.BT_exportar_Click_1);
            // 
            // DG_comisiones
            // 
            this.DG_comisiones.AllowUserToAddRows = false;
            this.DG_comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_comisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIO,
            this.DEPARTAMENTO,
            this.PUESTO,
            this.OFERTA,
            this.REPARACIONES,
            this.SONRISA_CL,
            this.ATENCION_CL,
            this.ORDEN_CL,
            this.CANASTAS,
            this.ROBO_CL,
            this.RESULTADOS_CL,
            this.EXTRA_CL,
            this.COMISION,
            this.MERC_CEROS,
            this.REPORTES_CAM,
            this.TOTAL});
            this.DG_comisiones.Location = new System.Drawing.Point(10, 96);
            this.DG_comisiones.Name = "DG_comisiones";
            this.DG_comisiones.Size = new System.Drawing.Size(1479, 313);
            this.DG_comisiones.TabIndex = 8;
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
            // OFERTA
            // 
            this.OFERTA.HeaderText = "OFERTA CON PRECIO EXHIBIDO";
            this.OFERTA.Name = "OFERTA";
            // 
            // REPARACIONES
            // 
            this.REPARACIONES.HeaderText = "REPARACION DE MARCANCIA";
            this.REPARACIONES.Name = "REPARACIONES";
            // 
            // SONRISA_CL
            // 
            this.SONRISA_CL.HeaderText = "SONRISA AL CLIENTE";
            this.SONRISA_CL.Name = "SONRISA_CL";
            // 
            // ATENCION_CL
            // 
            this.ATENCION_CL.HeaderText = "ATENCION AL CLIENTE";
            this.ATENCION_CL.Name = "ATENCION_CL";
            // 
            // ORDEN_CL
            // 
            this.ORDEN_CL.HeaderText = "EXHIBIDO Y ORDEN";
            this.ORDEN_CL.Name = "ORDEN_CL";
            // 
            // CANASTAS
            // 
            this.CANASTAS.HeaderText = "CANASTAS";
            this.CANASTAS.Name = "CANASTAS";
            // 
            // ROBO_CL
            // 
            this.ROBO_CL.HeaderText = "DETECTAR DE ROBOS";
            this.ROBO_CL.Name = "ROBO_CL";
            // 
            // RESULTADOS_CL
            // 
            this.RESULTADOS_CL.HeaderText = "SUGERENCIAS POR RESULTADOS";
            this.RESULTADOS_CL.Name = "RESULTADOS_CL";
            // 
            // EXTRA_CL
            // 
            this.EXTRA_CL.HeaderText = "EXTRA";
            this.EXTRA_CL.Name = "EXTRA_CL";
            // 
            // COMISION
            // 
            this.COMISION.HeaderText = "COMISION";
            this.COMISION.Name = "COMISION";
            // 
            // MERC_CEROS
            // 
            this.MERC_CEROS.HeaderText = "MERCANCIA EN CEROS";
            this.MERC_CEROS.Name = "MERC_CEROS";
            // 
            // REPORTES_CAM
            // 
            this.REPORTES_CAM.HeaderText = "REPORTES";
            this.REPORTES_CAM.Name = "REPORTES_CAM";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "COMISION TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // TB_total
            // 
            this.TB_total.BackColor = System.Drawing.Color.Black;
            this.TB_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_total.ForeColor = System.Drawing.Color.SpringGreen;
            this.TB_total.Location = new System.Drawing.Point(1375, 426);
            this.TB_total.Name = "TB_total";
            this.TB_total.Size = new System.Drawing.Size(116, 29);
            this.TB_total.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1236, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total a Pagar";
            // 
            // TotalComisionesAsesoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1502, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_total);
            this.Controls.Add(this.DG_comisiones);
            this.Controls.Add(this.BT_exportar);
            this.Controls.Add(this.BT_calcular);
            this.Controls.Add(this.BT_importar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_fin);
            this.Controls.Add(this.DT_inicio);
            this.Name = "TotalComisionesAsesoras";
            this.Text = "TotalComisionesAsesoras";
            this.Load += new System.EventHandler(this.TotalComisionesAsesoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_comisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_importar;
        private System.Windows.Forms.Button BT_calcular;
        private System.Windows.Forms.Button BT_exportar;
        private System.Windows.Forms.DataGridView DG_comisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEMAS_ETIQUETAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONRISA_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENCION_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXHIBIDO_ORDEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETECTAR_ROBOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUG_RESULTADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCENTIVO_EXTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MERC_CERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REP_CAMARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGAR;
        private System.Windows.Forms.TextBox TB_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPARACIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONRISA_CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENCION_CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN_CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANASTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROBO_CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESULTADOS_CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXTRA_CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MERC_CEROS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTES_CAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}