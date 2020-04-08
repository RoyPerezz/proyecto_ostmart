using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Collections;

namespace appSugerencias
{
    public partial class RepEtiquetas : Form
    {
        public RepEtiquetas()
        {
            InitializeComponent();
        }

        ArrayList usuarios = new ArrayList();

     


        //###################################### SUMA LAS CANTIDAD DE ETIQUETAS #####################################################
        int ceros = 0;
        int sinEtiqueta = 0;
        int borrosa = 0;
        int total = 0;
        public void SumarEtiquetas()
        {
          

            for (int i = 0; i < DG_etiquetas.Rows.Count; i++)
            {
                ceros += Convert.ToInt32(DG_etiquetas.Rows[i].Cells[3].Value);
            }

          

            for (int j = 0; j < DG_etiquetas.Rows.Count; j++)
            {
                sinEtiqueta += Convert.ToInt32(DG_etiquetas.Rows[j].Cells[4].Value);
            }

           

            for (int k = 0; k < DG_etiquetas.Rows.Count; k++)
            {
                borrosa += Convert.ToInt32(DG_etiquetas.Rows[k].Cells[5].Value);
            }

            total = ceros + sinEtiqueta + borrosa;

        }

        private void RepEtiquetas_Load(object sender, EventArgs e)
        {
            
        }


       


        int count = 0;
        private void BT_Exportar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.conectar();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            ArrayList cajeras = new ArrayList();

         
            //OBTENER EL NOMBRE DE LAS CAJERAS QUE CAPTURARON ETIQUETAS EN MAL ESTADO
            MySqlCommand cmd = new MySqlCommand("SELECT  DISTINCT cajera FROM rd_etiquetas WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            //LAS CAJERAS SE GUARDAN EN EL ARREGLO CAJERAS
            while (dr.Read())
            {
                cajeras.Add(dr["cajera"].ToString());
            }
            dr.Close();

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Worksheet hoja = null;//DECLARO UNA HOJA DE EXCEL

      
            try
            {//RELLENO EL DATAGRID CON LOS DATOS DE LAS ETIQUETAS QUE LAS CAJERAS HAYAN CAPTURADO, RECORRO ESE DATAGRID Y LO EXPORTO A UNA HOJA DE EXCEL
                for (int i = 0; i < cajeras.Count; i++)
                {
                    DG_etiquetas.DataSource = null;//INICIALIZO EN NULL MI DATAGRID 
                    dt.Clear(); //LIMPIO EL DATATABLE
                    hoja = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets.Add();//AGREGO LA HOJA DE EXCEL
                    hoja.Name = cajeras[i].ToString();
             
                    MySqlCommand cmd2 = new MySqlCommand("SELECT clave as CLAVE,descrip AS DESCRIPCION,depto AS DEPTO,art_ceros AS CEROS,sin_etiqueta AS SIN_ETIQUETA,borrosa AS BORROSA,hora AS HORA,fecha AS FECHA FROM rd_etiquetas WHERE cajera='" + cajeras[i].ToString() + "' and fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "'", con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                    ad.Fill(dt);
                    //LLENO MI DATAGRID CON LOS DATOS DE LAS ETIQUETAS DE LA CAJERA SEGUN EL CICLO FOR
                    DG_etiquetas.DataSource = dt;
                    SumarEtiquetas();
                    excel.Range["A8:A4000"].NumberFormat = "@";
                    excel.Range["A1:E1"].Merge();
                    excel.Range["A1"].Value = "REPORTE DE ETIQUETAS DEL "+inicio.ToString("dd/MM/yyyy")+ " AL "+fin.ToString("dd/MM/yyyy");
                    excel.Range["G2:G2"].Value = "Art. en ceros";
                    excel.Range["G3:G3"].Value = "Sin Etiqueta";
                    excel.Range["G4:G4"].Value = "Etiqueta borrosa";
                    excel.Range["G5:G5"].Value = "Total";

                    excel.Range["H8:H1000"].Cells.NumberFormat = "dd/MM/aaaa";
                    excel.Range["G4:H4"].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

                    excel.Range["H2:H2"].Value = ceros;
                    excel.Range["H3:H3"].Value = sinEtiqueta;
                    excel.Range["H4:H4"].Value = borrosa;
                    excel.Range["H5:H5"].Value = total;

                    int indiceColumna = 0;

                    foreach (DataGridViewColumn col in DG_etiquetas.Columns)
                    {
                        indiceColumna++;
                        excel.Cells[7, indiceColumna] = col.Name;

                    }

                    int indiceFila = 6;

                    foreach (DataGridViewRow row in DG_etiquetas.Rows)
                    {
                        indiceFila++;
                        indiceColumna = 0;




                        foreach (DataGridViewColumn col in DG_etiquetas.Columns)
                        {
                            indiceColumna++;

                            excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value.ToString();

                        }

                    }

                    ceros = 0;
                    sinEtiqueta = 0;
                    borrosa = 0;
                    total = 0;
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex);
            }




           

            con.Close();

           
            excel.Visible = true;
            
        }
    }
}
