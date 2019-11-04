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


            DateTime Finicio = DT_inicio.Value;
            DateTime Ffin = DT_fin.Value;

            string inicio = FormatoFecha.getDate(Finicio);
            string fin = FormatoFecha.getDate(Ffin);


            MySqlConnection c = BDConexicon.conectar();
            MySqlCommand cmd;
            if (CB_tipo.SelectedItem.ToString()=="Todas")
            {
             cmd = new MySqlCommand("select texto as sugerencias from rd_sugerencias where fecha between '" + inicio + "'" + " and '" + fin + "'", c);
            }
            else
            {
               cmd = new MySqlCommand("select texto as sugerencias from rd_sugerencias where fecha between '" + inicio + "'" + " and '" + fin + "'and tipo= '" + CB_tipo.SelectedItem.ToString() + "'and cargo= '"+CB_cargo.SelectedItem.ToString()+"'", c);
            }
           

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();

            adaptador.Fill(tb);

            grid.DataSource = tb;
            grid.Columns[0].Width = 400;

            //grid.RowHeadersWidth = 200;




        }

        public string nombreSuc()
        {
            // obtengo el nombre de la sucursal para el reporte
            string suc = "";

            MySqlConnection c = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select empresa from econfig", c);
            //MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            MySqlDataReader myreader = cmd.ExecuteReader();



            myreader.Read();
            suc = myreader["EMPRESA"].ToString();



            return suc;
        }


        public String periodoReporte(DateTimePicker inicio,DateTimePicker fin)
        {
            

            DateTime DTinicio = inicio.Value;
            DateTime DTfin = fin.Value;
            String Finicio = DTinicio.ToShortDateString();
            String Ffin = DTfin.ToShortDateString();
            string periodo = "Reporte del "+Finicio+"  al  "+Ffin;
            return periodo;
        }
      
        public String tipoSugerencia(ComboBox c)
        {
            string tipo = "";
            tipo=c.SelectedItem.ToString();
           
            return tipo;
        }

        public void formatoExcel(Microsoft.Office.Interop.Excel.Application excel)
        {


            string suc = nombreSuc();// linea 56

            
           
            String periodo = periodoReporte(DT_inicio,DT_fin);//obtengo las fechas del periodo de las sugerencias buscadas; linea 77
            String tipo = tipoSugerencia(CB_tipo);

            //APLICO FORMATO EL DOCUMENTO DE EXCEL
            excel.Cells.Range["A3"].Value=periodo;
            excel.Cells.Range["A3"].Font.Bold = true;
            excel.Cells.Range["A3"].Font.Size = 10;
            

            excel.Cells.Range["A4"].Font.Bold = true;
            excel.Cells.Range["A4"].Font.Size = 14;
           excel.Cells.Range["A4"].Value = "SUGERENCIAS SEMANALES";
            excel.Cells.Range["B4"].Value = suc;
            excel.Cells.Range["B4"].Font.Bold = true;
            excel.Cells.Range["B4"].Font.Size = 12;
            //excel.Cells.Range["A4"]


            excel.Columns.Range["A:A"].ColumnWidth = 65;
            excel.Columns.Range["B:B"].ColumnWidth = 22.5;

            excel.Cells.Range["A5"].Font.Bold = true;
            excel.Cells.Range["A5"].Interior.ColorIndex = 49;
            excel.Cells.Range["A5"].Font.ColorIndex = 2;
            excel.Cells.Range["A5"].Font.Size = 14;

            excel.Cells.Range["B5"].Value=tipo;
            excel.Cells.Range["B5"].Font.Bold = true;
            excel.Cells.Range["B5"].Font.Size=14;
            excel.Cells.Range["B5"].Interior.ColorIndex = 49;
            excel.Cells.Range["B5"].Font.ColorIndex = 2;

            
        }



        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
                      
            
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
            formatoExcel(excel);//linea 61
            excel.Visible = true;


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(CB_tipo.SelectedItem==null)
            {
                MessageBox.Show("Selecciona el tipo de sugerencia en 'Sugerencias de'");
            }
            else
            {
                selectDatos(DG_sugerencias);
            }
            
        }

        private void BT_Excel_Click(object sender, EventArgs e)
        {
            if(DG_sugerencias.RowCount==0)
            {
                MessageBox.Show("Selecciona los datos a exportar");
            }
            else
            {
                exportarExcel(DG_sugerencias);
            }
            
        }

        private void ImprimirReporte_Load(object sender, EventArgs e)
        {

                        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
