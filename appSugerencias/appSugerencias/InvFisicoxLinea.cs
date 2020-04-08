using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class InvFisicoxLinea : Form
    {
        public InvFisicoxLinea()
        {
            InitializeComponent();
        }



        MySqlConnection con; //VARIABLE GLOBAL DE CONEXION A LA BD
        
        

        //LLENA EL COMBOBOX CON LAS LINEAS DE PRODUCTOS
        public void CargarLineas()
        {
            con = BDConexicon.conectar();

            MySqlCommand cmd = new MySqlCommand("SELECT linea FROM lineas ORDER BY linea", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_lineas.Items.Add(dr["linea"].ToString());
            }

            dr.Close();
           
        }
        //FIN LLENA EL COMBOBOX CON LAS LINEAS DE PRODUCTOS

        //CARGA LAS LINEA DE PRODUCTOS ENE L COMBOBOX AL INICIAR EL FORM
        private void InvFisicoxLinea_Load(object sender, EventArgs e)
        {
            CargarLineas();
        }
        //FIN CARGA LAS LINEA DE PRODUCTOS ENE L COMBOBOX AL INICIAR EL FORM


       ArrayList articulos = new ArrayList();
        ArrayList existencia = new ArrayList();
        string linea = "";


        
        public void Recalcular()
        {
           con = BDConexicon.conectar();
            
           
            //OBTENGO LAS CLAVES DE LOS ARTICULOS DE LA LINEA

            linea = CB_lineas.SelectedItem.ToString();
            MySqlCommand cmd = new MySqlCommand("SELECT articulo,descrip,existencia,costo_u FROM PRODS WHERE LINEA ='" + linea + "'", con);
        
            MySqlDataReader dr = cmd.ExecuteReader();
            int cant = 0;
            while (dr.Read())
            {
                cant = Convert.ToInt32(dr["existencia"].ToString());
                if (cant >0)
                {
                    articulos.Add(dr["articulo"].ToString());
                    DG1.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString(), dr["costo_u"].ToString(), "0", "0");

                }

            }
            dr.Close();


         
            int entrada = 0, salida = 0, cantidad = 0;
         


            //SE REALIZA EL RECALCULO SUMANDO LAS ENTRAS Y RESTANDO LAS SALIDAS QUE TENGA EL PRODUCTO

            MySqlDataReader dr1 = null;
            for (int i = 0; i < articulos.Count; i++)
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT cantidad,ent_sal FROM movsinv WHERE articulo='" + articulos[i] + "'", con);
                dr1 = cmd1.ExecuteReader();


                while (dr1.Read())
                {
                    if (dr1["ent_sal"].ToString().Equals("E"))
                    {
                        entrada += Convert.ToInt32(dr1["cantidad"].ToString());
                    }
                    else
                    {
                        salida += Convert.ToInt32(dr1["cantidad"].ToString());
                    }
                }

                dr1.Close();
                cantidad = entrada - salida;
                existencia.Add(cantidad);
                entrada = 0; salida = 0; cantidad = 0;
            }



            //COLOCO LA EXISTENCIA RECALCULADA DE CADA ARTICULO EN LA COLUMNA Existencia 
            for (int j = 0; j < articulos.Count; j++)
            {
                DG1.Rows[j].Cells[3].Value = existencia[j];
            }



            //MULTIPLICAR EL COSTO UNITARIO POR LA EXISTENCIA Y COLOCARLO EN LA COLUMNA TOTAL
            double costo = 0, total = 0;
            int ex = 0;

            for (int x = 0; x < articulos.Count; x++)
            {
                costo = Convert.ToDouble(DG1.Rows[x].Cells[2].Value);
                ex = Convert.ToInt32(DG1.Rows[x].Cells[3].Value);
                total = costo * ex;
                DG1.Rows[x].Cells[4].Value = total;

            }


            articulos.Clear();
            existencia.Clear();
            TB_mensaje.Text = "LINEA RECALCULADA";
            
        }

        public void Exportar()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A4000"].NumberFormat = "@";
            excel.Range["A2:E3"].Merge();
            excel.Range["A2"].Value = "ARTICULOS DE LA LINEA "+linea;
            excel.Range["A2"].Font.Bold = true;
            excel.Range["A2"].Font.Size = 20;
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG1.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG1.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG1.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

            TB_mensaje.Text = "ARTICULOS CON EXISTENCIA EXPORTADOS";

        }


        public void ArtenCero()
        {



            MySqlCommand update = new MySqlCommand("UPDATE prods SET existencia = 0, bloqueado=1 where linea ='" + linea+"'",con);
            update.ExecuteNonQuery();
            TB_mensaje.Text = "LINEA BLOQUEADA";

        }


        private void BT_recalcular_Click(object sender, EventArgs e)
        {

            Recalcular();

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ArtenCero();
        }

        private void CB_lineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DG1.Rows.Clear();
        }
    }
}
