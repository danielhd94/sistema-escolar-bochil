using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NServicioSocial
    {
        public static string Insertar(
            Int64 numcontrol,
            String institucionSP,
            DateTime fechainicio,
            DateTime fechatermino,
            DateTime fechaexpconst,
            String observaciones
            )
        {
            DServicioSocial Obj = new DServicioSocial();
            Obj.NumControl = numcontrol;
            Obj.InstitucionSP = institucionSP;
            Obj.FechaInicio = fechainicio;
            Obj.FechaTermino = fechatermino;
            Obj.FechaExpConst = fechaexpconst;
            Obj.Observaciones = observaciones;
            return Obj.Insertar(Obj);
        }

        public static string Editar(
            int idserviciosocial,
            Int64 numcontrol,
            String institucionSP,
            DateTime fechainicio,
            DateTime fechatermino,
            DateTime fechaexpconst,
            String observaciones
            )
        {
            DServicioSocial Obj = new DServicioSocial();
            Obj.IdServicioSocial = idserviciosocial;
            Obj.NumControl = numcontrol;
            Obj.InstitucionSP = institucionSP;
            Obj.FechaInicio = fechainicio;
            Obj.FechaTermino = fechatermino;
            Obj.FechaExpConst = fechaexpconst;
            Obj.Observaciones = observaciones;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idserviciosocial)
        {
            DServicioSocial Obj = new DServicioSocial();
            Obj.IdServicioSocial = idserviciosocial;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DServicioSocial().Mostrar();
        }
        public static DataTable BuscarNumControl(string textobuscar)
        {
            DServicioSocial Obj = new DServicioSocial();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNumControl(Obj);
        }
    }
}
