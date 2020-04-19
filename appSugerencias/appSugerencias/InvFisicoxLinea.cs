using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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


        MySqlConnection con;
        List<Productos> p = new List<Productos>();
        



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
            //con.Close();
        }
        //FIN LLENA EL COMBOBOX CON LAS LINEAS DE PRODUCTOS

        //CARGA LAS LINEA DE PRODUCTOS ENE L COMBOBOX AL INICIAR EL FORM
        private void InvFisicoxLinea_Load(object sender, EventArgs e)
        {
            CargarLineas();
        }
        //FIN CARGA LAS LINEA DE PRODUCTOS ENE L COMBOBOX AL INICIAR EL FORM


        ArrayList articulos = new ArrayList();

        string linea = "";


        //############################ RECALCULA LA EXISTENCIA DE TODOS LOS PRODUCTOS DE LA LINEA SELECCIONADA ############################ 
        public void Recalcular()
        {
            
         
            articulos.Clear();
            DG1.Rows.Clear();
            //OBTENGO LOS ARTICULOS DE LA LINEA SELECCIONADA Y LOS GUARDO EN UNA LISTA
        
                con = BDConexicon.conectar();
            MySqlCommand claves = new MySqlCommand("SELECT ARTICULO FROM PRODS WHERE LINEA ='"+CB_lineas.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = claves.ExecuteReader();
            while (dr.Read())
            {
                articulos.Add(dr["ARTICULO"].ToString());
            }
            dr.Close();


            //SE REALIZA EL RECALCULO SUMANDO LAS ENTRAS Y RESTANDO LAS SALIDAS QUE TENGA EL PRODUCTO
            double entrada = 0, salida = 0, cantidad = 0;
            MySqlDataReader dr1 = null;
            for (int i = 0; i < articulos.Count; i++)
            {
                TB_mensaje.Text = Convert.ToString(articulos[i]);
                MySqlCommand cmd1 = new MySqlCommand("SELECT SUM( IF( almacen = 1 AND ent_sal = 'E', cantidad, 0 ) ) As 'ENTRADAS',SUM(IF(almacen = 1 AND ent_sal = 'S', cantidad, 0)) As 'SALIDAS'FROM  movsinv WHERE articulo = '"+articulos[i]+"'",con);
                dr1 = cmd1.ExecuteReader();

                 while (dr1.Read())
                 {

                        if (Convert.IsDBNull(dr1["ENTRADAS"]) || Convert.IsDBNull(dr1["SALIDAS"]))
                        {
                          entrada = 0;
                            salida = 0;
                        }
                        else
                         {
                            entrada += Convert.ToDouble(dr1["ENTRADAS"].ToString());
                            salida += Convert.ToDouble(dr1["SALIDAS"].ToString());
                        }
                       
                 }

                
                cantidad = entrada - salida;


                dr1.Close();
                //GUARDO EL PRODUCTO Y SU EXISTENCIA EN ESTA LISTA
                p.Add(new Productos { articulo = Convert.ToString(articulos[i]), existenciaRec = cantidad });
                //INSERTO LA EXISTENCIA RECALCULADA EN LA TABLA PRODS
                MySqlCommand update = new MySqlCommand("UPDATE prods SET existencia = '" + p[i].existenciaRec + "' where articulo ='" + p[i].articulo + "'", con);
                update.ExecuteNonQuery();
               
                entrada = 0; salida = 0; cantidad = 0;
               
              
            }

            articulos.Clear();

            double total = 0;
        
            //ESTANDO YA RECALCULADAS LAS EXISTENCIAS OBTENGO LOS DATOS DE LA TABLA PRODS  Y LOS INSERTO EN UN DATAGRID
            MySqlCommand datos = new MySqlCommand("SELECT ARTICULO, DESCRIP,COSTO_U,EXISTENCIA FROM PRODS WHERE LINEA='"+CB_lineas.SelectedItem.ToString()+"' AND EXISTENCIA != '0' ",con);
            MySqlDataReader myReader = datos.ExecuteReader();
            while (myReader.Read())
            {
              
                    total = Convert.ToDouble(Convert.ToDouble(myReader["COSTO_U"].ToString()) * Convert.ToInt32(myReader["EXISTENCIA"].ToString()));
                    DG1.Rows.Add(myReader["ARTICULO"].ToString(), myReader["DESCRIP"].ToString(), myReader["COSTO_U"].ToString(), myReader["EXISTENCIA"].ToString(), total);
                 
            }

         
            TB_CantItems.Text = Convert.ToString(DG1.RowCount);//OBTENGO EL NUMERO DE ITEMS CONTANDO LA CANTIDAD DE ROWS DEL DATAGRID

            myReader.Close();
            //con.Close();

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
            int existencia = 0;
            int i = 0 ;
            
            
                foreach (DataGridViewRow row in DG1.Rows)
                {
                    
                     indiceColumna = 0;
                    existencia = Convert.ToInt32(DG1.Rows[i].Cells[3].Value);
                    if (existencia > 0)
                    {
                        indiceFila++;
                    foreach (DataGridViewColumn col in DG1.Columns)
                        {
                            indiceColumna++;
                            excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                           
                        }
                        
                    }

                         i++;


                 }

            




            excel.Visible = true;

            TB_mensaje.Text = "ARTICULOS CON EXISTENCIA EXPORTADOS";

        }

        //OBTENGO EL VALOR DEL CONSECUTIVO DE movsinv
        public int GetConsecutivo()
        {
            int consecutivo = 1;
        
                con = BDConexicon.conectar();
            MySqlCommand consec = new MySqlCommand("SELECT Consec FROM CONSEC WHERE DATO ='Movsinv'", con);
            MySqlDataReader dr = consec.ExecuteReader();
            while (dr.Read())
            {
                consecutivo += consecutivo = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            //con.Close();
            return consecutivo;
            

        }

        //######################################## ESTE METODO PONE EN CERO LOS ARTICULOS DE LA LINEA Y LA BLOQUEA  ###################################################
        public void ArtenCero()
        {
            // SE INSERTA UNA SALIDA IGUAL AL VALOR DE LA EXISTENCIA RECALCULADA DEL ARTICULO PARA PONERLO EN CERO
            p.Clear();
           
            con = BDConexicon.conectar();
           
            int consecutivo = GetConsecutivo();
            DateTime fecha = DateTime.Now;
            DateTime hora = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss"));
            string articulo,cantidad,costo;
            for (int i = 0; i <DG1.RowCount; i++)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movsinv (CONSEC,OPERACION,MOVIMIENTO,ENT_SAL,TIPO_MOVIM,NO_REFEREN,ARTICULO,F_MOVIM,CANTIDAD,COSTO,EXISTENCIA,VALOR," +
              "ALMACEN,EXIST_ALM,PRECIO_VTA,POR_COSTEA,PARTIDA,Cerrado,Usuario,UsuFecha,UsuHora,CLAVEADD,PRCANTIDAD,ID_SALIDA,ID_ENTRADA," +
              "REORDENA,inicial,exportado,verificado,inventariofisico,donativo,precio_vta_original,costopromedio,poliza) " +
              "VALUES(?CONSEC,?OPERACION,?MOVIMIENTO,?ENT_SAL,?TIPO_MOVIM,?NO_REFEREN,?ARTICULO,?F_MOVIM,?CANTIDAD,?COSTO,?EXISTENCIA,?VALOR,?ALMACEN,?EXIST_ALM,?PRECIO_VTA,?POR_COSTEA,?PARTIDA," +
              "?Cerrado,?Usuario,?UsuFecha,?UsuHora,?CLAVEADD,?PRCANTIDAD,?ID_SALIDA,?ID_ENTRADA,?REORDENA,?inicial,?exportado,?verificado,?inventariofisico,?donativo,?precio_vta_original,?costopromedio,?poliza)", con);
                
                articulo = DG1.Rows[i].Cells[0].Value.ToString();
                cantidad = DG1.Rows[i].Cells[3].Value.ToString();
                costo = DG1.Rows[i].Cells[2].Value.ToString();
              

                cmd.Parameters.AddWithValue("?CONSEC", consecutivo+i);
                cmd.Parameters.AddWithValue("?OPERACION", "IC-");
                cmd.Parameters.AddWithValue("?MOVIMIENTO", "IC-");
                cmd.Parameters.AddWithValue("?ENT_SAL", "S");
                cmd.Parameters.AddWithValue("?TIPO_MOVIM", "IC-");
                cmd.Parameters.AddWithValue("?NO_REFEREN", "");
                cmd.Parameters.AddWithValue("?ARTICULO", articulo);
                cmd.Parameters.AddWithValue("?F_MOVIM", fecha);
                cmd.Parameters.AddWithValue("?CANTIDAD", cantidad);
                cmd.Parameters.AddWithValue("?COSTO", costo);
                cmd.Parameters.AddWithValue("?EXISTENCIA", 0);
                cmd.Parameters.AddWithValue("?VALOR", 0);
                cmd.Parameters.AddWithValue("?ALMACEN", 1);
                cmd.Parameters.AddWithValue("?EXIST_ALM", 0);
                cmd.Parameters.AddWithValue("?PRECIO_VTA", 0);
                cmd.Parameters.AddWithValue("?POR_COSTEA", 0);
                cmd.Parameters.AddWithValue("?PARTIDA", 0);
                cmd.Parameters.AddWithValue("?Cerrado", 0);
                cmd.Parameters.AddWithValue("?Usuario", "");
                cmd.Parameters.AddWithValue("?UsuFecha", fecha);
                cmd.Parameters.AddWithValue("?UsuHora", hora);
                cmd.Parameters.AddWithValue("?CLAVEADD", "");
                cmd.Parameters.AddWithValue("?PRCANTIDAD", 1);
                cmd.Parameters.AddWithValue("?ID_SALIDA", 0);
                cmd.Parameters.AddWithValue("?ID_ENTRADA", 0);
                cmd.Parameters.AddWithValue("?REORDENA", 0);
                cmd.Parameters.AddWithValue("?inicial", 0);
                cmd.Parameters.AddWithValue("?exportado",0);
                cmd.Parameters.AddWithValue("?verificado",0);
                cmd.Parameters.AddWithValue("?inventariofisico",0);
                cmd.Parameters.AddWithValue("?donativo",0);
                cmd.Parameters.AddWithValue("?precio_vta_original",0);
                cmd.Parameters.AddWithValue("?costopromedio",0);
                cmd.Parameters.AddWithValue("?poliza",null);

                cmd.ExecuteNonQuery();
               
            }
            
            //SE BLOQUEA LA LINEA EN LA QUE SE ESTA TRABAJANDO
            MySqlCommand update = new MySqlCommand("UPDATE prods SET bloqueado=1 where linea ='" +CB_lineas.SelectedItem.ToString() + "'", con);
            update.ExecuteNonQuery();


            //ACTUALIZAR CONSECUTIVO
          
            int registros = Convert.ToInt32(TB_CantItems.Text);
            int actualizarConsec = (registros-1) + consecutivo;
            MySqlCommand numConsec = new MySqlCommand("UPDATE CONSEC SET Consec ='"+actualizarConsec+ "'"+" WHERE Dato = 'movsinv'", con);
            numConsec.ExecuteNonQuery();
           
            Recalcular();
            //con.Close();
            
        }


        private void BT_recalcular_Click(object sender, EventArgs e)
        {
            TB_mensaje.Text = "RECALCULANDO,ESPERE...";
            BT_recalcular.Enabled = false;
            Recalcular();
            BT_recalcular.Enabled = true;
            TB_mensaje.Text = "LINEA RECALCULADA";

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            BT_exportar.Enabled = false;
            TB_mensaje.Text = "EXPORTANDO, ESPERE...";
            Exportar();
            TB_mensaje.Text = "DATOS EXPORTADOS A EXCEL";
            BT_exportar.Enabled = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
        
            TB_mensaje.Text = "PROCESANDO...";
            button1.Enabled = false;
            ArtenCero();
            button1.Enabled = true;
            TB_mensaje.Text = "ARTICULOS EN CEROS Y LINEA BLOQUEADA";
        }

        private void CB_lineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DG1.Rows.Clear();
            TB_CantItems.Text = "";
            TB_mensaje.Text = "";
        }


        //EXPORTA A UN ARCHIVO TXT EL ARTICULO Y SU DESCRIPCION
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            TB_mensaje.Text = "EXPORTANDO, ESPERE...";
            dlGuardar.Filter = "Fichero TXT (*.txt)|*.txt";
            dlGuardar.FileName = "Datos_sqlite";
            dlGuardar.Title = "Exportar";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();


                int cantidad = 0;

                for (int m = 0; m < DG1.Rows.Count; m++)
                {
                    cantidad = Convert.ToInt32(DG1.Rows[m].Cells[3].Value);
                    if (cantidad > 0)
                    {
                        for (int n = 0; n < DG1.Columns.Count - 3; n++)
                        {
                            //si es la última columna no poner el ;
                            if (n == DG1.Columns.Count - 1)
                            {
                                csvMemoria.Append(String.Format("{0},",
                                     DG1.Rows[m].Cells[n].Value));
                            }
                            else
                            {
                                csvMemoria.Append(String.Format("{0},",
                                   DG1.Rows[m].Cells[n].Value));
                            }
                        }
                        csvMemoria.AppendLine();
                    }
                    
                }



                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(dlGuardar.FileName, false,
                       System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }

            TB_mensaje.Text = "DATOS EXPORTADOS A TXT";
            button2.Enabled = true;
        }

        private void BT_cargarArchivo_Click(object sender, EventArgs e)
        {
            BT_cargarArchivo.Enabled = false;
            TB_mensaje.Text = "IMPORTANDO ARCHIVO, ESPERE...";
          
                con = BDConexicon.conectar();
     
            string[] datos = null;

            //ABRO EL ARCHIVO DEL CUAL TOMARÉ LOS DATOS A INSERTAR
            OpenFileDialog abrir = new OpenFileDialog();
            string ruta = "";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                ruta = abrir.FileName;


                Process proceso = new Process();
                proceso.StartInfo.FileName = ruta;
                //proceso.Start();
            }

            //LEO EL ARCHIVO
            string fichero = ruta;
            int consecutivo = GetConsecutivo();
            int i = 0;
            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            //Console.WriteLine(linea);

                            datos = linea.Split(',');
                            p.Clear();

                          
                            DateTime fecha = DateTime.Now;
                            DateTime hora = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss"));
                            string costo;
                            //for (int i = 0; i < datos.Length; i++)
                            //{
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO movsinv (CONSEC,OPERACION,MOVIMIENTO,ENT_SAL,TIPO_MOVIM,NO_REFEREN,ARTICULO,F_MOVIM,CANTIDAD,COSTO,EXISTENCIA,VALOR," +
                              "ALMACEN,EXIST_ALM,PRECIO_VTA,POR_COSTEA,PARTIDA,Cerrado,Usuario,UsuFecha,UsuHora,CLAVEADD,PRCANTIDAD,ID_SALIDA,ID_ENTRADA," +
                              "REORDENA,inicial,exportado,verificado,inventariofisico,donativo,precio_vta_original,costopromedio,poliza) " +
                              "VALUES(?CONSEC,?OPERACION,?MOVIMIENTO,?ENT_SAL,?TIPO_MOVIM,?NO_REFEREN,?ARTICULO,?F_MOVIM,?CANTIDAD,?COSTO,?EXISTENCIA,?VALOR,?ALMACEN,?EXIST_ALM,?PRECIO_VTA,?POR_COSTEA,?PARTIDA," +
                              "?Cerrado,?Usuario,?UsuFecha,?UsuHora,?CLAVEADD,?PRCANTIDAD,?ID_SALIDA,?ID_ENTRADA,?REORDENA,?inicial,?exportado,?verificado,?inventariofisico,?donativo,?precio_vta_original,?costopromedio,?poliza)", con);

                                //articulo = DG1.Rows[i].Cells[0].Value.ToString();
                                //cantidad = DG1.Rows[i].Cells[3].Value.ToString();
                                //costo = DG1.Rows[i].Cells[2].Value.ToString();

                                cmd.Parameters.AddWithValue("?CONSEC", consecutivo + i);
                                cmd.Parameters.AddWithValue("?OPERACION", "IC+");
                                cmd.Parameters.AddWithValue("?MOVIMIENTO", "IC+");
                                cmd.Parameters.AddWithValue("?ENT_SAL", "E");
                                cmd.Parameters.AddWithValue("?TIPO_MOVIM", "IC+");
                                cmd.Parameters.AddWithValue("?NO_REFEREN", "");
                                cmd.Parameters.AddWithValue("?ARTICULO", datos[0]);
                                cmd.Parameters.AddWithValue("?F_MOVIM", fecha);
                                cmd.Parameters.AddWithValue("?CANTIDAD", datos[2]);
                                cmd.Parameters.AddWithValue("?COSTO", 0);
                                cmd.Parameters.AddWithValue("?EXISTENCIA", 0);
                                cmd.Parameters.AddWithValue("?VALOR", 0);
                                cmd.Parameters.AddWithValue("?ALMACEN", 1);
                                cmd.Parameters.AddWithValue("?EXIST_ALM", 0);
                                cmd.Parameters.AddWithValue("?PRECIO_VTA", 0);
                                cmd.Parameters.AddWithValue("?POR_COSTEA", 0);
                                cmd.Parameters.AddWithValue("?PARTIDA", 0);
                                cmd.Parameters.AddWithValue("?Cerrado", 0);
                                cmd.Parameters.AddWithValue("?Usuario", "");
                                cmd.Parameters.AddWithValue("?UsuFecha", fecha);
                                cmd.Parameters.AddWithValue("?UsuHora", hora);
                                cmd.Parameters.AddWithValue("?CLAVEADD", "");
                                cmd.Parameters.AddWithValue("?PRCANTIDAD", 1);
                                cmd.Parameters.AddWithValue("?ID_SALIDA", 0);
                                cmd.Parameters.AddWithValue("?ID_ENTRADA", 0);
                                cmd.Parameters.AddWithValue("?REORDENA", 0);
                                cmd.Parameters.AddWithValue("?inicial", 0);
                                cmd.Parameters.AddWithValue("?exportado", 0);
                                cmd.Parameters.AddWithValue("?verificado", 0);
                                cmd.Parameters.AddWithValue("?inventariofisico", 0);
                                cmd.Parameters.AddWithValue("?donativo", 0);
                                cmd.Parameters.AddWithValue("?precio_vta_original", 0);
                                cmd.Parameters.AddWithValue("?costopromedio", 0);
                                cmd.Parameters.AddWithValue("?poliza", null);

                                cmd.ExecuteNonQuery();
                            i++;
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            MySqlCommand update = new MySqlCommand("UPDATE prods SET bloqueado = 0 where linea ='" + CB_lineas.SelectedItem.ToString() + "'", con);
            update.ExecuteNonQuery();
           
            DG1.Rows.Clear();
            Recalcular();
          
            int registros = Convert.ToInt32(TB_CantItems.Text);
            int actualizarConsec = (registros - 1) + consecutivo;
            MySqlCommand numConsec = new MySqlCommand("UPDATE CONSEC SET Consec ='" + actualizarConsec + "'" + " WHERE Dato = 'movsinv'", con);
            numConsec.ExecuteNonQuery();
            con.Close();
            BT_cargarArchivo.Enabled = true;
            TB_mensaje.Text = "SE HA CARGADO LA NUEVA EXISTENCIA";
        }


        
    }
}
