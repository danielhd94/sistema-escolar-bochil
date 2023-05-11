using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPermisos
    {
        //Variables
        private int _IdPermiso;

        public int IdPermiso
        {
            get { return _IdPermiso; }
            set { _IdPermiso = value; }
        }
        private Int64 _NumControl;      
        private string _Motivo;
        private DateTime _FechaPerm;
        private String _TextoBuscar;
             
        public Int64 NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }
        public string Motivo
        {
          get { return _Motivo; }
          set { _Motivo = value; }
        }
        public DateTime FechaPerm
        {
          get { return _FechaPerm; }
          set { _FechaPerm = value; }
        }
        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public DPermisos()
        {

        }

        public DPermisos(int idpermisos, Int64 numcontrol,String motivo,DateTime fechapermiso, String textobuscar)
        {
            this.IdPermiso = idpermisos;
            this.NumControl = numcontrol;
            this.Motivo = motivo;
            this.FechaPerm = fechapermiso;
            this.TextoBuscar = textobuscar;

        }

        //Métodos
        public string Insertar(DPermisos permisos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_permisos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPermisos = new SqlParameter();
                ParIdPermisos.ParameterName = "@idpermisos";
                ParIdPermisos.SqlDbType = SqlDbType.Int;
                ParIdPermisos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPermisos);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = permisos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaMotivo = new SqlParameter();
                ParaMotivo.ParameterName = "@motivoPermiso";
                ParaMotivo.SqlDbType = SqlDbType.VarChar;
                ParaMotivo.Size = 50;
                ParaMotivo.Value = permisos.Motivo;
                SqlCmd.Parameters.Add(ParaMotivo);

                SqlParameter ParaFechaPermiso = new SqlParameter();
                ParaFechaPermiso.ParameterName = "@fechaPermiso";
                ParaFechaPermiso.SqlDbType = SqlDbType.DateTime;
                ParaFechaPermiso.Value = permisos.FechaPerm;
                SqlCmd.Parameters.Add(ParaFechaPermiso);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Ocurrió un error al guardar";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        //Método Editar
        public string Editar(DPermisos permisos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_permisos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPermisos = new SqlParameter();
                ParIdPermisos.ParameterName = "@idpermisos";
                ParIdPermisos.SqlDbType = SqlDbType.Int;
                ParIdPermisos.Value = permisos.IdPermiso;
                SqlCmd.Parameters.Add(ParIdPermisos);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = permisos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaMotivo = new SqlParameter();
                ParaMotivo.ParameterName = "@motivoPermiso";
                ParaMotivo.SqlDbType = SqlDbType.VarChar;
                ParaMotivo.Size = 50;
                ParaMotivo.Value = permisos.Motivo;
                SqlCmd.Parameters.Add(ParaMotivo);

                SqlParameter ParaFechaPermiso = new SqlParameter();
                ParaFechaPermiso.ParameterName = "@fechaPermiso";
                ParaFechaPermiso.SqlDbType = SqlDbType.DateTime;
                ParaFechaPermiso.Value = permisos.FechaPerm;
                SqlCmd.Parameters.Add(ParaFechaPermiso);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó correctamente el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        //Método Eliminar
        public string Eliminar(DPermisos permisos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_permiso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPermiso = new SqlParameter();
                ParIdPermiso.ParameterName = "@idpermiso";
                ParIdPermiso.SqlDbType = SqlDbType.Int;
                ParIdPermiso.Value = permisos.IdPermiso;
                SqlCmd.Parameters.Add(ParIdPermiso);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Ocurrió un error al eliminar el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Permisos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_permisos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;

        }
       
        //Método BuscarNombre
        public DataTable BuscarNumControl(DPermisos permisos)
        {
            DataTable DtResultado = new DataTable("Permisos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_permiso_numcontrol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 30;
                ParTextoBuscar.Value = permisos.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
