using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmHistorialAlumno : Form
    {
        string r = "";
        public String NumControl="0";   

        public FrmHistorialAlumno()
        {
            InitializeComponent();
        }
        private void FrmHistorialAlumno_Load(object sender, EventArgs e)
        {
            this.DetallesBecas();
            this.DetallesSeguro();
            this.DetallesPP();
            this.DetallesSS();
            this.DetallesEmprendedores();
            this.DetallesPermisos();
            this.DetallesReportes();
        }

        private void DetallesBecas()
        {           
            try
            {
                DataTable Datos = NAlumnos.datosbeca(Convert.ToInt64(NumControl));
                if(Datos.Rows.Count==0){
                    this.lblIdValidacionBec.Text = "- - - -";
                    this.lblIdValidacionBec.ForeColor = Color.Red;

                    this.lblEstado_bec.Text = "Sin beca";
                    this.lblEstado_bec.ForeColor = Color.Red;

                    this.lblFechaValidacionBec.Text = "- - - -";
                    this.lblFechaValidacionBec.ForeColor = Color.Red;
                }                
                this.lblIdValidacionBec.Text = Datos.Rows[0][0].ToString();
                this.lblEstado_bec.Text = Datos.Rows[0][1].ToString();
                this.lblFechaValidacionBec.Text = Datos.Rows[0][2].ToString();
                
            }catch(Exception error){
            }

        }
        private void DetallesSeguro()
        {
            try
            {
                DataTable Datos = NAlumnos.datosseg(Convert.ToInt64(NumControl));
                if (Datos.Rows.Count == 0)
                {
                    this.lblIdAfiliacionSeg.Text = "- - - -";
                    this.lblIdAfiliacionSeg.ForeColor = Color.Red;

                    this.lblFechaMovimientoSeg.Text = "- - - -";
                    this.lblFechaMovimientoSeg.ForeColor = Color.Red;
                }
                this.lblIdAfiliacionSeg.Text = Datos.Rows[0][0].ToString();
                this.lblFechaMovimientoSeg.Text = Datos.Rows[0][1].ToString();
            }
            catch (Exception error)
            {
            }            
        }
        private void DetallesPP()
        {
            try
            {
                DataTable Datos = NAlumnos.datospp(Convert.ToInt64(NumControl));
                if(Datos.Rows.Count==0){
                    this.lblInstitucionPrac.Text = "- - - -";
                    this.lblPeriodoPrac.Text = "- - - -";
                    this.lblFechaExpedicionConstPrac.Text = "- - - -";
                    this.lblObserPrac.Text = "- - - -";
                }
                this.lblInstitucionPrac.Text = Datos.Rows[0][0].ToString();

                DateTime finicio = Convert.ToDateTime(Datos.Rows[0][1]);
                DateTime ftermino = Convert.ToDateTime(Datos.Rows[0][2]);
                String inicio = finicio.ToShortDateString();
                String termino = ftermino.ToShortDateString();

                this.lblPeriodoPrac.Text = inicio + " - " + termino;
                this.lblFechaExpedicionConstPrac.Text = Datos.Rows[0][3].ToString();
                this.lblObserPrac.Text = Datos.Rows[0][4].ToString();
            }
            catch (Exception error)
            {
            }            
        }
        private void DetallesSS()
        {
            try
            {
                DataTable Datos = NAlumnos.datosss(Convert.ToInt64(NumControl));
                if(Datos.Rows.Count==0){
                    this.lblInstitucionSS.Text = "- - - -";
                    this.lblPeriodoSS.Text = "- - - -";
                    this.lblFechaExpconstanciaSS.Text = "- - - -"; ;
                    this.lblObservacionesSS.Text = "- - - -";
                }

                this.lblInstitucionSS.Text = Datos.Rows[0][0].ToString();

                DateTime finicio = Convert.ToDateTime(Datos.Rows[0][1]);
                DateTime ftermino = Convert.ToDateTime(Datos.Rows[0][2]);
                String inicio = finicio.ToShortDateString();
                String termino = ftermino.ToShortDateString();

                this.lblPeriodoSS.Text = inicio + " - " + termino;
                this.lblFechaExpconstanciaSS.Text = Datos.Rows[0][3].ToString();
                this.lblObservacionesSS.Text = Datos.Rows[0][4].ToString();
            }
            catch (Exception error)
            {
            }            
        }
        private void DetallesEmprendedores()
        {
            try
            {
                DataTable Datos = NAlumnos.datosemp(Convert.ToInt64(NumControl));
                if(Datos.Rows.Count==0){
                    this.lblProyecto.Text = "- - - -";
                }
                this.lblProyecto.Text = Datos.Rows[0][0].ToString();
            }
            catch (Exception error)
            {
            }            
        }
        private void DetallesPermisos()
        {
            try
            {
                DataTable Datos = NAlumnos.datosper(Convert.ToInt64(NumControl));
                if(Datos.Rows.Count==0){
                    this.lblNoPermisos.Text = "- - - -"; ;
                    this.lblMotivoPerm.Text = "- - - -"; ;
                    this.lblFechaPermiso.Text = "- - - -"; ;
                }
                this.lblNoPermisos.Text = Datos.Rows[0][0].ToString();
                this.lblMotivoPerm.Text = Datos.Rows[0][1].ToString();
                this.lblFechaPermiso.Text = Datos.Rows[0][2].ToString();
            }
            catch (Exception error)
            {
            }
            
        }
        private void DetallesReportes()
        {
            try
            {
                DataTable Datos = NAlumnos.datosrep(Convert.ToInt64(NumControl));
                if(Datos.Rows.Count==0){
                    this.lblNoReportes.Text = "- - - -";
                    this.lblMotivoReporte.Text = "- - - -";
                    this.lblFechaReporte.Text = "- - - -";
                }
                this.lblNoReportes.Text = Datos.Rows[0][0].ToString();
                this.lblMotivoReporte.Text = Datos.Rows[0][1].ToString();
                this.lblFechaReporte.Text = Datos.Rows[0][2].ToString();
            }
            catch (Exception error)
            {
            }            
        }

        public void setInfo(
            string numControl,
            string apellidoPa,
            string apellidoMa,
            string nombre,
            string semestre,
            string grupo,
            string carrera,
            string curp,
            string genero,
            string procedencia,
            string ruta
            )
        {

            this.lblNumControl.Text = numControl;
            this.lblNombre.Text = apellidoPa+" "+apellidoMa+", "+nombre ;
            this.lblSemestre.Text = semestre;
            this.lblGrupo.Text = grupo;
            this.lblCarrera.Text = carrera;
            this.lblCurp.Text = curp;
            /*
            if (genero == true)
            {
                this.lblGenero.Text = "M";
            }
            else
            {
                this.lblGenero.Text = "F";
            }
            */
            this.lblGenero.Text = genero;

            this.lblProcedencia.Text = procedencia;
            r = ruta;
            if (r != "")
            {
                this.imgAlumno.Load(r);
            }
            else
            {
                this.imgAlumno.BackgroundImage = global::CapaPresentacion.Properties.Resources.iconoImagen;
            }

        }

        private void btnListaAlumnos_Click(object sender, EventArgs e)
        {            
            this.Close();     
        }


    }
}
