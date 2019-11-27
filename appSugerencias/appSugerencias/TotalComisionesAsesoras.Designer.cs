﻿namespace appSugerencias
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
            this.COMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROBLEMAS_ETIQUETAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONRISA_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATENCION_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPARACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXHIBIDO_ORDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUGERENCIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETECTAR_ROBOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUG_RESULTADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCENTIVO_EXTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MERC_CERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REP_CAMARA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BT_importar.Location = new System.Drawing.Point(347, 18);
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
            this.BT_calcular.Location = new System.Drawing.Point(453, 18);
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
            this.BT_exportar.Location = new System.Drawing.Point(559, 18);
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
            this.COMISION,
            this.PROBLEMAS_ETIQUETAS,
            this.OFERTA,
            this.SONRISA_CLIENTE,
            this.ATENCION_CLIENTE,
            this.REPARACIONES,
            this.EXHIBIDO_ORDEN,
            this.SUGERENCIAS,
            this.DETECTAR_ROBOS,
            this.SUG_RESULTADOS,
            this.INCENTIVO_EXTRA,
            this.MERC_CERO,
            this.REP_CAMARA,
            this.PAGAR});
            this.DG_comisiones.Location = new System.Drawing.Point(12, 94);
            this.DG_comisiones.Name = "DG_comisiones";
            this.DG_comisiones.Size = new System.Drawing.Size(1546, 219);
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
            // COMISION
            // 
            this.COMISION.HeaderText = "COMISION";
            this.COMISION.Name = "COMISION";
            // 
            // PROBLEMAS_ETIQUETAS
            // 
            this.PROBLEMAS_ETIQUETAS.HeaderText = "PROBLEMAS CON ETIQUETAS";
            this.PROBLEMAS_ETIQUETAS.Name = "ETIQUETAS";
            // 
            // OFERTA
            // 
            this.OFERTA.HeaderText = "OFERTA CON PRECIO EXHIBIDO";
            this.OFERTA.Name = "OFERTA";
            // 
            // SONRISA_CLIENTE
            // 
            this.SONRISA_CLIENTE.HeaderText = "SONRISA AL CLIENTE";
            this.SONRISA_CLIENTE.Name = "SONRISA";
            // 
            // ATENCION_CLIENTE
            // 
            this.ATENCION_CLIENTE.HeaderText = "ATENCION AL CLIENTE";
            this.ATENCION_CLIENTE.Name = "ATENCION";
            // 
            // REPARACIONES
            // 
            this.REPARACIONES.HeaderText = "REPARACION DE MARCANCIA";
            this.REPARACIONES.Name = "REPARACIONES";
            // 
            // EXHIBIDO_ORDEN
            // 
            this.EXHIBIDO_ORDEN.HeaderText = "EXHIBIDO Y ORDEN";
            this.EXHIBIDO_ORDEN.Name = "ORDEN";
            // 
            // PROPUESTAS
            // 
            this.SUGERENCIAS.HeaderText = "SUGERENCIAS";
            this.SUGERENCIAS.Name = "SUGERENCIAS";
            // 
            // DETECTAR_ROBOS
            // 
            this.DETECTAR_ROBOS.HeaderText = "DETECTAR ROBOS";
            this.DETECTAR_ROBOS.Name = "ROBOS";
            // 
            // SUG_RESULTADOS
            // 
            this.SUG_RESULTADOS.HeaderText = "SUGERENCIAS POR RESULTADOS";
            this.SUG_RESULTADOS.Name = "RESULTADOS";
            // 
            // INCENTIVO_EXTRA
            // 
            this.INCENTIVO_EXTRA.HeaderText = "EXTRA";
            this.INCENTIVO_EXTRA.Name = "EXTRA";
            // 
            // MERC_CERO
            // 
            this.MERC_CERO.HeaderText = "MERCANCIA EN CERO";
            this.MERC_CERO.Name = "CEROS";
            // 
            // REP_CAMARA
            // 
            this.REP_CAMARA.HeaderText = "REPORTES";
            this.REP_CAMARA.Name = "REPORTES";
            // 
            // PAGAR
            // 
            this.PAGAR.HeaderText = "COMISION TOTAL";
            this.PAGAR.Name = "TOTAL";
            // 
            // TotalComisionesAsesoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1570, 338);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROBLEMAS_ETIQUETAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONRISA_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATENCION_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPARACIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXHIBIDO_ORDEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUGERENCIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETECTAR_ROBOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUG_RESULTADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCENTIVO_EXTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MERC_CERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REP_CAMARA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGAR;
    }
}