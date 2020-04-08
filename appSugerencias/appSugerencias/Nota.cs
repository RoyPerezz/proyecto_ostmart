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
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
        }

        private void Nota_Load(object sender, EventArgs e)
        {
            DG_Tabla.Columns[0].Width = 120;
            DG_Tabla.Columns[1].Width = 50;
            DG_Tabla.Columns[2].Width = 304;
        }
    }
}
