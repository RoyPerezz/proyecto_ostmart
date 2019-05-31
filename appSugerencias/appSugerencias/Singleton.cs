using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class Singleton
    {
        private static Singleton instancia;
        private string sucursal;

        public static Singleton obtenerInstancia()
        {
            if (instancia == null )
            {
                instancia = new Singleton();
            }
           

            return instancia;

           
        }

        public void nombreTienda(string nombre)
        {
             sucursal = nombre;

           
        }

        public string getNombreTienda()
        {
            return sucursal;
        }

      
    }
}
