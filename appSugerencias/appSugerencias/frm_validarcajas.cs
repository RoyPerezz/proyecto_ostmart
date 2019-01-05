using System;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
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

        public void selectDatos()
        {


            DateTime Finicio = dtInicio.Value;
            DateTime Ffin = dtFin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);



            MySqlCommand cmd = new MySqlCommand("SELECT rd_formatocajeras.id ,rd_formatocajeras.articulo, prods.descrip,rd_formatocajeras.cantidad, rd_formatocajeras.anomalia,rd_formatocajeras.usuario,rd_formatocajeras.fecha,rd_formatocajeras.hora FROM rd_formatocajeras INNER JOIN prods ON prods.ARTICULO=rd_formatocajeras.articulo  where rd_formatocajeras.fecha between '" + inicio + "'" + " and '" + fin + "' and validado='0'", BDConexicon.conectar());

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            adaptador.Fill(dt);

            dgvCajas.Rows.Clear();
          
            foreach(DataRow item in dt.Rows)
            {
                int n = dgvCajas.Rows.Add();
                dgvCajas.Rows[n].Cells[0].Value = false;
                dgvCajas.Rows[n].Cells[1].Value = item["id"].ToString();
                dgvCajas.Rows[n].Cells[2].Value = item["articulo"].ToString();
                dgvCajas.Rows[n].Cells[3].Value = item["descrip"].ToString();
                dgvCajas.Rows[n].Cells[4].Value = item["cantidad"].ToString();
                dgvCajas.Rows[n].Cells[5].Value = item["anomalia"].ToString();
                dgvCajas.Rows[n].Cells[6].Value = item["usuario"].ToString();
                dgvCajas.Rows[n].Cells[7].Value = item["fecha"].ToString();
                dgvCajas.Rows[n].Cells[8].Value = item["hora"].ToString();
            }

          
        }

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvCajas.Rows)
            {


                if(Convert.ToBoolean(item.Cells[0].Value))
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE rd_formatocajeras SET validado='1' WHERE  id='" +item.Cells[1].Value.ToString()+"'", BDConexicon.conectar());
                    cmd.ExecuteNonQuery();

                }


            }
            selectDatos();
            MessageBox.Show("Realizado");
        }

        private void frm_validarcajas_Load(object sender, EventArgs e)
        {

        }
    }
}
