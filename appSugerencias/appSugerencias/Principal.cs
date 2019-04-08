using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

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
            if (Area == "TRASPASOS" || Area == "SISTEMAS")
            {
                toolsmAplicaTraspaso.Enabled = true;
            }
            else
            {
                toolsmAplicaTraspaso.Enabled = false;
            }


            if (Area == "BODEGA" || Area == "SISTEMAS" || Area == "SUPERVICION")
            {
                toolsmCreaTraspaso.Enabled = true;
            }
            else
            {
                toolsmCreaTraspaso.Enabled = false;
            }





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
            frm = new TraspasoTiendas();
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
            frm = new Existencias();
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
            frm = new CotizacionTraspaso();
            frm.Show();

            //CotizacionTraspaso traspaso = new CotizacionTraspaso(Usuario);
            //traspaso.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentasXPagar cuentas = new CuentasXPagar();
            cuentas.Show();
        }
    }
}
