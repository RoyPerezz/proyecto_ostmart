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



        //############## METODOS PARA SETEAR LAS VARIABLES T_INCENTIVO Y T_TOTAL #####################################################
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
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
           
            DataTable dt = new DataTable();
            DataRow fila;
            fila = dt.NewRow();

            //OBTENGO LAS FECHAS DE LA BD PARA PONERLAS COMO NOMBRES DE COLUMNAS
            MySqlCommand cmd = new MySqlCommand("Select DISTINCT Fecha from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'order by fecha", BDConexicon.conectar());

            MySqlDataReader dr = cmd.ExecuteReader();

            string ColNom = "";
            DateTime f;
            dt.Columns.Add("CAJERA");
            while (dr.Read())
            {
                f= Convert.ToDateTime(dr["Fecha"].ToString());
                ColNom = f.ToString("dd/MM/yyyy");

                dt.Columns.Add(ColNom);
                fechas.Add(ColNom);

            }
            dr.Close();
            //Lleno la columna CAJERAS de mi DataTable con el usuario de las cajeras
            MySqlCommand cmd2 = new MySqlCommand("Select DISTINCT USUARIO from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'order by USUARIO", BDConexicon.conectar());
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                fila = dt.NewRow();
                fila["CAJERA"] = dr2["USUARIO"].ToString();
                dt.Rows.Add(fila);

            }
            dr2.Close();


            //AGREGAR COMISIONES DE CAJERAS EN LOS DÍAS CORRESPONDIENTES
            MySqlCommand cmd3 = new MySqlCommand("Select  USUARIO,FECHA,Ctotal from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'order by USUARIO", BDConexicon.conectar());
            MySqlDataReader dr3 = null; ;

          
            DataTable pagos = new DataTable();
       
            int i = 1;
            int x = 0;
            int filas = 0;
            string fecha = "";
            string usuario = "", cajera = "", comision = "";
            DateTime f2;
            dt.Columns.Add("COMISION TIKCETS");
            
            dt.Columns.Add("INCENTIVO");
            dt.Columns.Add("REPORTES DE CÁMARA");
            dt.Columns.Add("TOTAL");
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    cajera = row["CAJERA"].ToString();
                    dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        usuario = dr3["usuario"].ToString();
                        f2= Convert.ToDateTime(dr3["fecha"].ToString());
                        fecha = f2.ToString("dd/MM/yyyy");
                        comision = dr3["Ctotal"].ToString();

                        foreach (DataColumn col in dt.Columns)
                        {
                            if (cajera.Equals(usuario) && fecha.Equals(col.ColumnName))
                            {

                                double c = Convert.ToDouble(comision);
                                row[col.ColumnName] = String.Format("{0:0.##}", c.ToString("C"));
                                break;
                            }
                            row["INCENTIVO"] = "0";
                            row["TOTAL"] = "0";


                        }
                    }
                    dr3.Close();

                }


            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);

            }


            DG_comisiones.DataSource = dt;
          



        }

        private void PagoComisiones_Load(object sender, EventArgs e)
        {

        }

        private void BT_comisiones_Click(object sender, EventArgs e)
        {
            Comisiones();
            numCol = DG_comisiones.ColumnCount;
            
        }


        //###################### SE REALIZAN LOS CALCULOS DE LAS COMISIONES A PAGAR CUANDO SE TERMINA DE EDITAR LAS CELDAS DE LA COLUMNA INCENTIVO
        private void DG_comisiones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                double suma = 0, col1 = 0, col2 = 0, col3 = 0, col4 = 0, col5 = 0, col6 = 0, col7 = 0,col8=0,col10=0, incentivo = 0;
                double sumaIncentivo = 0;
                double sumaTotal = 0;


                if (DG_comisiones.Columns[e.ColumnIndex].Name == "INCENTIVO")
                {
                    if (DG_comisiones.Rows[e.RowIndex].Cells[1].Value.ToString() == String.Empty)
                    {
                        col1 = 0;
                    }
                    else
                    {
                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[1].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col1 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[2].Value.ToString() == String.Empty)
                    {
                        col2 = 0;
                    }
                    else
                    {

                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[2].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col2 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[3].Value.ToString() == String.Empty)
                    {
                        col3 = 0;
                    }
                    else

                    {
                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[3].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col3 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[4].Value.ToString() == String.Empty)
                    {
                        col4 = 0;
                    }
                    else
                    {

                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[4].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col4 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[5].Value.ToString() == String.Empty)
                    {
                        col5 = 0;
                    }
                    else
                    {

                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[5].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col5 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[6].Value.ToString() == String.Empty)
                    {
                        col6 = 0;
                    }
                    else
                    {

                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[6].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col6 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[7].Value.ToString() == String.Empty)
                    {
                        col7 = 0;
                    }
                    else
                    {


                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[7].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col7 = Convert.ToDouble(texto);
                    }

                    if (DG_comisiones.Rows[e.RowIndex].Cells[8].Value.ToString() == String.Empty)
                    {
                        col8 = 0;
                    }
                    else
                    {

                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[8].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col8 = Convert.ToDouble(texto);
                    }


                    if (DG_comisiones.Rows[e.RowIndex].Cells[10].Value.ToString() == String.Empty)
                    {
                        col10 = 0;
                    }
                    else
                    {

                        decimal digito = decimal.Parse(DG_comisiones.Rows[e.RowIndex].Cells[10].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                        string texto = digito.ToString("G0");
                        col10 = Convert.ToDouble(texto);
                    }


                    //SE CAPTURA EL INCENTIVO ASENTADO EN LA CELDA DE LA COLUMNA INCENTIVO
                    incentivo = Convert.ToDouble(DG_comisiones.Rows[e.RowIndex].Cells[9].Value.ToString());

                    //SE SUMAN LAS COMISIONES Y SE LE RESTA LA COLUMNA 10 (REPORTES DE CAMARA)
                    suma = (col1 + col2 + col3 + col4 + col5 + col6 +col7+col8+incentivo)-col10;
                    DG_comisiones.Rows[e.RowIndex].Cells[11].Value = Convert.ToString(suma);


                   
                    for (int fila = 0; fila < DG_comisiones.RowCount; fila++)
                    {

                       
                        sumaIncentivo += Convert.ToDouble(DG_comisiones.Rows[fila].Cells[9].Value.ToString());
                        setIncentivo(sumaIncentivo);
                        LB_incentivo.Text = Convert.ToString(String.Format("{0:0.##}", sumaIncentivo.ToString("C")));

                    }

                    for (int fila = 0; fila < DG_comisiones.RowCount; fila++)
                    {
                        
                        sumaTotal += Convert.ToDouble(DG_comisiones.Rows[fila].Cells[11].Value.ToString());
                        setTotal(sumaTotal);
                        LB_comision.Text = Convert.ToString(String.Format("{0:0.##}", sumaTotal.ToString("C")));


                    }
                }
               

            }
            catch (Exception ex)
            {

                
            }


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

            excel.Cells.Range["I6:I16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["J6:J16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K6:K16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["L6:L16"].NumberFormat = "$#,##0.00";

            excel.Visible = true;
        }
    }          
}
