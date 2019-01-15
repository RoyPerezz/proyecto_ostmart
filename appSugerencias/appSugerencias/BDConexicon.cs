using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace appSugerencias
{
    class BDConexicon
    {
        public static MySqlConnection conectar()
        {


            //Esto es una conexion lalalalalla

            MySqlConnection con = new MySqlConnection("server=192.168.1.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();
           


            return con;

        }

        public static MySqlConnection Velazquez()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.4.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection Rena()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.2.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection Coloso()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.3.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection Bodega()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.0.190; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }
    }
}
