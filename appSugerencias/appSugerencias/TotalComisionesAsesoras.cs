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
    public partial class TotalComisionesAsesoras : Form
    {
        public TotalComisionesAsesoras()
        {
            InitializeComponent();
        }


        ArrayList usuarios = new ArrayList();
        MySqlConnection con;
        private void BT_importar_Click(object sender, EventArgs e)
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            con = BDConexicon.conectar();

            //TRAE LOS NOMBRES DE LOS USUARIOS Y LOS PONE EN EL DATAGRID
            MySqlCommand cmd0 = new MySqlCommand("SELECT distinct usuario from rd_comisionneta_asesoras order by usuario",con);
            MySqlDataReader dr0 = cmd0.ExecuteReader();
           
            while (dr0.Read())
            {
                DG_comisiones.Rows.Add(dr0["usuario"].ToString());

            }
            dr0.Close();


            //OBTENGO LOS USUARIOS EN EL DATAGRID
            for (int col= 0;  col<=0; col++)
            {
                for (int fila = 0; fila < DG_comisiones.RowCount; fila++)
                {
                    usuarios.Add(DG_comisiones.Rows[fila].Cells[col].Value.ToString());
                }
            }

            //CALCULA LA SUMA TOTAL DE LA COMISION DE LA SEMANA
            string cn = "";
            int x = 0;
            MySqlDataReader dr1 = null;
            for (int lista = 0; lista < usuarios.Count; lista++)
            {
                MySqlCommand cmd1 = new MySqlCommand("select sum(cn) as total from rd_comisionneta_asesoras where usuario='"+usuarios[lista]+"' and fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' order by usuario", con);
                 dr1= cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    //cn = dr1["total"].ToString();
                    DG_comisiones.Rows[x].Cells[3].Value= dr1["total"].ToString();
                    x++;
                }
                dr1.Close();
            }
            
           

            MySqlCommand cmd2 = new MySqlCommand("SELECT  distinct departamento, puesto  from rd_comisionneta_asesoras where fecha between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'",con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            int i = 0;
          
            while (dr2.Read())
            {
               // DG_datos.Rows.Add(dr2["departamento"].ToString(),dr2["puesto"].ToString(),cn);

                DG_comisiones.Rows[i].Cells[1].Value = dr2["departamento"].ToString();
                DG_comisiones.Rows[i].Cells[2].Value = dr2["puesto"].ToString();
                //DG_datos.Rows[i].Cells[3].Value = cn;
                i++;
              
            }
            dr2.Close();
            con.Close();
            LLenarCeros();
        }

        private void TotalComisionesAsesoras_Load(object sender, EventArgs e)
        {
            DG_comisiones.Columns[1].Width= 180;
            DG_comisiones.Columns[2].Width = 100;
            DG_comisiones.Columns[3].Width = 85;
            DG_comisiones.Columns[4].Width = 80;
            DG_comisiones.Columns[5].Width = 80;
            DG_comisiones.Columns[6].Width = 80;
            DG_comisiones.Columns[7].Width = 80;
            DG_comisiones.Columns[8].Width = 80;
            DG_comisiones.Columns[9].Width = 80;
            DG_comisiones.Columns[10].Width = 85;
            DG_comisiones.Columns[11].Width = 80;
            DG_comisiones.Columns[12].Width = 85;
            DG_comisiones.Columns[13].Width = 80;
            DG_comisiones.Columns[14].Width = 80;
            DG_comisiones.Columns[15].Width = 80;
            DG_comisiones.Columns[16].Width = 80;


            LLenarCeros();
        }


        public void LLenarCeros()
        {
            for (int rFilas = 0; rFilas < DG_comisiones.RowCount; rFilas++)
            {
                for (int rCol = 4; rCol < DG_comisiones.ColumnCount; rCol++)
                {
                    DG_comisiones.Rows[rFilas].Cells[rCol].Value ="0";
                }
            }
        }

      

        public void ExportarExcel()
        {
            DateTime F_ini, F_fin;
            string inicio = "", fin = "";

            F_ini = DT_inicio.Value;
            F_fin = DT_fin.Value;

            inicio = F_ini.ToLongDateString();
            fin = F_fin.ToLongDateString();


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_comisiones.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_comisiones.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_comisiones.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }

            excel.Cells.Range["A4:J4"].Merge();
            excel.Cells.Range["A4"].Value = "COMISIONES DEL    " + inicio.ToUpper() + "   AL    " + fin.ToUpper();
            excel.Cells.Range["A5:Q25"].Font.Size = 9;
            excel.Cells.Range["D6:Q25"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["A30:B30"].Merge();
            excel.Cells.Range["A30"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["A30"].Value = "Total a pagar "+TB_total.Text;



            excel.Visible = true;
        }


        private void BT_exportar_Click(object sender, EventArgs e)
        {
           
        }

        double suma = 0;
        int ceros = 0, reportes = 0,importe=0;

        private void BT_exportar_Click_1(object sender, EventArgs e)
        {
            ExportarExcel();
        }







        int etiquetas = 0, ofertas = 0, sonrisa = 0, atencion = 0, reparacion = 0, orden = 0, sugerencias = 0, robos = 0, resultados = 0, extra = 0;
        double totalComisiones = 0;
        private void BT_calcular_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < DG_comisiones.RowCount; i++)
            {
                importe = Convert.ToInt32(DG_comisiones.Rows[i].Cells[3].Value);
                etiquetas = Convert.ToInt32(DG_comisiones.Rows[i].Cells[4].Value);
                ofertas  = Convert.ToInt32(DG_comisiones.Rows[i].Cells[5].Value);
                sonrisa = Convert.ToInt32(DG_comisiones.Rows[i].Cells[6].Value);
                atencion = Convert.ToInt32(DG_comisiones.Rows[i].Cells[7].Value);
                reparacion = Convert.ToInt32(DG_comisiones.Rows[i].Cells[8].Value);
                orden = Convert.ToInt32(DG_comisiones.Rows[i].Cells[9].Value);
                sugerencias = Convert.ToInt32(DG_comisiones.Rows[i].Cells[10].Value);
                robos = Convert.ToInt32(DG_comisiones.Rows[i].Cells[11].Value);
                resultados = Convert.ToInt32(DG_comisiones.Rows[i].Cells[12].Value);
                extra = Convert.ToInt32(DG_comisiones.Rows[i].Cells[13].Value);
                ceros = Convert.ToInt32(DG_comisiones.Rows[i].Cells[14].Value);
                reportes = Convert.ToInt32(DG_comisiones.Rows[i].Cells[15].Value);

                suma = ((importe+etiquetas + ofertas + sonrisa + atencion + reparacion + orden + sugerencias + robos + resultados + extra) - ceros) - reportes;
                DG_comisiones.Rows[i].Cells[16].Value = Convert.ToString(suma);

                totalComisiones = totalComisiones + suma;

                

                TB_total.Text = Convert.ToString(String.Format("{0:0.##}", totalComisiones.ToString("C")));
            }
        }
           
          

            
    }
}
