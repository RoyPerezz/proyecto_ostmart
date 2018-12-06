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
        string Usuario="GABY";

        
        public Principal()
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
        }

        //public Principal(string usuario)
        //{
        //    InitializeComponent();
        //    Usuario = usuario;
        //    lblUsuario.Text = Usuario;
        //}





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
    }
}
