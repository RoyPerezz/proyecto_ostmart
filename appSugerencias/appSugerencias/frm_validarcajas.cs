using System;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class frm_validarcajas : Form
    {
        public frm_validarcajas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void selectDatos(DataGridView grid)
        {


            DateTime Finicio = dtInicio.Value;
            DateTime Ffin = dtFin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);



            MySqlCommand cmd = new MySqlCommand("SELECT rd_formatocajeras.articulo, prods.descrip,rd_formatocajeras.cantidad, rd_formatocajeras.anomalia,rd_formatocajeras.usuario,rd_formatocajeras.fecha,rd_formatocajeras.hora FROM rd_formatocajeras INNER JOIN prods ON prods.ARTICULO=rd_formatocajeras.articulo  where rd_formatocajeras.fecha between '" + inicio + "'" + " and '" + fin + "'", BDConexicon.conectar());

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();

            adaptador.Fill(tb);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Aceptado";
            chk.Name = "checkbox";
            grid.Columns.Add(chk);

            grid.DataSource = tb;

            grid.Columns[0].Width = 50;
            grid.Columns[1].Width = 100;
            grid.Columns[2].Width = 200;
            grid.Columns[3].Width = 30;
            grid.Columns[4].Width = 150;
            grid.Columns[5].Width = 50;
            grid.Columns[6].Width = 100;
            grid.Columns[7].Width = 100;


          
        }

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectDatos(dgvCajas);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
