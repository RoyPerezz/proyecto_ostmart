﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace appSugerencias
{
    class BDConexicon
    {

        MySqlConnection con;



        public static MySqlConnection prueba()
        {

            TextReader IP;
            IP = new StreamReader("IP.txt");
            string server = IP.ReadLine();
            IP.Close();
            //Esto es una conexion lalalalalla

            MySqlConnection con = new MySqlConnection("server=" + server + "; database=VALLARTA JUN 2018; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        

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

        public static void CerrarConexion(MySqlConnection con)
        {
            con.Close();
        }

      
    }
}
