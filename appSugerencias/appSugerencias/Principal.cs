using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Principal : Form
    {
        string Usuario="";
        string Area;
       
        
        public Principal()
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            


        }

       

        public Principal(string usuario,string area)
        {
            InitializeComponent();
            Usuario = usuario;
            Area = area;
            lblUsuario.Text = Usuario;
            //repEtiquetasToolStripMenuItem.Enabled = false;

        }

        public static string optieneIp()
        {
            TextReader IP;
            IP = new StreamReader("IP.txt");
            string ipn = IP.ReadLine();
            IP.Close();
            return ipn;
        }

        public static string optieneBd()
        {
            TextReader BD;
            BD = new StreamReader("BD.txt");
            string bdn = BD.ReadLine();
            BD.Close();
            return bdn;
        }




        private void nuevaSugerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sugerencias form = new frm_Sugerencias();
            form.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirReporte imp = new ImprimirReporte();
            imp.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloSinVentas asv = new ArticuloSinVentas();
            asv.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ReporteASinVentas rasv = new frm_ReporteASinVentas();
            rasv.Show();
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login rasv = new frm_Login();
            rasv.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {




            if (Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "SUPER")
            {
                aplicarTraspasoToolStripMenuItem.Enabled = true;
            }
            else
            {
                aplicarTraspasoToolStripMenuItem.Enabled = false;
            }


            if (Area == "BODEGA" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                creaTraspasoToolStripMenuItem.Enabled = true;
            }
            else
            {
                creaTraspasoToolStripMenuItem.Enabled = false;
            }


            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "TRASPASO")
            {
                comprasToolStripMenuItem.Enabled = true;
            }
            else
            {
                comprasToolStripMenuItem.Enabled = false;


            }

            if (Area == "ENC CAJAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "GERENTE")
            {
                comisionesToolStripMenuItem.Enabled = true;
            }
            else
            {
                comisionesToolStripMenuItem.Enabled = false;


            }

            if (Area == "ENC CAJAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "GERENTE" || Area == "CXPAGAR")
            {
                reportesToolStripMenuItem.Enabled = true;
            }
            else
            {
                reportesToolStripMenuItem.Enabled = false;


            }

            if (Area == "ENC CAJAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "GERENTE")
            {
                pisoVentaToolStripMenuItem.Enabled = true;
            }
            else
            {
                pisoVentaToolStripMenuItem.Enabled = false;


            }

            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "TRASPASOS")
            {
                pedidosToolStripMenuItem.Enabled = true;
            }
            else
            {
                pedidosToolStripMenuItem.Enabled = false;


            }

            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "TRASPASO")
            {
                vitrinaToolStripMenuItem.Enabled = true;
            }
            else
            {
                vitrinaToolStripMenuItem.Enabled = false;


            }


            if (Area == "PAGOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "CXPAGAR")
            {
                cuentasPPagarToolStripMenuItem.Enabled = true;
            }
            else
            {
                cuentasPPagarToolStripMenuItem.Enabled = false;


            }

            if (Area == "INVENTARIOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                inventarioToolStripMenuItem.Enabled = true;
            }
            else
            {
                inventarioToolStripMenuItem.Enabled = false;


            }

            if (Area == "FINANZAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                finanzasToolStripMenuItem.Enabled = true;
            }
            else
            {
                finanzasToolStripMenuItem.Enabled = false;


            }

            if ( Area == "SISTEMAS" || Area == "ADMON GRAL")
            {
                gerenciaToolStripMenuItem.Enabled = true;
            }
            else
            {
                gerenciaToolStripMenuItem.Enabled = false;


            }
            



            string IP = optieneIp();
            string BD = optieneBd();

            lblBD.Text = BD;
            lblIP.Text = IP;

        }

        public void ejecutar (string dato)
        {
            lblUsuario.Text = dato;
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
        }

        private void calificacionescomisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificacionescs cal = new Calificacionescs();
            cal.Show();
        }

        private void formatoCajeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void formatoCajerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FormatoCajera c = new frm_FormatoCajera(Usuario);
            c.Show();
        }

        private void validarFormatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_validarcajas v= new frm_validarcajas();
            v.Show();
        }

        private void reportesDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rp_pagocomisiones rp = new Rp_pagocomisiones();
            rp.Show();
        }

        private void pagoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoComisiones pc = new PagoComisiones();
            pc.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void traspasosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void aplicarTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TraspasoTiendas);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new TraspasoTiendas(Usuario);
        //    frm.Show();

        //    //TraspasoTiendas appTras = new TraspasoTiendas(Usuario);
        //    //appTras.Show();
        //}

        //private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Existencias);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new Existencias(Usuario,Area);
        //    frm.Show();
        //}

        //private void crearTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CotizacionTraspaso);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new CotizacionTraspaso(Usuario);
        //    frm.Show();

        //    //CotizacionTraspaso traspaso = new CotizacionTraspaso(Usuario);
        //    //traspaso.Show();
        //}

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //se localiza el formulario buscandolo entre los forms abiertos 
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            //if (frm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    frm.BringToFront();
            //    return;
            //}

            ////sino existe la instancia se crea una nueva
            //frm = new CuentasXPagar();
            //frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //menuStrip1.BackColor = Color.LightSteelBlue;
        }

        //private void estadosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new CuentasXPagar();
        //    frm.Show();
        //}

        //private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //CREA UN REPORTE DE LOS SALDOS DE TODOS LOS PROVEEDORES EN CIERTA SUCURSAL

        //    Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RPT_SaldoProveedores);

        //    if (frm2 != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm2.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm2 = new RPT_SaldoProveedores();
        //    frm2.Show();
        //}

        //private void datagridsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExistenciaXProveedor);

        //    if (frm3 != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm3.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm3 = new ExistenciaXProveedor();
        //    frm3.Show();
        //}

        //private void elQueVaASerElBuenoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

        //    if (frm3 != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm3.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm3 = new ExProductosProveedor();
        //    frm3.Show();
        //}

       

        //private void cargarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Compras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_Compras(Usuario);
        //    frm.Show();

        //}

       

        

        //private void generadorDeClavesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GenClaves);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new GenClaves();
        //    frm.Show();

        //}

        private void tiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

            if (frm3 != null)
            {
                //si la instancia existe la pongo en primer plano
                frm3.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm3 = new ExProductosProveedor();
            frm3.Show();
        }

        //private void vitrinasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EXP_vitrina);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new EXP_vitrina();
        //    frm.Show();
        //}

        private void ventasPTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cONCENTRADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ofertasVitrinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExistenciasVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ExistenciasVitrina();
            frm.Show();
        }

        private void ventasPTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasxTienda);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasxTienda();
            frm.Show();
        }

        //private void reporteCostosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void existenciasPorLineaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_existXlinea);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new form_existXlinea();
        //    frm.Show();
        //}

        //private void ventasPHoraToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_ventasxhora();
        //    frm.Show();
        //}

        //private void existenciasPorLineaToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_ExistVitrina);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new form_ExistVitrina();
        //    frm.Show();
        //}

        //private void reporteCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_costos);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_costos();
        //    frm.Show();
        //}

        //private void crearConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CreaGastosExterno);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_CreaGastosExterno();
        //    frm.Show();
        //}

        //private void registrarGastosExternoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_GastosExternos();
        //    frm.Show();
        //}

        //private void tIENDAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Concentrador);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new Concentrador();
        //    frm.Show();
        //}

        //private void vITRINAToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ConcentradorVitrina);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_ConcentradorVitrina();
        //    frm.Show();
        //}

        //private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_pedido);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_pedido();
        //    frm.Show();

        //}

        //private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void calculoDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagoComisiones);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new PagoComisiones();
        //    frm.Show();
        //}

        //private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Calificacionescs);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new Calificacionescs();
        //    frm.Show();
        //}

        //private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void altabajaAsesorasDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is registroAsesoras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new registroAsesoras();
        //    frm.Show();
        //}

        //private void comisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesAsesoras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new ComisionesAsesoras();
        //    frm.Show();
        //}

        //private void totalComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TotalComisionesAsesoras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new TotalComisionesAsesoras();
        //    frm.Show();
        //}

        //private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

          
          
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Sugerencias);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva

        //    //frm = new Sugerencias();
        //    //frm.Show();
        //    Sugerencias sug = new Sugerencias();
        //    sug.LB_cajera.Text = lblUsuario.Text;
        //    sug.Show();
        //}

        //private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Etiquetas);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    Etiquetas et = new Etiquetas();
        //    et.LB_cajera.Text = lblUsuario.Text;
        //    et.Show();
        //    //sino existe la instancia se crea una nueva
        //    //frm = new Etiquetas();
        //    //frm.Show();
        //}

        //private void sugerenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteSug);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new ReporteSug();
        //    frm.Show();
        //}

        //private void repEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepEtiquetas);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new RepEtiquetas();
        //    frm.Show();
        //}

        //private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void inventarioFisicoToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is InvFisicoxLinea);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new InvFisicoxLinea();
        //    frm.Show();
        //}
        // =========================================================================================NUEVO MENU===============================//
        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Existencias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Existencias(Usuario, Area);
            frm.Show();
        }

        private void creaTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CotizacionTraspaso);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CotizacionTraspaso(Usuario);
            frm.Show();
        }

        private void aplicarTraspasoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TraspasoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new TraspasoTiendas(Usuario);
            frm.Show();
        }

        private void cargarCompraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Compras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_Compras(Usuario);
            frm.Show();
        }

        private void generadorClavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GenClaves);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new GenClaves();
            frm.Show();
        }

        private void concentradorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           // se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Concentrador);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Concentrador();
            frm.Show();
        }

        private void existenciaProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

            if (frm3 != null)
            {
                //si la instancia existe la pongo en primer plano
                frm3.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm3 = new ExProductosProveedor();
            frm3.Show();
        }

        private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Sugerencias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva

            //frm = new Sugerencias();
            //frm.Show();
            Sugerencias sug = new Sugerencias();
            sug.LB_cajera.Text = lblUsuario.Text;
            sug.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Calificacionescs);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Calificacionescs();
            frm.Show();
        }

        private void calculoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagoComisiones);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PagoComisiones();
            frm.Show();
        }

        private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Etiquetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            Etiquetas et = new Etiquetas();
            et.LB_cajera.Text = lblUsuario.Text;
            et.Show();
         
        }

        private void repSugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteSug);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteSug();
            frm.Show();
        }

        private void repEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepEtiquetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepEtiquetas();
            frm.Show();
        }

        private void altaBajaAsesoraVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is registroAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new registroAsesoras();
            frm.Show();
        }

        private void comisionesDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesAsesoras();
            frm.Show();
        }

        private void totalComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TotalComisionesAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new TotalComisionesAsesoras();
            frm.Show();
        }

        private void existenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExistenciasVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ExistenciasVitrina();
            frm.Show();
        }

        private void concentradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ConcentradorVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ConcentradorVitrina();
            frm.Show();
        }

        private void existenciasPProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EXP_vitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EXP_vitrina();
            frm.Show();
        }

        private void existenciasPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_ExistVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new form_ExistVitrina();
            frm.Show();
        }

        private void reporteGeneralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RPT_SaldoProveedores);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            //frm = new RPT_SaldoProveedores();
            //frm.Show();

            RPT_SaldoProveedores repor = new RPT_SaldoProveedores();
            repor.area = Area;
            repor.Show();
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasXPagar();
            frm.Show();
        }

        private void ventasPTiendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasxTienda);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasxTienda();
            frm.Show();
        }

        private void reporteCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_costos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_costos();
            frm.Show();
        }

        private void crearConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CreaGastosExterno);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_CreaGastosExterno();
            frm.Show();
        }

        private void registrarConceptoExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos(Usuario);
            frm.Show();
        }

        private void transaccionesPTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ventasxhora();
            frm.Show();
        }

        private void existenciaPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_existXlinea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new form_existXlinea();
            frm.Show();
        }

        private void cuentasPPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasBancarias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasBancarias();
            frm.Show();
        }

        private void pagosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ////se localiza el formulario buscandolo entre los forms abiertos
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Abonos);

            //if (frm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    frm.BringToFront();
            //    return;
            //}

            ////sino existe la instancia se crea una nueva
            //frm = new Abonos();
            //frm.Show();
        }

        private void pagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            //frm = new Rep_pagoproveedores();
            //frm.Show();
            Rep_pagoproveedores rep = new Rep_pagoproveedores(lblUsuario.Text);
            rep.Show();
        }

        private void gastosxDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepGastosxDia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepGastosxDia();
            frm.Show();
        }

        private void cuentasBancariasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasBancariasOS);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasBancariasOS();
            frm.Show();
        }

        private void depositoACuentasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RetirarEfectivoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RetirarEfectivoTiendas();
            frm.Show();
        }

        private void repCajaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_CajaGral);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_CajaGral();
            frm.Show();
        }



        //private void ventasPTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasxTienda);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new VentasxTienda();
        //    frm.Show();
        //}

        //#################### PASA EL USUARIO A AL FORM ETIQUETAS ############################################################


    }
}
