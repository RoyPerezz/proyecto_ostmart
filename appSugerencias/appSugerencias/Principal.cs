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
        public Principal()
        {
            InitializeComponent();
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
    }
}
