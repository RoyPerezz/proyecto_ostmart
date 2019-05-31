using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace appSugerencias
{
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
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

        private void Principal2_Load(object sender, EventArgs e)
        {
            //lblBD.Text = optieneBd();
            //lblIP.Text = optieneIp();
        }

        private void verificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Verificador);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_Verificador();
            frm.Show();
        }

        private void lblBD_Click(object sender, EventArgs e)
        {

        }

        private void kARDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_kardex APP = new frm_kardex();
            //APP.Show();

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_kardex);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_kardex();
            frm.Show();
        }

        private void showMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ip: "+ optieneIp()+Environment.NewLine +"BD: "+ optieneBd());
        }
    }
}
