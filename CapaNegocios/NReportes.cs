using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NReportes
    {
        public static string Insertar(Int64 numcontrol, String motivo, DateTime fechareporte)
        {
            DReportes Obj = new DReportes();
            Obj.NumControl = numcontrol;            
            Obj.FechaReporte = fechareporte;
            Obj.Motivo = motivo;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idreporte, Int64 numcontrol, String motivo, DateTime fechareporte)
        {
            DReportes Obj = new DReportes();
            Obj.IdReportes = idreporte;
            Obj.NumControl = numcontrol;
            Obj.FechaReporte = fechareporte;
            Obj.Motivo = motivo;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idreportes)
        {
            DReportes Obj = new DReportes();
            Obj.IdReportes = idreportes;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DReportes().Mostrar();
        }
        public static DataTable BuscarNumControl(string textobuscar)
        {
            DReportes Obj = new DReportes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNumControl(Obj);
        }
    }
}
