using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
   public class Nusuario
    {
       public static DataTable Login(string usuario, string password)
       {
           DUsuarios Obj = new DUsuarios();  
           Obj.Usuario = usuario;
           Obj.Password = password;
           return Obj.Login(Obj);
       }

        public static DataTable Login(string password)
        {
            DUsuarios Obj = new DUsuarios();            
            Obj.Password = password;
            return Obj.Login(Obj);
        }

        public static string EditarAdmin(int idusuario, string contranueva)
        {
            DUsuarios Obj = new DUsuarios();
            Obj.IdUsuario = idusuario;
            Obj.ContraNueva = contranueva;
            return Obj.EditarAdmin(Obj);
        }

    }
}
