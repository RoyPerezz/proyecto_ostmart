namespace appSugerencias
{
    partial class registroAsesoras
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
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_puesto = new System.Windows.Forms.ComboBox();
            this.BT_agregar = new System.Windows.Forms.Button();
            this.BT_eliminar = new System.Windows.Forms.Button();
            this.BT_modificar = new System.Windows.Forms.Button();
            this.BT_buscar = new System.Windows.Forms.Button();
            this.DG_asesoras = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_id = new System.Windows.Forms.TextBox();
            this.CB_depto = new System.Windows.Forms.ComboBox();
            this.TB_linea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_asesoras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // TB_usuario
            // 
            this.TB_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_usuario.Location = new System.Drawing.Point(16, 42);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(156, 31);
            this.TB_usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TB_nombre
            // 
            this.TB_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nombre.Location = new System.Drawing.Point(178, 42);
            this.TB_nombre.Name = "TB_nombre";
            this.TB_nombre.Size = new System.Drawing.Size(197, 31);
            this.TB_nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // TB_apellidos
            // 
            this.TB_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_apellidos.Location = new System.Drawing.Point(383, 42);
            this.TB_apellidos.Name = "TB_apellidos";
            this.TB_apellidos.Size = new System.Drawing.Size(283, 31);
            this.TB_apellidos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puesto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CB_puesto
            // 
            this.CB_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_puesto.FormattingEnabled = true;
            this.CB_puesto.Location = new System.Drawing.Point(385, 103);
            this.CB_puesto.Name = "CB_puesto";
            this.CB_puesto.Size = new System.Drawing.Size(281, 33);
            this.CB_puesto.TabIndex = 9;
            this.CB_puesto.SelectedIndexChanged += new System.EventHandler(this.CB_puesto_SelectedIndexChanged);
            // 
            // BT_agregar
            // 
            this.BT_agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_agregar.ForeColor = System.Drawing.Color.White;
            this.BT_agregar.Location = new System.Drawing.Point(18, 162);
            this.BT_agregar.Name = "BT_agregar";
            this.BT_agregar.Size = new System.Drawing.Size(98, 42);
            this.BT_agregar.TabIndex = 10;
            this.BT_agregar.Text = "Agregar";
            this.BT_agregar.UseVisualStyleBackColor = false;
            this.BT_agregar.Click += new System.EventHandler(this.BT_agregar_Click);
            // 
            // BT_eliminar
            // 
            this.BT_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar.ForeColor = System.Drawing.Color.White;
            this.BT_eliminar.Location = new System.Drawing.Point(564, 162);
            this.BT_eliminar.Name = "BT_eliminar";
            this.BT_eliminar.Size = new System.Drawing.Size(98, 42);
            this.BT_eliminar.TabIndex = 11;
            this.BT_eliminar.Text = "Eliminar";
            this.BT_eliminar.UseVisualStyleBackColor = false;
            this.BT_eliminar.Click += new System.EventHandler(this.BT_eliminar_Click);
            // 
            // BT_modificar
            // 
            this.BT_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_modificar.ForeColor = System.Drawing.Color.White;
            this.BT_modificar.Location = new System.Drawing.Point(377, 162);
            this.BT_modificar.Name = "BT_modificar";
            this.BT_modificar.Size = new System.Drawing.Size(98, 42);
            this.BT_modificar.TabIndex = 12;
            this.BT_modificar.Text = "Modificar";
            this.BT_modificar.UseVisualStyleBackColor = false;
            this.BT_modificar.Click += new System.EventHandler(this.BT_modificar_Click);
            // 
            // BT_buscar
            // 
            this.BT_buscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BT_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_buscar.ForeColor = System.Drawing.Color.White;
            this.BT_buscar.Location = new System.Drawing.Point(206, 162);
            this.BT_buscar.Name = "BT_buscar";
            this.BT_buscar.Size = new System.Drawing.Size(98, 42);
            this.BT_buscar.TabIndex = 13;
            this.BT_buscar.Text = "Buscar";
            this.BT_buscar.UseVisualStyleBackColor = false;
            this.BT_buscar.Click += new System.EventHandler(this.BT_buscar_Click);
            // 
            // DG_asesoras
            // 
            this.DG_asesoras.AllowUserToAddRows = false;
            this.DG_asesoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_asesoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.USUARIO,
            this.NOMBRE,
            this.APELLIDOS,
            this.DEPARTAMENTO,
            this.PUESTO});
            this.DG_asesoras.Location = new System.Drawing.Point(18, 232);
            this.DG_asesoras.Name = "DG_asesoras";
            this.DG_asesoras.Size = new System.Drawing.Size(644, 125);
            this.DG_asesoras.TabIndex = 14;
            this.DG_asesoras.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DG_asesoras_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
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
            // TB_id
            // 
            this.TB_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_id.Location = new System.Drawing.Point(145, 162);
            this.TB_id.Name = "TB_id";
            this.TB_id.Size = new System.Drawing.Size(27, 31);
            this.TB_id.TabIndex = 15;
            this.TB_id.Visible = false;
            // 
            // CB_depto
            // 
            this.CB_depto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_depto.FormattingEnabled = true;
            this.CB_depto.Location = new System.Drawing.Point(18, 104);
            this.CB_depto.Name = "CB_depto";
            this.CB_depto.Size = new System.Drawing.Size(357, 32);
            this.CB_depto.TabIndex = 16;
            this.CB_depto.SelectedIndexChanged += new System.EventHandler(this.CB_depto_SelectedIndexChanged);
            // 
            // TB_linea
            // 
            this.TB_linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_linea.Location = new System.Drawing.Point(310, 165);
            this.TB_linea.Name = "TB_linea";
            this.TB_linea.Size = new System.Drawing.Size(63, 31);
            this.TB_linea.TabIndex = 17;
            this.TB_linea.Visible = false;
            // 
            // registroAsesoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(678, 381);
            this.Controls.Add(this.TB_linea);
            this.Controls.Add(this.CB_depto);
            this.Controls.Add(this.TB_id);
            this.Controls.Add(this.DG_asesoras);
            this.Controls.Add(this.BT_buscar);
            this.Controls.Add(this.BT_modificar);
            this.Controls.Add(this.BT_eliminar);
            this.Controls.Add(this.BT_agregar);
            this.Controls.Add(this.CB_puesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_apellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_usuario);
            this.Controls.Add(this.label1);
            this.Name = "registroAsesoras";
            this.Text = "Alta/Baja asesoras de venta";
            this.Load += new System.EventHandler(this.registroAsesoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_asesoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_puesto;
        private System.Windows.Forms.Button BT_agregar;
        private System.Windows.Forms.Button BT_eliminar;
        private System.Windows.Forms.Button BT_modificar;
        private System.Windows.Forms.Button BT_buscar;
        private System.Windows.Forms.DataGridView DG_asesoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.TextBox TB_id;
        private System.Windows.Forms.ComboBox CB_depto;
        private System.Windows.Forms.TextBox TB_linea;
    }
}