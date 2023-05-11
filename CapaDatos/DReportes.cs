using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DReportes
    {
        //Variables
        private int _IdReportes;
        private Int64 _NumControl;
        private DateTime _FechaReporte;

        
        private string _Motivo;        
        private String _TextoBuscar;
             
        public int IdReportes
        {
          get { return _IdReportes; }
          set { _IdReportes = value; }
        }
        public Int64 NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }
        public DateTime FechaReporte
        {
            get { return _FechaReporte; }
            set { _FechaReporte = value; }
        }
        public string Motivo
        {
          get { return _Motivo; }
          set { _Motivo = value; }
        }
        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public DReportes()
        {

        }

        public DReportes(int idreporte, Int64 numcontrol, DateTime fechareporte, String motivo, String textobuscar)
        {
            this.IdReportes = idreporte;
            this.NumControl = numcontrol;
            this.FechaReporte = fechareporte;
            this.Motivo = motivo;
            this.TextoBuscar = textobuscar;

        }

        //Métodos
        public string Insertar(DReportes reportes)
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
                SqlCmd.CommandText = "spinsertar_reportes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReportes = new SqlParameter();
                ParIdReportes.ParameterName = "@idReportes";
                ParIdReportes.SqlDbType = SqlDbType.Int;
                ParIdReportes.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdReportes);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = reportes.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaFechaReporte = new SqlParameter();
                ParaFechaReporte.ParameterName = "@fechaReporte";
                ParaFechaReporte.SqlDbType = SqlDbType.DateTime;
                ParaFechaReporte.Value = reportes.FechaReporte;
                SqlCmd.Parameters.Add(ParaFechaReporte);

                SqlParameter ParaMotivo = new SqlParameter();
                ParaMotivo.ParameterName = "@motivoReporte";
                ParaMotivo.SqlDbType = SqlDbType.VarChar;
                ParaMotivo.Size = 100;
                ParaMotivo.Value = reportes.Motivo;
                SqlCmd.Parameters.Add(ParaMotivo);

                
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
        public string Editar(DReportes reportes)
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
                SqlCmd.CommandText = "speditar_reportes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReportes = new SqlParameter();
                ParIdReportes.ParameterName = "@idReportes";
                ParIdReportes.SqlDbType = SqlDbType.Int;
                ParIdReportes.Value = reportes.IdReportes;
                SqlCmd.Parameters.Add(ParIdReportes);

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = reportes.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParaFechaReporte = new SqlParameter();
                ParaFechaReporte.ParameterName = "@fechaReporte";
                ParaFechaReporte.SqlDbType = SqlDbType.DateTime;
                ParaFechaReporte.Value = reportes.FechaReporte;
                SqlCmd.Parameters.Add(ParaFechaReporte);

                SqlParameter ParaMotivo = new SqlParameter();
                ParaMotivo.ParameterName = "@motivoReporte";
                ParaMotivo.SqlDbType = SqlDbType.VarChar;
                ParaMotivo.Size = 100;
                ParaMotivo.Value = reportes.Motivo;
                SqlCmd.Parameters.Add(ParaMotivo);
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
        public string Eliminar(DReportes reportes)
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
                SqlCmd.CommandText = "speliminar_Reportes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReportes = new SqlParameter();
                ParIdReportes.ParameterName = "@idReportes";
                ParIdReportes.SqlDbType = SqlDbType.Int;
                ParIdReportes.Value = reportes.IdReportes;
                SqlCmd.Parameters.Add(ParIdReportes);


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
            DataTable DtResultado = new DataTable("Reportes");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_reportes";
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
        public DataTable BuscarNumControl(DReportes reportes)
        {
            DataTable DtResultado = new DataTable("Reportes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_reporte_numcontrol";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 30;
                ParTextoBuscar.Value = reportes.TextoBuscar;
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
