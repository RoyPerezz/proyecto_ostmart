using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class FormatoFecha
    {

        public String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

    }
}
