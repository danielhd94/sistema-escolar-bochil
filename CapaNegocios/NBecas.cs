using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NBeca
    {
        public static string Insertar(int validacionBId, Int64 numControl, string modalidad, string estadoBeca, DateTime fechaValidacion)
        {
            DBeca Obj = new DBeca();
            Obj.ValidacionBId = validacionBId;
            Obj.NumControl = numControl;
            Obj.Modalidad = modalidad;
            Obj.EstadoBeca = estadoBeca;
            Obj.FechaValidacion = fechaValidacion;

            return Obj.Insertar(Obj);
        }


        public static string Editar(int validacionBId, Int64 numControl, string modalidad, string estadoBeca, DateTime fechaValidacion)
        {
            DBeca Obj = new DBeca();
            Obj.ValidacionBId = validacionBId;
            Obj.NumControl = numControl;
            Obj.Modalidad = modalidad;
            Obj.EstadoBeca = estadoBeca;
            Obj.FechaValidacion = fechaValidacion;

            return Obj.Editar(Obj);
        }
        public static string Eliminar(int validacionBId)
        {
            DBeca Obj = new DBeca();
            Obj.ValidacionBId = validacionBId;
            //Obj.NumControl = numControl;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DBeca().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DBeca Obj = new DBeca();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
