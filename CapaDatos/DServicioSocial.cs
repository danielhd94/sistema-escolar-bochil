using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DServicioSocial
    {
       //Variables
        private int _IdServicioSocial;
        private Int64 _NumControl;
        private String _InstitucionSP;
        private DateTime _FechaInicio;
        private DateTime _FechaTermino;
        private DateTime _FechaExpConst;
        private string _Observaciones;
        private String _TextoBuscar;

        public int IdServicioSocial
        {
            get { return _IdServicioSocial; }
            set { _IdServicioSocial = value; }
        }
        public Int64 NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }
        public String InstitucionSP
        {
            get { return _InstitucionSP; }
            set { _InstitucionSP = value; }
        }
        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
        public DateTime FechaTermino
        {
            get { return _FechaTermino; }
            set { _FechaTermino = value; }
        }
        public DateTime FechaExpConst
        {
            get { return _FechaExpConst; }
            set { _FechaExpConst = value; }
        }
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }
        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public DServicioSocial()
        {

        }
        public DServicioSocial(
            int idServicioSocial,
            Int64 numcontrol,
            String institucionSP, 
            DateTime fechainicio,
            DateTime fechatermino,
            DateTime fechaexpconst,
            String observaciones,
            String textobuscar)
        {
            this.IdServicioSocial = idServicioSocial;
            this.NumControl = numcontrol;
            this.InstitucionSP = institucionSP;
            this.FechaInicio = fechainicio;
            this.FechaTermino = fechatermino;
            this.FechaExpConst = fechaexpconst;
            this.Observaciones = observaciones;
            this.TextoBuscar = textobuscar;

        }

        //Métodos
        public string Insertar(DServicioSocial serviciosocial)
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
                SqlCmd.CommandText = "spinsertar_servicio_social";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPracticas = new SqlParameter();
                ParIdPracticas.ParameterName = "@idServicioSocial";
                ParIdPracticas.SqlDbType = SqlDbType.Int;
                ParIdPracticas.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPracticas);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = serviciosocial.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaMotivo = new SqlParameter();
                ParaMotivo.ParameterName = "@institucionSP";
                ParaMotivo.SqlDbType = SqlDbType.VarChar;
                ParaMotivo.Size = 50;
                ParaMotivo.Value = serviciosocial.InstitucionSP;
                SqlCmd.Parameters.Add(ParaMotivo);

                SqlParameter ParaFechaInicio = new SqlParameter();
                ParaFechaInicio.ParameterName = "@fechainicio";
                ParaFechaInicio.SqlDbType = SqlDbType.DateTime;
                ParaFechaInicio.Value = serviciosocial.FechaInicio;
                SqlCmd.Parameters.Add(ParaFechaInicio);

                SqlParameter ParaFechaTermino = new SqlParameter();
                ParaFechaTermino.ParameterName = "@fechaTermino";
                ParaFechaTermino.SqlDbType = SqlDbType.DateTime;
                ParaFechaTermino.Value = serviciosocial.FechaTermino;
                SqlCmd.Parameters.Add(ParaFechaTermino);

                SqlParameter ParaFechaExpConst = new SqlParameter();
                ParaFechaExpConst.ParameterName = "@fechaexpconst";
                ParaFechaExpConst.SqlDbType = SqlDbType.DateTime;
                ParaFechaExpConst.Value = serviciosocial.FechaExpConst;
                SqlCmd.Parameters.Add(ParaFechaExpConst);

                SqlParameter ParaObservaciones = new SqlParameter();
                ParaObservaciones.ParameterName = "@observaciones";
                ParaObservaciones.SqlDbType = SqlDbType.VarChar;
                ParaObservaciones.Size = 150;
                ParaObservaciones.Value = serviciosocial.Observaciones;
                SqlCmd.Parameters.Add(ParaObservaciones);
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
        public string Editar(DServicioSocial serviciosocial)
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
                SqlCmd.CommandText = "speditar_servicio_social";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPracticas = new SqlParameter();
                ParIdPracticas.ParameterName = "@idServicioSocial";
                ParIdPracticas.SqlDbType = SqlDbType.Int;
                ParIdPracticas.Value = serviciosocial.IdServicioSocial;
                SqlCmd.Parameters.Add(ParIdPracticas);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = serviciosocial.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaMotivo = new SqlParameter();
                ParaMotivo.ParameterName = "@institucionSP";
                ParaMotivo.SqlDbType = SqlDbType.VarChar;
                ParaMotivo.Size = 50;
                ParaMotivo.Value = serviciosocial.InstitucionSP;
                SqlCmd.Parameters.Add(ParaMotivo);

                SqlParameter ParaFechaInicio = new SqlParameter();
                ParaFechaInicio.ParameterName = "@fechainicio";
                ParaFechaInicio.SqlDbType = SqlDbType.DateTime;
                ParaFechaInicio.Value = serviciosocial.FechaInicio;
                SqlCmd.Parameters.Add(ParaFechaInicio);

                SqlParameter ParaFechaTermino = new SqlParameter();
                ParaFechaTermino.ParameterName = "@fechaTermino";
                ParaFechaTermino.SqlDbType = SqlDbType.DateTime;
                ParaFechaTermino.Value = serviciosocial.FechaTermino;
                SqlCmd.Parameters.Add(ParaFechaTermino);

                SqlParameter ParaFechaExpConst = new SqlParameter();
                ParaFechaExpConst.ParameterName = "@fechaexpconst";
                ParaFechaExpConst.SqlDbType = SqlDbType.DateTime;
                ParaFechaExpConst.Value = serviciosocial.FechaExpConst;
                SqlCmd.Parameters.Add(ParaFechaExpConst);

                SqlParameter ParaObservaciones = new SqlParameter();
                ParaObservaciones.ParameterName = "@observaciones";
                ParaObservaciones.SqlDbType = SqlDbType.VarChar;
                ParaObservaciones.Size = 150;
                ParaObservaciones.Value = serviciosocial.Observaciones;
                SqlCmd.Parameters.Add(ParaObservaciones);

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
        public string Eliminar(DServicioSocial serviciosocial)
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
                SqlCmd.CommandText = "speliminar_servicio_social";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPracticas = new SqlParameter();
                ParIdPracticas.ParameterName = "@idServicioSocial";
                ParIdPracticas.SqlDbType = SqlDbType.Int;
                ParIdPracticas.Value = serviciosocial.IdServicioSocial;
                SqlCmd.Parameters.Add(ParIdPracticas);


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
            DataTable DtResultado = new DataTable("Servicios");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_servicio_social";
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
        public DataTable BuscarNumControl(DServicioSocial serviciosocial)
        {
            DataTable DtResultado = new DataTable("Servicios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_servicioSocial_numcontrol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 30;
                ParTextoBuscar.Value = serviciosocial.TextoBuscar;
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
