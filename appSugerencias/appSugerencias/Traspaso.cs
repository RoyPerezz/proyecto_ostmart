using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Traspaso : Form
    {
        public Traspaso()
        {
            InitializeComponent();
        }

        int existencia = 0;


        public void Sucursal()// obtiene el nombre de la sucursal, debe cambiar el método de conexión según la suc. donde se use
        {
            string sucursal = "";
            MySqlCommand cmd = new MySqlCommand("select empresa from econfig",BDConexicon.prueba());

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                sucursal= rd[0].ToString();

                if (sucursal.Equals("OSMART VALLARTA"))
                {
                    TB_origen.Text = "VA";
                }
                if (sucursal.Equals("OSMART RENA"))
                {
                    TB_origen.Text = "RE";
                }
                if (sucursal.Equals("OSMART COLOSO"))
                {
                    TB_origen.Text = "CO";
                }
                if (sucursal.Equals("OSMART VELAZQUEZ"))
                {
                    TB_origen.Text = "VE";
                }
                if (sucursal.Equals("BODEGA"))
                {
                    TB_origen.Text = "BO";
                }
            }
           
        }



        private void Traspaso_Load(object sender, EventArgs e)
        {
            Sucursal();

            DG_datos.Columns[2].Width = 300;
            DG_datos.Columns[3].Width = 70;
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void AgregarArticulo()
        {
            
            if (TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Introduce el artículo");
            }
            else
            {

                //obtengo el id del ultimo traspaso creado
                MySqlCommand id = new MySqlCommand("select max(idtraspaso) as id from rd_traspaso ", BDConexicon.prueba());
                MySqlDataReader r = id.ExecuteReader();
                int idtraspaso = 0;
                while (r.Read())
                {
                    idtraspaso = Convert.ToInt32(r[0].ToString());
                    MessageBox.Show("id:" + idtraspaso);
                }

                // se validad el articulo para ver si existe en la base de datos
                MySqlCommand c = new MySqlCommand("select articulo from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.prueba());
                MySqlDataReader art = c.ExecuteReader();
                string articulo = "";
                while (art.Read())
                {
                    articulo = art[0].ToString();
                }


                if (TB_articulo.Text.Equals(articulo))
                {
                    MySqlCommand cmd = new MySqlCommand("select descrip, existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.prueba());
                    MySqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {


                        //double precio = Convert.ToDouble(rd["precio1"].ToString());
                        //precio += precio * .16;
                        existencia = Convert.ToInt32(rd["existencia"].ToString());

                        DG_datos.Rows.Add(idtraspaso.ToString(), TB_articulo.Text, rd["descrip"].ToString(), 0, rd["existencia"].ToString());




                    }
                }
                else
                {
                    MessageBox.Show("El artículo no existe en la base de datos o el codigo es incorrecto, favor de verificar");
                }

                
                
            }

            

        }



       
        private void BT_agregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo();
            TB_articulo.Text = "";
            DG_datos.Focus();
          

        }



        

        private void DG_datos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            int cantidad = 0;
            //double precio = 0;
            //double importe = 0;

            



            if (DG_datos.Columns[e.ColumnIndex].Name == "CANTIDAD")
            {
                try
                {
                    
                    cantidad = Convert.ToInt32(DG_datos.Rows[e.RowIndex].Cells[3].Value.ToString());

                    
                    if (cantidad>existencia)
                    {
                        MessageBox.Show("solo tienes "+existencia+" de este producto, necesitas surtirte de este producto");
                        DG_datos.Rows[e.RowIndex].Cells[3].Value= 0;
                    }
                    else
                    {
                        //try
                        //{
                        //    importe = cantidad * precio;
                        //    DG_datos.Rows[e.RowIndex].Cells[3].Value = importe;
                        //}
                        //catch (Exception)
                        //{

                        //    throw;
                        //}
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Introduce la cantidad");
                   
                }

               

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                DG_datos.Rows.Remove(DG_datos.CurrentRow);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar una fila sin datos");
                
            }
            
        }


        public void limpiar()
        {
            CB_destino.SelectedIndex = -1;
            TB_motivo.Text = "";
            DG_datos.Rows.Clear();
            DG_datos.Refresh();
            
        }

        public void deshabilitar()
        {
            BT_agregar.Enabled = false;
            BT_eliminar.Enabled = false;
            TB_articulo.Enabled = false;
            BT_guardar.Enabled = false;
            DG_datos.Enabled = false;
        }


        private void BT_guardar_Click(object sender, EventArgs e)
        {
            //guardar los productos que se van a traspasar,  a cada producto se les agrega
            //el ID del traspaso al que pertenecen

          
            

            
            MySqlCommand cmd2 = new MySqlCommand("insert into rd_traspaso_articulos(fk_idtraspaso,articulo,descripcion,cantidad) values(?fk_idtraspaso,?articulo,?descripcion,?cantidad)", BDConexicon.prueba());


          
            foreach (DataGridViewRow row in DG_datos.Rows)
            {
               
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("?fk_idtraspaso", Convert.ToInt32(row.Cells["idtraspaso"].Value));
                    cmd2.Parameters.AddWithValue("?articulo", Convert.ToString(row.Cells["ARTICULO"].Value));
                cmd2.Parameters.AddWithValue("?descripcion", Convert.ToString(row.Cells["DESCRIPCION"].Value));
                cmd2.Parameters.AddWithValue("?cantidad", Convert.ToInt32(row.Cells["CANTIDAD"].Value));
                    cmd2.ExecuteNonQuery();
               

                    
                
                
            }

           

            limpiar();
            MessageBox.Show("Se han agregado los productos al traspaso");
            deshabilitar();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CB_destino.SelectedIndex ==-1)
            {
                MessageBox.Show("Debes seleccionar un destino de traspaso");
            }else if(TB_motivo.Text.Equals("")){
                MessageBox.Show("Justifica el traspaso agregando un motivo");
            }
            else
            {
                //crea el traspaso en rd_traspaso

                MySqlCommand cmd = new MySqlCommand("insert into rd_traspaso(fecha, usuario, origen, destino, status, motivo) values(?fecha, ?usuario, ?origen, ?destino, ?status, ?motivo)", BDConexicon.prueba());
                DateTime fecha = DT_fecha.Value;
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy,MM,dd"));
                cmd.Parameters.AddWithValue("?usuario", "Admin");
                cmd.Parameters.AddWithValue("?origen", TB_origen.Text);
                cmd.Parameters.AddWithValue("?destino", CB_destino.SelectedItem);
                cmd.Parameters.AddWithValue("?status", "solicitado");
                cmd.Parameters.AddWithValue("?motivo", TB_motivo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Traspaso creado");

                //habilitar componentes
                BT_agregar.Enabled = true;
                BT_eliminar.Enabled = true;
                TB_articulo.Enabled = true;
                BT_guardar.Enabled = true;
                DG_datos.Enabled = true;
            }
          
        }
    }
}
