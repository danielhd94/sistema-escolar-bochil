using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSeguro
    {
        //Variables
        private int _IdAfiliacion;
        private Int64 _NumControl;
        private DateTime _FechaMovimeinto;
        private String _TextoBuscar;

        public int IdAfiliacion
        {
            get { return _IdAfiliacion; }
            set { _IdAfiliacion = value; }
        }
        public Int64 NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }
        public DateTime FechaMovimeinto
        {
            get { return _FechaMovimeinto; }
            set { _FechaMovimeinto = value; }
        }
        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public DSeguro()
        {

        }

        public DSeguro(int idAfiliacion, Int64 numcontrol, DateTime fechaMovimiento, String textobuscar)
        {
            this.IdAfiliacion = idAfiliacion;
            this.NumControl = numcontrol;
            this.FechaMovimeinto = fechaMovimiento;
            this.TextoBuscar = textobuscar;

        }

        //Métodos
        public string Insertar(DSeguro seguro)
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
                SqlCmd.CommandText = "spinsertar_seguro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAfiliacion = new SqlParameter();
                ParIdAfiliacion.ParameterName = "@idAfiliacion";
                ParIdAfiliacion.SqlDbType = SqlDbType.Int;
                ParIdAfiliacion.Value = seguro.IdAfiliacion;
                SqlCmd.Parameters.Add(ParIdAfiliacion);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = seguro.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaFechaMovimiento = new SqlParameter();
                ParaFechaMovimiento.ParameterName = "@fechaMovimiento";
                ParaFechaMovimiento.SqlDbType = SqlDbType.DateTime;
                ParaFechaMovimiento.Value = seguro.FechaMovimeinto;
                SqlCmd.Parameters.Add(ParaFechaMovimiento);
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
        public string Editar(DSeguro seguro)
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
                SqlCmd.CommandText = "speditar_seguro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAfiliacion = new SqlParameter();
                ParIdAfiliacion.ParameterName = "@idAfiliacion";
                ParIdAfiliacion.SqlDbType = SqlDbType.Int;
                ParIdAfiliacion.Value = seguro.IdAfiliacion;
                SqlCmd.Parameters.Add(ParIdAfiliacion);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = seguro.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaFechaMovimiento = new SqlParameter();
                ParaFechaMovimiento.ParameterName = "@fechaMovimiento";
                ParaFechaMovimiento.SqlDbType = SqlDbType.DateTime;
                ParaFechaMovimiento.Value = seguro.FechaMovimeinto;
                SqlCmd.Parameters.Add(ParaFechaMovimiento);

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
        public string Eliminar(DSeguro seguro)
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
                SqlCmd.CommandText = "speliminar_seguro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAfiliacion = new SqlParameter();
                ParIdAfiliacion.ParameterName = "@idAfiliacion";
                ParIdAfiliacion.SqlDbType = SqlDbType.Int;
                ParIdAfiliacion.Value = seguro.IdAfiliacion;
                SqlCmd.Parameters.Add(ParIdAfiliacion);


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
            DataTable DtResultado = new DataTable("AfiliacionSeguro");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_seguros";
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
        public DataTable BuscarNumControl(DSeguro seguro)
        {
            DataTable DtResultado = new DataTable("AfiliacionSeguro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_seguro_numcontrol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 30;
                ParTextoBuscar.Value = seguro.TextoBuscar;
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
