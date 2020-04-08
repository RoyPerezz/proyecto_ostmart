using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class PagoComisiones : Form
    {
        public PagoComisiones()
        {
            InitializeComponent();
        }
        int numCol = 0;
        ArrayList fechas = new ArrayList();//GUARDO LAS FECHAS EN ESTE ARRAY PARA COLOCARLAS COMO NOMBRES DE COLUMNA
        double T_incentivo = 0;//GUARDA EL TOTAL DE INCENTIVO A PAGAR
        double T_total = 0;//GUARDA EL TOTAL DE COMISION A PAGAR



        //############## METODOS PARA SETEAR Y OBTENER LOS VALORES DE LAS VARIABLES T_INCENTIVO Y T_TOTAL #####################################################
        public void setIncentivo(double incentivo)
        {
            T_incentivo = incentivo;
           
        }

        public void setTotal(double total)
        {
            T_total = total;
            
        }

        public string getIncentivo()
        {
            
            return String.Format("{0:0.##}", T_incentivo.ToString("C"));
        }

        public string getTotal()
        {
            return String.Format("{0:0.##}", T_total.ToString("C"));
        }
        //#########################################################################################################################################

        public void Comisiones()// ESTE METODO LLENA EL DATAGRIDVIEW CON LAS COMISIONES DE LAS CAJERAS EN EL DIA CORRESPONDIENTE
        {


            DG_comisiones.Rows.Clear();
            LB_incentivo.Text = "";
            LB_comision.Text = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
           
           
            //OBTIENE LAA FECHAS DE LOS DATATIMEPICKERS Y LAS COLOCA COMO COLUMNAS EN EL DATAGRIDVIEW

            int indice = 1;
            string aux = "";
            for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
            {
                aux = Convert.ToString(dia.ToShortDateString());
                fechas.Add(aux);
            }

            for (int j = 0; j < fechas.Count; j++)
            {
                DG_comisiones.Columns[indice].HeaderText = Convert.ToString(fechas[j]);
                DG_comisiones.Columns[indice].Name = Convert.ToString(fechas[j]);
                indice++;
            }


            //TRAIGO LAS CAJERAS Y LAS METO A MI DATAGRID




            MySqlCommand cmd2 = new MySqlCommand("Select DISTINCT USUARIO from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'order by USUARIO", BDConexicon.conectar());
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
               
                DG_comisiones.Rows.Add(dr2["USUARIO"].ToString());


            }

            dr2.Close();


            //AGREGAR COMISIONES DE CAJERAS EN LOS DÍAS CORRESPONDIENTES
            MySqlCommand cmd3 = new MySqlCommand("Select  USUARIO,FECHA,Ctotal from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'order by USUARIO", BDConexicon.conectar());
            MySqlDataReader dr3 = null; ;

          
            DataTable pagos = new DataTable();
       
            int i = 1;
            int x = 0;
            int filas = 0;
            double valor = 0;
            string fecha = "";
            string usuario = "", cajera = "", comision = "";
            DateTime f2;
            
            try
            {
               

                //RELLENO TODO EL DATAGRID EN 0
                for (int rFilas = 0; rFilas <DG_comisiones.RowCount; rFilas++)
                {
                    for (int rCol = 1; rCol <DG_comisiones.ColumnCount; rCol++)
                    {
                        DG_comisiones.Rows[rFilas].Cells[rCol].Value = String.Format("{0:0.##}", valor.ToString("C"));
                    }
                }


                //SE LLENA EL DATAGRID CON LA COMISION DE LAS CAJERAS

                for (int rows = 0; rows < DG_comisiones.RowCount; rows++)
                {
                    cajera = Convert.ToString(DG_comisiones.Rows[rows].Cells[0].Value);
                    dr3 = cmd3.ExecuteReader();

                    while (dr3.Read())
                    {
                        usuario = dr3["usuario"].ToString();
                        f2 = Convert.ToDateTime(dr3["fecha"].ToString());
                        fecha = f2.ToString("dd/MM/yyyy");
                        
                        comision = dr3["Ctotal"].ToString();

                        for (int col = 0; col <= DG_comisiones.ColumnCount; col++)
                        {
                            if (cajera.Equals(usuario) && fecha.Equals(DG_comisiones.Columns[col].HeaderText))
                            {
                                double c = Convert.ToDouble(comision);
                                DG_comisiones.Rows[rows].Cells[col].Value = String.Format("{0:0.##}", c.ToString("C"));
                                break;
                            }

                           
                        }
                    }
                    dr3.Close();

                }

               
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);

            }

           
            fechas.Clear();





        }

        private void PagoComisiones_Load(object sender, EventArgs e)
        {

        }

        private void BT_comisiones_Click(object sender, EventArgs e)
        {
            Comisiones();
            //RellenarVacios();
            numCol = DG_comisiones.ColumnCount;
            
        }


       

        private void BT_exportar_Click(object sender, EventArgs e)
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
            excel.Cells.Range["A4"].Value = "COMISIONES DE LA SEMANA DEL    "+inicio.ToUpper()+  "   AL    "+fin.ToUpper();

            excel.Cells.Range["K17"].Value = "TOTAL INCENTIVO =";
            excel.Cells.Range["L17"].Value = getIncentivo();
            excel.Cells.Range["K18"].Value = "TOTAL COMISION =";
            excel.Cells.Range["L18"].Value = getTotal();
            excel.Cells.Range["B6:I16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["I6:I16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["J6:J16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K6:K16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["L6:L16"].NumberFormat = "$#,##0.00";

            excel.Visible = true;
        }



        public void RellenarVacios()
        {

            double val = 0;
            for (int i = 0; i <DG_comisiones.RowCount; i++)
            {


                for (int j = 0; j < DG_comisiones.Columns.Count; j++)
                {
                    if (DG_comisiones.Rows[i].Cells[j].Value.ToString() == String.Empty)
                    {
                        DG_comisiones.Rows[i].Cells[j].Value = String.Format("{0:0.##}", val.ToString("C")); ;
                    }
                }
               
              
            }




        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            double col1 = 0, col2 = 0, col3 = 0, col4 = 0, col5 = 0, col6 = 0, col7 = 0, col8 = 0, col9 = 0, col10 = 0, total = 0;
            string texto = "",texto2="",texto3 = "",texto4="",texto5="",texto6="",texto7 = "",texto8="",texto9="",texto10="";

            for (int i = 0; i < DG_comisiones.RowCount; i++)
            {

                
                decimal digito = decimal.Parse(DG_comisiones.Rows[i].Cells[1].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));

              
                texto = digito.ToString("G0");
                col1 = Convert.ToDouble(texto);

                decimal digito2 = decimal.Parse(DG_comisiones.Rows[i].Cells[2].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto2 = digito2.ToString("G0");
                col2 = Convert.ToDouble(texto2);

                decimal digito3 = decimal.Parse(DG_comisiones.Rows[i].Cells[3].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto3 = digito3.ToString("G0");
                col3 = Convert.ToDouble(texto3);

                decimal digito4 = decimal.Parse(DG_comisiones.Rows[i].Cells[4].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                 texto4 = digito4.ToString("G0");
                col4 =Convert.ToDouble(texto4);

                decimal digito5 = decimal.Parse(DG_comisiones.Rows[i].Cells[5].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto5 = digito5.ToString("G0");
                col5 = Convert.ToDouble(texto5);

                decimal digito6 = decimal.Parse(DG_comisiones.Rows[i].Cells[6].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto6 = digito6.ToString("G0");
                col6 = Convert.ToDouble(texto6);

                decimal digito7 = decimal.Parse(DG_comisiones.Rows[i].Cells[7].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto7 = digito7.ToString("G0");
                col7 = Convert.ToDouble(texto7);


                decimal digito8 = decimal.Parse(DG_comisiones.Rows[i].Cells[8].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto8 = digito8.ToString("G0");
                col8 = Convert.ToDouble(texto8);

                decimal digito9 = decimal.Parse(DG_comisiones.Rows[i].Cells[9].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto9 = digito9.ToString("G0");
                col9 = Convert.ToDouble(texto9);

                decimal digito10 = decimal.Parse(DG_comisiones.Rows[i].Cells[10].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto10 = digito10.ToString("G0");
                col10 = Convert.ToDouble(texto10);

                total=(col1+col2+col3+col4+col5+col6+col7+col8+col9)-col10;
                DG_comisiones.Rows[i].Cells[11].Value = total;

            }

            double sumaTotal = 0;
            double sumaIncentivo = 0;
            string T_sumIncentivo = "";
            string T_sumTotal = "";
            for (int fila = 0; fila < DG_comisiones.RowCount; fila++)
            {

                decimal digito = decimal.Parse(DG_comisiones.Rows[fila].Cells[9].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                T_sumIncentivo = digito.ToString("G0");
                sumaIncentivo += Convert.ToDouble(T_sumIncentivo);
                setIncentivo(sumaIncentivo);
                LB_incentivo.Text = Convert.ToString(String.Format("{0:0.##}", sumaIncentivo.ToString("C")));

            }

            for (int fila = 0; fila < DG_comisiones.RowCount; fila++)
            {
                decimal digito = decimal.Parse(DG_comisiones.Rows[fila].Cells[11].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                T_sumTotal = digito.ToString("G0");
                sumaTotal += Convert.ToDouble(T_sumTotal);
                setTotal(sumaTotal);
                LB_comision.Text = Convert.ToString(String.Format("{0:0.##}", sumaTotal.ToString("C")));


            }
        }
    }          
}
