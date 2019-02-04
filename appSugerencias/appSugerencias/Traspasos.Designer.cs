﻿namespace appSugerencias
{
    partial class Traspasos
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXISTENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fecha = new System.Windows.Forms.DateTimePicker();
            this.Motivo = new System.Windows.Forms.Label();
            this.TB_motivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_origen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_destino = new System.Windows.Forms.ComboBox();
            this.TB_articulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.BT_quitar = new System.Windows.Forms.Button();
            this.BT_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_datos
            // 
            this.DG_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ARTICULO,
            this.PRODUCTO,
            this.EXISTENCIA,
            this.CANTIDAD});
            this.DG_datos.Location = new System.Drawing.Point(12, 206);
            this.DG_datos.Name = "DG_datos";
            this.DG_datos.Size = new System.Drawing.Size(613, 150);
            this.DG_datos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // ARTICULO
            // 
            this.ARTICULO.HeaderText = "ARTICULO";
            this.ARTICULO.Name = "ARTICULO";
            this.ARTICULO.Visible = false;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            // 
            // EXISTENCIA
            // 
            this.EXISTENCIA.HeaderText = "EXISTENCIA";
            this.EXISTENCIA.Name = "EXISTENCIA";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // DT_fecha
            // 
            this.DT_fecha.Enabled = false;
            this.DT_fecha.Location = new System.Drawing.Point(12, 10);
            this.DT_fecha.Name = "DT_fecha";
            this.DT_fecha.Size = new System.Drawing.Size(200, 20);
            this.DT_fecha.TabIndex = 1;
            // 
            // Motivo
            // 
            this.Motivo.AutoSize = true;
            this.Motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motivo.Location = new System.Drawing.Point(8, 54);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(61, 20);
            this.Motivo.TabIndex = 2;
            this.Motivo.Text = "Motivo";
            // 
            // TB_motivo
            // 
            this.TB_motivo.Location = new System.Drawing.Point(12, 77);
            this.TB_motivo.Multiline = true;
            this.TB_motivo.Name = "TB_motivo";
            this.TB_motivo.Size = new System.Drawing.Size(231, 42);
            this.TB_motivo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origen";
            // 
            // TB_origen
            // 
            this.TB_origen.Enabled = false;
            this.TB_origen.Location = new System.Drawing.Point(503, 56);
            this.TB_origen.Name = "TB_origen";
            this.TB_origen.Size = new System.Drawing.Size(122, 20);
            this.TB_origen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // CB_destino
            // 
            this.CB_destino.FormattingEnabled = true;
            this.CB_destino.Location = new System.Drawing.Point(503, 82);
            this.CB_destino.Name = "CB_destino";
            this.CB_destino.Size = new System.Drawing.Size(121, 21);
            this.CB_destino.TabIndex = 7;
            // 
            // TB_articulo
            // 
            this.TB_articulo.Location = new System.Drawing.Point(76, 180);
            this.TB_articulo.Name = "TB_articulo";
            this.TB_articulo.Size = new System.Drawing.Size(167, 20);
            this.TB_articulo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Articulo";
            // 
            // BT_agregar
            // 
            this.BT_agregar.Location = new System.Drawing.Point(452, 168);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(83, 32);
            this.BT_agregar.TabIndex = 10;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.UseVisualStyleBackColor = true;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // BT_quitar
            // 
            this.BT_quitar.Location = new System.Drawing.Point(541, 168);
            this.BT_quitar.Name = "BT_quitar";
            this.BT_quitar.Size = new System.Drawing.Size(83, 32);
            this.BT_quitar.TabIndex = 11;
            this.BT_quitar.Text = "Quitar";
            this.BT_quitar.UseVisualStyleBackColor = true;
            // 
            // BT_guardar
            // 
            this.BT_guardar.Location = new System.Drawing.Point(237, 371);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(154, 63);
            this.BT_guardar.TabIndex = 12;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.UseVisualStyleBackColor = true;
            // 
            // Traspasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 453);
            this.Controls.Add(this.BT_guardar);
            this.Controls.Add(this.BT_quitar);
            this.Controls.Add(this.BT_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_articulo);
            this.Controls.Add(this.CB_destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_origen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_motivo);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.DT_fecha);
            this.Controls.Add(this.DG_datos);
            this.Name = "Traspasos";
            this.Text = "Traspasos";
            this.Load += new System.EventHandler(this.Traspasos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXISTENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DateTimePicker DT_fecha;
        private System.Windows.Forms.Label Motivo;
        private System.Windows.Forms.TextBox TB_motivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_destino;
        private System.Windows.Forms.TextBox TB_articulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.Button BT_quitar;
        private System.Windows.Forms.Button BT_guardar;
    }
}