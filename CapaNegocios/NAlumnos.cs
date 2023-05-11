using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class NAlumnos
    {
        public static string Insertar(Int64 numControl, string nombre, string apellidopa, string apellidoma,
            string semestre, int idgrupo, int idcarreras, string curp, string genero, string procedencia,string ruta)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            Obj.Nombre = nombre;
            Obj.ApellidosPa = apellidopa;
            Obj.ApellidosMa = apellidoma;
            Obj.Semestre = semestre;
            Obj.IdGrupo = idgrupo;
            Obj.IdCarreras = idcarreras;
            Obj.Curp = curp;
            Obj.Genero = genero;
            Obj.Procedencia = procedencia;
            Obj.Ruta = ruta;
            return Obj.Insertar(Obj);
        }


        public static string Editar(Int64 numControl, string nombre, string apellidopa, string apellidoma,
            string semestre, int idgrupo,int idcarreras, string curp, string genero, string procedencia,string ruta)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            Obj.Nombre = nombre;
            Obj.ApellidosPa = apellidopa;
            Obj.ApellidosMa = apellidoma;
            Obj.Semestre = semestre;
            Obj.IdGrupo = idgrupo;
            Obj.IdCarreras = idcarreras;
            Obj.Curp = curp;
            Obj.Genero = genero;
            Obj.Procedencia = procedencia;
            Obj.Ruta = ruta;
            return Obj.Editar(Obj);
        }        
        public static string Eliminar(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.Eliminar(Obj);
        }       
        public static DataTable Mostrar()
        {
            return new DAlumnos().Mostrar();
        }


        public static DataTable datosbeca(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datosbeca(Obj);
        }
        public static DataTable datosseg(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datosseg(Obj);
        }
        public static DataTable datospp(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datospp(Obj);
        }
        public static DataTable datosss(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datosss(Obj);
        }
        public static DataTable datosemp(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datosemp(Obj);
        }
        public static DataTable datosper(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datosper(Obj);
        }
        public static DataTable datosrep(Int64 numControl)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.NumControl = numControl;
            return Obj.datosrep(Obj);
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
