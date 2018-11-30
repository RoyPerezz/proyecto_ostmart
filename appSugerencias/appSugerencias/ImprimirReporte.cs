using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace appSugerencias
{
    public partial class ImprimirReporte : Form
    {
        public ImprimirReporte()
        {
            InitializeComponent();
        }




        public void selectDatos(DataGridView grid)
        {

            FormatoFecha f = new FormatoFecha();
             DateTime Finicio = DT_inicio.Value;
            DateTime Ffin = DT_fin.Value;

            string inicio = f.getDate(Finicio);
            string fin = f.getDate(Ffin);

           

            MySqlCommand cmd = new MySqlCommand("select texto as sugerencias  from sugerencias where fecha between '" + inicio +"'"+" and '"+ fin+"'", frm_Sugerencias.conectar());

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();

            adaptador.Fill(tb);

            grid.DataSource = tb;
            grid.Columns[0].Width=400;
            
            //grid.RowHeadersWidth = 200;

            

           
        }

        public string nombreSuc()
        {
            // obtengo el nombre de la sucursal para el reporte
            string suc="";

            MySqlConnection c = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select empresa from econfig",c);
            //MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            MySqlDataReader myreader = cmd.ExecuteReader();
           


            myreader.Read();
            suc = myreader["EMPRESA"].ToString();



            return suc;
        }
      

        public void formatoExcel(Microsoft.Office.Interop.Excel.Application excel)
        {


            string suc = nombreSuc();// linea 56

            //APLICO FORMATO EL DOCUMENTO DE EXCEL
            //excel.Cells.Range["A4:B4"].Merge();
            excel.Cells.Range["A4"].Font.Bold = true;
            excel.Cells.Range["A4"].Font.Size = 14;
           excel.Cells.Range["A4"].Value = "SUGERENCIAS SEMANALES";
            excel.Cells.Range["B4"].Value = suc;
            excel.Cells.Range["B4"].Font.Bold = true;
            excel.Cells.Range["B4"].Font.Size = 14;
            //excel.Cells.Range["A4"]


            excel.Columns.Range["A:A"].ColumnWidth = 65;
            excel.Columns.Range["B:B"].ColumnWidth = 22.5;

            excel.Cells.Range["A5"].Font.Bold = true;
            excel.Cells.Range["A5"].Interior.ColorIndex = 49;
            excel.Cells.Range["A5"].Font.ColorIndex = 2;
            excel.Cells.Range["A5:B5"].Font.Size = 14;

            excel.Cells.Range["B5"].Font.Bold = true;
            excel.Cells.Range["B5"].Interior.ColorIndex = 49;
           excel.Cells.Range["B5"].Font.ColorIndex = 2;

            //for(int i = 6;i<=50;i++)
            //{
            //    excel.Range[i,1].Interior.ColorIndex = 50;
            //}
        }

        

        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
                      
            formatoExcel(excel);//linea 61
            int indiceColumna = 0;
           
            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;
               
            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;

               

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                    

                }

               
              
            }

            excel.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectDatos(DG_sugerencias);
        }

        private void BT_Excel_Click(object sender, EventArgs e)
        {
            exportarExcel(DG_sugerencias);
        }

        private void ImprimirReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
