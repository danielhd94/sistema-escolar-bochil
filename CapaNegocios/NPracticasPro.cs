using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPracticasPro
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
            DPracticasPro Obj = new DPracticasPro();
            Obj.NumControl = numcontrol;
            Obj.InstitucionSP = institucionSP;
            Obj.FechaInicio = fechainicio;
            Obj.FechaTermino = fechatermino;
            Obj.FechaExpConst = fechaexpconst;
            Obj.Observaciones = observaciones;
            return Obj.Insertar(Obj);
        }

        public static string Editar(
            int idpracticaspro,
            Int64 numcontrol,
            String institucionSP,
            DateTime fechainicio,
            DateTime fechatermino,
            DateTime fechaexpconst,
            String observaciones
            )
        {
            DPracticasPro Obj = new DPracticasPro();
            Obj.IdPracticasProfesionales = idpracticaspro;
            Obj.NumControl = numcontrol;
            Obj.InstitucionSP = institucionSP;
            Obj.FechaInicio = fechainicio;
            Obj.FechaTermino = fechatermino;
            Obj.FechaExpConst = fechaexpconst;
            Obj.Observaciones = observaciones;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idpracticasPro)
        {
            DPracticasPro Obj = new DPracticasPro();
            Obj.IdPracticasProfesionales = idpracticasPro;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DPracticasPro().Mostrar();
        }
        public static DataTable BuscarNumControl(string textobuscar)
        {
            DPracticasPro Obj = new DPracticasPro();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNumControl(Obj);
        }
        
    }
}
