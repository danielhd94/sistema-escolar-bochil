using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DBeca
    {
        //Variables
        private int _ValidacionBId;
        private Int64 _NumControl;
        private string _Modalidad;
        private string _EstadoBeca;
        private DateTime _FechaValidacion;
        private String _TextoBuscar;



        //Propiedades


        public int ValidacionBId
        {
            get { return _ValidacionBId; }
            set { _ValidacionBId = value; }
        }

        public Int64 NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }

        public string Modalidad
        {
            get { return _Modalidad; }
            set { _Modalidad = value; }
        }
        public string EstadoBeca
        {
            get { return _EstadoBeca; }
            set { _EstadoBeca = value; }
        }

        public DateTime FechaValidacion
        {
            get { return _FechaValidacion; }
            set { _FechaValidacion = value; }
        }

        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


        public string Ruta = "";

        //Constructores
        public DBeca()
        {

        }

        public DBeca(int validacionBId, Int64 numControl, string modalidad, string estadoBeca, DateTime fechaValidacion, string textobuscar)
        {
            this.ValidacionBId = validacionBId;
            this.NumControl = numControl;
            this.Modalidad = modalidad;
            this.EstadoBeca = estadoBeca;
            this.FechaValidacion = fechaValidacion;
            this.TextoBuscar = textobuscar;
        }

        //Métodos
        public string Insertar(DBeca beca)
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
                SqlCmd.CommandText = "spinsertar_beca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParidBecas = new SqlParameter();
                ParidBecas.ParameterName = "@validacionBId";
                ParidBecas.SqlDbType = SqlDbType.Int;
                ParidBecas.Value = beca.ValidacionBId;
                SqlCmd.Parameters.Add(ParidBecas);


                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = beca.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParModalidad = new SqlParameter();
                ParModalidad.ParameterName = "@modalidad_bec";
                ParModalidad.SqlDbType = SqlDbType.VarChar;
                ParModalidad.Size = 20;
                ParModalidad.Value = beca.Modalidad;
                SqlCmd.Parameters.Add(ParModalidad);

                SqlParameter ParEstadoBec = new SqlParameter();
                ParEstadoBec.ParameterName = "@estado_bec";
                ParEstadoBec.SqlDbType = SqlDbType.VarChar;
                ParEstadoBec.Size = 20;
                ParEstadoBec.Value = beca.EstadoBeca;
                SqlCmd.Parameters.Add(ParEstadoBec);

                SqlParameter ParFechaValidacion = new SqlParameter();
                ParFechaValidacion.ParameterName = "@fechaValidacion_bec";
                ParFechaValidacion.SqlDbType = SqlDbType.Date;
                ParFechaValidacion.Size = 20;
                ParFechaValidacion.Value = beca.FechaValidacion;
                SqlCmd.Parameters.Add(ParFechaValidacion);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se registro en becas";


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
        public string Editar(DBeca beca)
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
                SqlCmd.CommandText = "speditar_beca";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParidBecas = new SqlParameter();
                ParidBecas.ParameterName = "@validacionBId";
                ParidBecas.SqlDbType = SqlDbType.Int;
                ParidBecas.Value = beca.ValidacionBId;
                SqlCmd.Parameters.Add(ParidBecas);


                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = beca.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParModalidad = new SqlParameter();
                ParModalidad.ParameterName = "@modalidad_bec";
                ParModalidad.SqlDbType = SqlDbType.VarChar;
                ParModalidad.Size = 30;
                ParModalidad.Value = beca.Modalidad;
                SqlCmd.Parameters.Add(ParModalidad);

                SqlParameter ParEstadoBec = new SqlParameter();
                ParEstadoBec.ParameterName = "@estado_bec";
                ParEstadoBec.SqlDbType = SqlDbType.VarChar;
                ParEstadoBec.Size = 30;
                ParEstadoBec.Value = beca.EstadoBeca;
                SqlCmd.Parameters.Add(ParEstadoBec);

                SqlParameter ParFechaValidacion = new SqlParameter();
                ParFechaValidacion.ParameterName = "@fechaValidacion_bec";
                ParFechaValidacion.SqlDbType = SqlDbType.DateTime;
                ParFechaValidacion.Size = 30;
                ParFechaValidacion.Value = beca.FechaValidacion;
                SqlCmd.Parameters.Add(ParFechaValidacion);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó correctamente el Alumno";


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
        public string Eliminar(DBeca beca)
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
                SqlCmd.CommandText = "speliminar_beca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@validacionBId";
                ParIdcliente.SqlDbType = SqlDbType.BigInt;
                ParIdcliente.Value = beca.ValidacionBId;
                SqlCmd.Parameters.Add(ParIdcliente);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Alumno";


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
        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Becas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_becas";
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
        public DataTable BuscarNombre(DBeca beca)
        {
            DataTable DtResultado = new DataTable("Alumnos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 30;
                ParTextoBuscar.Value = beca.TextoBuscar;
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
