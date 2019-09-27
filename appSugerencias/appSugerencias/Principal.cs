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
            if (Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "ADMON GRAL")
            {
                toolsmAplicaTraspaso.Enabled = true;
            }
            else
            {
                toolsmAplicaTraspaso.Enabled = false;
            }


            if (Area == "BODEGA" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                toolsmCreaTraspaso.Enabled = true;
            }
            else
            {
                toolsmCreaTraspaso.Enabled = false;
            }

            if (Area == "PAGOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "CXPAGAR" || Area == "ADMON GRAL")
            {
               pagosToolStripMenuItem.Enabled = true;
            }
            else
            {
                pagosToolStripMenuItem.Enabled = false;
            }

            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                comprasToolStripMenuItem.Enabled = true;
            }
            else
            {
                comprasToolStripMenuItem.Enabled = false;
            }



            if ( Area == "ADMON GRAL")
            {
                ventasPTiendasToolStripMenuItem.Enabled = true;
            }
            else
            {
                ventasPTiendasToolStripMenuItem.Enabled = false;
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

        private void aplicarTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
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

            //TraspasoTiendas appTras = new TraspasoTiendas(Usuario);
            //appTras.Show();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
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
            frm = new Existencias(Usuario,Area);
            frm.Show();
        }

        private void crearTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
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

            //CotizacionTraspaso traspaso = new CotizacionTraspaso(Usuario);
            //traspaso.Show();
        }

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

        private void estadosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CREA UN REPORTE DE LOS SALDOS DE TODOS LOS PROVEEDORES EN CIERTA SUCURSAL

            Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RPT_SaldoProveedores);

            if (frm2 != null)
            {
                //si la instancia existe la pongo en primer plano
                frm2.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm2 = new RPT_SaldoProveedores();
            frm2.Show();
        }

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

       

        private void cargarCompraToolStripMenuItem_Click(object sender, EventArgs e)
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

       

        

        private void generadorDeClavesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void vitrinasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ventasPTiendasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cONCENTRADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
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


    }
}
