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

            MySqlConnection con = new MySqlConnection("server=192.168.1.155; database=VALLARTA JUN 2018; Uid=root; pwd=;");
            con.Open();
           


            return con;

        }

        public static MySqlConnection Velazquez()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.1.155; database=VALLARTA JUN 2016; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection Rena()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.1.155; database=VALLARTA MAY 2016; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection Coloso()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.1.155; database=VALLARTA JUN 2018; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection Bodega()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.1.155; database=VALLARTA JUN 2018; Uid=root; pwd=;");
            con.Open();



            return con;

        }
    }
}
