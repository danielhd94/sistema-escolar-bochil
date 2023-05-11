using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DAlumnos
    {
        //Variables
        private Int64 _NumControl;       
        private string _Nombre;        
        private string _ApellidosPa;        
        private string _ApellidosMa;
        private byte[] _Imagen;       
        private string _Semestre;        
        private int _IdGrupo;
        private int _IdCarreras;       
        private string _Curp;        
        private String _Genero;        
        private string _Procedencia;
        private String _TextoBuscar;        

        //Propiedades
        public Int64  NumControl
        {
            get { return _NumControl; }
            set { _NumControl = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string ApellidosPa
        {
            get { return _ApellidosPa; }
            set { _ApellidosPa = value; }
        }
        public string ApellidosMa
        {
            get { return _ApellidosMa; }
            set { _ApellidosMa = value; }
        }
        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }
        public string Semestre
        {
            get { return _Semestre; }
            set { _Semestre = value; }
        }
        public int IdGrupo
        {
            get { return _IdGrupo; }
            set { _IdGrupo = value; }
        }
        public int IdCarreras
        {
            get { return _IdCarreras; }
            set { _IdCarreras = value; }
        }
        public string Curp
        {
            get { return _Curp; }
            set { _Curp = value; }
        }
        public String Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
        public string Procedencia
        {
            get { return _Procedencia; }
            set { _Procedencia = value; }
        }
        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public string Ruta = "";

        //Constructores
        public DAlumnos()
        {

        }

        public DAlumnos(int numControl, string nombre, string apellidopa, string apellidoma, byte[] imagen, string semestre,
            int idgrupo, int idcarreras,string curp, string genero, string procedencia,String textobuscar)
        {
            this.NumControl = numControl;
            this.Nombre = nombre;
            this.ApellidosPa = apellidopa;
            this.ApellidosMa = apellidoma;
            this.Imagen = imagen;
            this.Semestre = semestre;
            this.IdGrupo = idgrupo;
            this.IdCarreras = idcarreras;
            this.Curp = curp;
            this.Genero = genero;
            this.Procedencia = procedencia;
            this.TextoBuscar = textobuscar;

        }

        //Métodos
        public string Insertar(DAlumnos alumnos)
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
                SqlCmd.CommandText = "spinsertar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_alu";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = alumnos.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidoPa = new SqlParameter();
                ParApellidoPa.ParameterName = "@apellidoPa_alu";
                ParApellidoPa.SqlDbType = SqlDbType.VarChar;
                ParApellidoPa.Size = 30;
                ParApellidoPa.Value = alumnos.ApellidosPa;
                SqlCmd.Parameters.Add(ParApellidoPa);

                SqlParameter ParApellidoMa = new SqlParameter();
                ParApellidoMa.ParameterName = "@apellidoMa_alu";
                ParApellidoMa.SqlDbType = SqlDbType.VarChar;
                ParApellidoMa.Size = 30;
                ParApellidoMa.Value = alumnos.ApellidosMa;
                SqlCmd.Parameters.Add(ParApellidoMa);


                SqlParameter ParSemestre = new SqlParameter();
                ParSemestre.ParameterName = "@semestre_alu";
                ParSemestre.SqlDbType = SqlDbType.TinyInt;
                ParSemestre.Value = alumnos.Semestre;
                SqlCmd.Parameters.Add(ParSemestre);

                SqlParameter ParIdGrupo = new SqlParameter();
                ParIdGrupo.ParameterName = "@idGrupos";
                ParIdGrupo.SqlDbType = SqlDbType.Int;
                ParIdGrupo.Value = alumnos.IdGrupo;
                SqlCmd.Parameters.Add(ParIdGrupo);

                SqlParameter IdCarreras = new SqlParameter();
                IdCarreras.ParameterName = "@idCarreras";
                IdCarreras.SqlDbType = SqlDbType.Int;
                IdCarreras.Value = alumnos.IdCarreras;
                SqlCmd.Parameters.Add(IdCarreras);

                SqlParameter ParCurp = new SqlParameter();
                ParCurp.ParameterName = "@curp_alu";
                ParCurp.SqlDbType = SqlDbType.VarChar;
                ParCurp.Size = 18;
                ParCurp.Value = alumnos.Curp;
                SqlCmd.Parameters.Add(ParCurp);

                SqlParameter ParGenero= new SqlParameter();
                ParGenero.ParameterName = "@genero_alu";
                ParGenero.SqlDbType = SqlDbType.Char;
                ParGenero.Size = 1;
                ParGenero.Value = alumnos.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParProcedencia = new SqlParameter();
                ParProcedencia.ParameterName = "@procedencia_alu";
                ParProcedencia.SqlDbType = SqlDbType.VarChar;
                ParProcedencia.Size = 20;
                ParProcedencia.Value = alumnos.Procedencia;
                SqlCmd.Parameters.Add(ParProcedencia);

                SqlParameter ParRuta = new SqlParameter();
                ParRuta.ParameterName = "@ruta_alu";
                ParRuta.SqlDbType = SqlDbType.VarChar;
                ParRuta.Value = alumnos.Ruta;
                SqlCmd.Parameters.Add(ParRuta);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Alumno";


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
        public string Editar(DAlumnos alumnos)
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
                SqlCmd.CommandText = "speditar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_alu";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = alumnos.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidoPa = new SqlParameter();
                ParApellidoPa.ParameterName = "@apellidoPa_alu";
                ParApellidoPa.SqlDbType = SqlDbType.VarChar;
                ParApellidoPa.Size = 30;
                ParApellidoPa.Value = alumnos.ApellidosPa;
                SqlCmd.Parameters.Add(ParApellidoPa);

                SqlParameter ParApellidoMa = new SqlParameter();
                ParApellidoMa.ParameterName = "@apellidoMa_alu";
                ParApellidoMa.SqlDbType = SqlDbType.VarChar;
                ParApellidoMa.Size = 30;
                ParApellidoMa.Value = alumnos.ApellidosMa;
                SqlCmd.Parameters.Add(ParApellidoMa);

                SqlParameter ParSemestre = new SqlParameter();
                ParSemestre.ParameterName = "@semestre_alu";
                ParSemestre.SqlDbType = SqlDbType.TinyInt;
                ParSemestre.Value = alumnos.Semestre;
                SqlCmd.Parameters.Add(ParSemestre);

                SqlParameter ParIdGrupo = new SqlParameter();
                ParIdGrupo.ParameterName = "@idGrupos";
                ParIdGrupo.SqlDbType = SqlDbType.Int;
                ParIdGrupo.Value = alumnos.IdGrupo;
                SqlCmd.Parameters.Add(ParIdGrupo);


                SqlParameter IdCarreras = new SqlParameter();
                IdCarreras.ParameterName = "@idCarreras";
                IdCarreras.SqlDbType = SqlDbType.Int;
                IdCarreras.Value = alumnos.IdCarreras;
                SqlCmd.Parameters.Add(IdCarreras);

                SqlParameter ParCurp = new SqlParameter();
                ParCurp.ParameterName = "@curp_alu";
                ParCurp.SqlDbType = SqlDbType.VarChar;
                ParCurp.Size = 18;
                ParCurp.Value = alumnos.Curp;
                SqlCmd.Parameters.Add(ParCurp);

                SqlParameter ParGenero = new SqlParameter();
                ParGenero.ParameterName = "@genero_alu";
                ParGenero.SqlDbType = SqlDbType.Char;
                ParGenero.Size = 1;
                ParGenero.Value = alumnos.Genero;
                SqlCmd.Parameters.Add(ParGenero);

                SqlParameter ParProcedencia = new SqlParameter();
                ParProcedencia.ParameterName = "@procedencia_alu";
                ParProcedencia.SqlDbType = SqlDbType.VarChar;
                ParProcedencia.Size = 20;
                ParProcedencia.Value = alumnos.Procedencia;
                SqlCmd.Parameters.Add(ParProcedencia);

                SqlParameter ParRuta = new SqlParameter();
                ParRuta.ParameterName = "@ruta";
                ParRuta.SqlDbType = SqlDbType.VarChar;
                ParRuta.Value = alumnos.Ruta;
                SqlCmd.Parameters.Add(ParRuta);

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
        public string Eliminar(DAlumnos alumnos)
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
                SqlCmd.CommandText = "speliminar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@numControl";
                ParIdcliente.SqlDbType = SqlDbType.BigInt;
                ParIdcliente.Value = alumnos.NumControl;
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
            DataTable DtResultado = new DataTable("Alumnos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_alumno";
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

        public DataTable datosbeca(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("Becas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_becas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable datosseg(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("AfiliacionSeguro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_seguro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable datospp(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("Practicas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_practicas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable datosss(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("Servicios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_servicios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable datosemp(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("Emprendedores");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_emprendedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable datosper(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("Permisos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_permisos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable datosrep(DAlumnos alumnos)
        {
            DataTable DtResultado = new DataTable("Reportes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdetalle_reportes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumControl = new SqlParameter();
                ParNumControl.ParameterName = "@numControl";
                ParNumControl.SqlDbType = SqlDbType.BigInt;
                ParNumControl.Value = alumnos.NumControl;
                SqlCmd.Parameters.Add(ParNumControl);

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
        public DataTable BuscarNombre(DAlumnos alumnos)
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
                ParTextoBuscar.Value = alumnos.TextoBuscar;
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
