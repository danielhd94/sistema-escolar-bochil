using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DEmprendedores
    {
        //Variables
        private int _IdEmprendedores;               
        private string _Actividad;
        private String _TextoBuscar;
        private Int64 _NumControl;

        public int IdEmprendedores
        {
            get { return _IdEmprendedores; }
            set { _IdEmprendedores = value; }
        }
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }        
        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        public Int64 NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }
        

        //Constructores
        public DEmprendedores()
        {

        }

        public DEmprendedores(int idemprendedores, string actividad, String textobuscar)
        {
            this.IdEmprendedores = idemprendedores;
            this.Actividad = actividad;            
            this.TextoBuscar = textobuscar;

        }

        //Métodos
        public string Insertar(DEmprendedores emprendedores)
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
                SqlCmd.CommandText = "spinsertar_emprendedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl_emp";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = emprendedores.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParactividadEmp = new SqlParameter();
                ParactividadEmp.ParameterName = "@actividad_emp";
                ParactividadEmp.SqlDbType = SqlDbType.VarChar;
                ParactividadEmp.Size = 50;
                ParactividadEmp.Value = emprendedores.Actividad;
                SqlCmd.Parameters.Add(ParactividadEmp);
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
        public string Editar(DEmprendedores emprendedores)
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
                SqlCmd.CommandText = "speditar_emprendedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@idEmprendedores";
                ParNumControl.SqlDbType = SqlDbType.Int;
                ParNumControl.Value = emprendedores.IdEmprendedores;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParactividadEmp = new SqlParameter();
                ParactividadEmp.ParameterName = "@actividad_emp";
                ParactividadEmp.SqlDbType = SqlDbType.VarChar;
                ParactividadEmp.Size = 50;
                ParactividadEmp.Value = emprendedores.Actividad;
                SqlCmd.Parameters.Add(ParactividadEmp);

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
        public string Eliminar(DEmprendedores emprendedores)
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
                SqlCmd.CommandText = "speliminar_emprendedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmprendedor = new SqlParameter();
                ParIdEmprendedor.ParameterName = "@idEmprendedores";
                ParIdEmprendedor.SqlDbType = SqlDbType.Int;
                ParIdEmprendedor.Value = emprendedores.IdEmprendedores;
                SqlCmd.Parameters.Add(ParIdEmprendedor);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Ocurrió un erro al eliminar el registro";


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
            DataTable DtResultado = new DataTable("Emprendedores");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_emprendedores";
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
        public DataTable BuscarNombre(DEmprendedores emprendedores)
        {
            DataTable DtResultado = new DataTable("Emprendedores");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_emprendedor_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 30;
                ParTextoBuscar.Value = emprendedores.TextoBuscar;
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
