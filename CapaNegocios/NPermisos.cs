using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NPermisos
    {
        public static string Insertar(Int64 numcontrol, String motivo, DateTime fechapermiso)
        {
            DPermisos Obj = new DPermisos();
            Obj.NumControl = numcontrol;
            Obj.Motivo = motivo;
            Obj.FechaPerm = fechapermiso;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idpermiso,Int64 numcontrol, String motivo, DateTime fechapermiso)
        {
            DPermisos Obj = new DPermisos();
            Obj.IdPermiso = idpermiso;
            Obj.NumControl = numcontrol;
            Obj.Motivo = motivo;
            Obj.FechaPerm = fechapermiso;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idpermiso)
        {
            DPermisos Obj = new DPermisos();
            Obj.IdPermiso = idpermiso;
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DPermisos().Mostrar();
        }
        public static DataTable BuscarNumControl(string textobuscar)
        {
            DPermisos Obj = new DPermisos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNumControl(Obj);
        }
        
    }
}
