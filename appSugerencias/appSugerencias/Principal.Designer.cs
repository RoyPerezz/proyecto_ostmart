namespace appSugerencias
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.traspasosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmCreaTraspaso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmAplicaTraspaso = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitrinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorDeClavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONCENTRADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vITRINAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasVitrinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasPorLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPTiendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCostosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCostosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosExternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearConceptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarGastosExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitrinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasPorLineaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traspasosToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasPTiendasToolStripMenuItem,
            this.ventasPHoraToolStripMenuItem,
            this.vitrinaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // traspasosToolStripMenuItem
            // 
            this.traspasosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsmCreaTraspaso,
            this.toolsmAplicaTraspaso});
            this.traspasosToolStripMenuItem.Name = "traspasosToolStripMenuItem";
            this.traspasosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.traspasosToolStripMenuItem.Text = "Traspasos";
            this.traspasosToolStripMenuItem.Click += new System.EventHandler(this.traspasosToolStripMenuItem_Click);
            // 
            // toolsmCreaTraspaso
            // 
            this.toolsmCreaTraspaso.Name = "toolsmCreaTraspaso";
            this.toolsmCreaTraspaso.Size = new System.Drawing.Size(162, 22);
            this.toolsmCreaTraspaso.Text = "Crear Traspaso";
            this.toolsmCreaTraspaso.Click += new System.EventHandler(this.crearTraspasoToolStripMenuItem_Click);
            // 
            // toolsmAplicaTraspaso
            // 
            this.toolsmAplicaTraspaso.Name = "toolsmAplicaTraspaso";
            this.toolsmAplicaTraspaso.Size = new System.Drawing.Size(162, 22);
            this.toolsmAplicaTraspaso.Text = "Aplicar Traspaso";
            this.toolsmAplicaTraspaso.Click += new System.EventHandler(this.aplicarTraspasoToolStripMenuItem_Click);
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            this.ofertasToolStripMenuItem.Click += new System.EventHandler(this.ofertasToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadosDeCuentaToolStripMenuItem,
            this.reporteGeneralToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // estadosDeCuentaToolStripMenuItem
            // 
            this.estadosDeCuentaToolStripMenuItem.Name = "estadosDeCuentaToolStripMenuItem";
            this.estadosDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.estadosDeCuentaToolStripMenuItem.Text = "Estados de cuenta";
            this.estadosDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.estadosDeCuentaToolStripMenuItem_Click);
            // 
            // reporteGeneralToolStripMenuItem
            // 
            this.reporteGeneralToolStripMenuItem.Name = "reporteGeneralToolStripMenuItem";
            this.reporteGeneralToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.reporteGeneralToolStripMenuItem.Text = "Reporte general";
            this.reporteGeneralToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCompraToolStripMenuItem,
            this.existenciasPorProveedorToolStripMenuItem,
            this.generadorDeClavesToolStripMenuItem,
            this.cONCENTRADORToolStripMenuItem,
            this.ofertasVitrinasToolStripMenuItem,
            this.existenciasPorLineaToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cargarCompraToolStripMenuItem
            // 
            this.cargarCompraToolStripMenuItem.Name = "cargarCompraToolStripMenuItem";
            this.cargarCompraToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cargarCompraToolStripMenuItem.Text = "Cargar Compra";
            this.cargarCompraToolStripMenuItem.Click += new System.EventHandler(this.cargarCompraToolStripMenuItem_Click);
            // 
            // existenciasPorProveedorToolStripMenuItem
            // 
            this.existenciasPorProveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendasToolStripMenuItem,
            this.vitrinasToolStripMenuItem});
            this.existenciasPorProveedorToolStripMenuItem.Name = "existenciasPorProveedorToolStripMenuItem";
            this.existenciasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.existenciasPorProveedorToolStripMenuItem.Text = "Existencias por proveedor";
            // 
            // tiendasToolStripMenuItem
            // 
            this.tiendasToolStripMenuItem.Name = "tiendasToolStripMenuItem";
            this.tiendasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.tiendasToolStripMenuItem.Text = "Tiendas";
            this.tiendasToolStripMenuItem.Click += new System.EventHandler(this.tiendasToolStripMenuItem_Click);
            // 
            // vitrinasToolStripMenuItem
            // 
            this.vitrinasToolStripMenuItem.Name = "vitrinasToolStripMenuItem";
            this.vitrinasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.vitrinasToolStripMenuItem.Text = "Vitrinas";
            this.vitrinasToolStripMenuItem.Click += new System.EventHandler(this.vitrinasToolStripMenuItem_Click);
            // 
            // generadorDeClavesToolStripMenuItem
            // 
            this.generadorDeClavesToolStripMenuItem.Name = "generadorDeClavesToolStripMenuItem";
            this.generadorDeClavesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.generadorDeClavesToolStripMenuItem.Text = "Generador de Claves";
            this.generadorDeClavesToolStripMenuItem.Click += new System.EventHandler(this.generadorDeClavesToolStripMenuItem_Click);
            // 
            // cONCENTRADORToolStripMenuItem
            // 
            this.cONCENTRADORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tIENDAToolStripMenuItem,
            this.vITRINAToolStripMenuItem1});
            this.cONCENTRADORToolStripMenuItem.Name = "cONCENTRADORToolStripMenuItem";
            this.cONCENTRADORToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cONCENTRADORToolStripMenuItem.Text = "CONCENTRADOR";
            this.cONCENTRADORToolStripMenuItem.Click += new System.EventHandler(this.cONCENTRADORToolStripMenuItem_Click);
            // 
            // tIENDAToolStripMenuItem
            // 
            this.tIENDAToolStripMenuItem.Name = "tIENDAToolStripMenuItem";
            this.tIENDAToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tIENDAToolStripMenuItem.Text = "TIENDA";
            this.tIENDAToolStripMenuItem.Click += new System.EventHandler(this.tIENDAToolStripMenuItem_Click);
            // 
            // vITRINAToolStripMenuItem1
            // 
            this.vITRINAToolStripMenuItem1.Name = "vITRINAToolStripMenuItem1";
            this.vITRINAToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.vITRINAToolStripMenuItem1.Text = "VITRINA";
            this.vITRINAToolStripMenuItem1.Click += new System.EventHandler(this.vITRINAToolStripMenuItem1_Click);
            // 
            // ofertasVitrinasToolStripMenuItem
            // 
            this.ofertasVitrinasToolStripMenuItem.Name = "ofertasVitrinasToolStripMenuItem";
            this.ofertasVitrinasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ofertasVitrinasToolStripMenuItem.Text = "Ofertas Vitrinas";
            this.ofertasVitrinasToolStripMenuItem.Click += new System.EventHandler(this.ofertasVitrinasToolStripMenuItem_Click);
            // 
            // existenciasPorLineaToolStripMenuItem
            // 
            this.existenciasPorLineaToolStripMenuItem.Name = "existenciasPorLineaToolStripMenuItem";
            this.existenciasPorLineaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.existenciasPorLineaToolStripMenuItem.Text = "Existencias por Linea";
            this.existenciasPorLineaToolStripMenuItem.Click += new System.EventHandler(this.existenciasPorLineaToolStripMenuItem_Click);
            // 
            // ventasPTiendasToolStripMenuItem
            // 
            this.ventasPTiendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPTiendaToolStripMenuItem,
            this.reporteCostosToolStripMenuItem});
            this.ventasPTiendasToolStripMenuItem.Name = "ventasPTiendasToolStripMenuItem";
            this.ventasPTiendasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ventasPTiendasToolStripMenuItem.Text = "Admin";
            this.ventasPTiendasToolStripMenuItem.Click += new System.EventHandler(this.ventasPTiendasToolStripMenuItem_Click);
            // 
            // ventasPTiendaToolStripMenuItem
            // 
            this.ventasPTiendaToolStripMenuItem.Name = "ventasPTiendaToolStripMenuItem";
            this.ventasPTiendaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ventasPTiendaToolStripMenuItem.Text = "VentasPTienda";
            this.ventasPTiendaToolStripMenuItem.Click += new System.EventHandler(this.ventasPTiendaToolStripMenuItem_Click);
            // 
            // reporteCostosToolStripMenuItem
            // 
            this.reporteCostosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteCostosToolStripMenuItem1,
            this.gastosExternosToolStripMenuItem});
            this.reporteCostosToolStripMenuItem.Name = "reporteCostosToolStripMenuItem";
            this.reporteCostosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reporteCostosToolStripMenuItem.Text = "Reporte Costos";
            this.reporteCostosToolStripMenuItem.Click += new System.EventHandler(this.reporteCostosToolStripMenuItem_Click);
            // 
            // reporteCostosToolStripMenuItem1
            // 
            this.reporteCostosToolStripMenuItem1.Name = "reporteCostosToolStripMenuItem1";
            this.reporteCostosToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.reporteCostosToolStripMenuItem1.Text = "Reporte Costos";
            this.reporteCostosToolStripMenuItem1.Click += new System.EventHandler(this.reporteCostosToolStripMenuItem1_Click);
            // 
            // gastosExternosToolStripMenuItem
            // 
            this.gastosExternosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearConceptoToolStripMenuItem,
            this.registrarGastosExternoToolStripMenuItem});
            this.gastosExternosToolStripMenuItem.Name = "gastosExternosToolStripMenuItem";
            this.gastosExternosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gastosExternosToolStripMenuItem.Text = "Gastos Externos";
            // 
            // crearConceptoToolStripMenuItem
            // 
            this.crearConceptoToolStripMenuItem.Name = "crearConceptoToolStripMenuItem";
            this.crearConceptoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.crearConceptoToolStripMenuItem.Text = "Crear concepto";
            this.crearConceptoToolStripMenuItem.Click += new System.EventHandler(this.crearConceptoToolStripMenuItem_Click);
            // 
            // registrarGastosExternoToolStripMenuItem
            // 
            this.registrarGastosExternoToolStripMenuItem.Name = "registrarGastosExternoToolStripMenuItem";
            this.registrarGastosExternoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.registrarGastosExternoToolStripMenuItem.Text = "Registrar Gastos Externo";
            this.registrarGastosExternoToolStripMenuItem.Click += new System.EventHandler(this.registrarGastosExternoToolStripMenuItem_Click);
            // 
            // ventasPHoraToolStripMenuItem
            // 
            this.ventasPHoraToolStripMenuItem.Name = "ventasPHoraToolStripMenuItem";
            this.ventasPHoraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ventasPHoraToolStripMenuItem.Text = "Ventas P/Hora";
            this.ventasPHoraToolStripMenuItem.Click += new System.EventHandler(this.ventasPHoraToolStripMenuItem_Click);
            // 
            // vitrinaToolStripMenuItem
            // 
            this.vitrinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existenciasPorLineaToolStripMenuItem1});
            this.vitrinaToolStripMenuItem.Name = "vitrinaToolStripMenuItem";
            this.vitrinaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vitrinaToolStripMenuItem.Text = "Vitrina";
            // 
            // existenciasPorLineaToolStripMenuItem1
            // 
            this.existenciasPorLineaToolStripMenuItem1.Name = "existenciasPorLineaToolStripMenuItem1";
            this.existenciasPorLineaToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.existenciasPorLineaToolStripMenuItem1.Text = "Existencias por Linea";
            this.existenciasPorLineaToolStripMenuItem1.Click += new System.EventHandler(this.existenciasPorLineaToolStripMenuItem1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(81, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(37, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(45, 59);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(49, 13);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BD:";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(48, 75);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(34, 13);
            this.lblBD.TabIndex = 6;
            this.lblBD.Text = "Mysql";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "SOFTMART 1.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem traspasosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsmCreaTraspaso;
        private System.Windows.Forms.ToolStripMenuItem toolsmAplicaTraspaso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.ToolStripMenuItem estadosDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generadorDeClavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitrinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPTiendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONCENTRADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasVitrinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCostosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasPorLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitrinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasPorLineaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteCostosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gastosExternosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearConceptoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarGastosExternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vITRINAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
    }
}