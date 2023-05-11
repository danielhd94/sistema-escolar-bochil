using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NSeguro
    {
        public static string Insertar(int idAfiliacion, Int64 numcontrol, DateTime fechamovimiento)
        {
            DSeguro Obj = new DSeguro();
            Obj.IdAfiliacion = idAfiliacion;
            Obj.NumControl = numcontrol;
            Obj.FechaMovimeinto = fechamovimiento;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idAfiliacion, Int64 numcontrol, DateTime fechamovimiento)
        {
            DSeguro Obj = new DSeguro();
            Obj.IdAfiliacion = idAfiliacion;
            Obj.NumControl = numcontrol;
            Obj.FechaMovimeinto = fechamovimiento;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idafiliacion)
        {
            DSeguro Obj = new DSeguro();
            Obj.IdAfiliacion = idafiliacion;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DSeguro().Mostrar();
        }
        public static DataTable BuscarNumControl(string textobuscar)
        {
            DSeguro Obj = new DSeguro();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNumControl(Obj);
        }
    }
}
