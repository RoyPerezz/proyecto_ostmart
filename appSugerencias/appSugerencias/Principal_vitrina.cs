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
    public partial class Principal_vitrina : Form
    {

        string usuario = "";
        string area = "";
        public Principal_vitrina(string usuario,string area)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.area = area;
        }

        private void Principal_vitrina_Load(object sender, EventArgs e)
        {

            if (area == "CAJAS" || area == "VITRINA" || area == "SISTEMAS")
            {
                Menu_existencias.Enabled = true;
            }
            else
            {
                Menu_existencias.Enabled = false;
            }

            if (area == "CAJAS" || area == "VITRINA" || area == "SISTEMAS")
            {
                Menu_entradas.Enabled = true;
            }
            else
            {
                Menu_entradas.Enabled = false;
            }

            LB_saludo.Text = "Bienvenid@ "+usuario;
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EntradaMercancia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EntradaMercancia();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Principal_vitrina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
