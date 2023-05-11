using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NCarrera
    {
        public static DataTable Mostrar()
        {

            return new DCarrera().Mostrar();
        }
    }
}
