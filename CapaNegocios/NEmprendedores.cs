using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NEmprendedores
    {
        public static string Insertar(Int64 numControl, string actividad)
        {
            DEmprendedores Obj = new DEmprendedores();
            Obj.NumControl = numControl;
            Obj.Actividad = actividad;            
            return Obj.Insertar(Obj);
        }


        public static string Editar(int idemprendedores, string actividad)
        {
            DEmprendedores Obj = new DEmprendedores();
            Obj.IdEmprendedores = idemprendedores;
            Obj.Actividad = actividad;           
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idemprendedores)
        {
            DEmprendedores Obj = new DEmprendedores();
            Obj.IdEmprendedores = idemprendedores;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DEmprendedores().Mostrar();
        }
        public static DataTable BuscarNombre(string textobuscar)
        {
            DEmprendedores Obj = new DEmprendedores();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
