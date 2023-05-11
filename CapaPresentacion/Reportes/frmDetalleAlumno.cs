using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleAlumno : Form{
    

        Int64 _NumControl;
        Int64 _NumControlR;

        public Int64 NumControlR
        {
            get { return _NumControlR; }
            set { _NumControlR = value; }
        }

public Int64 NumControl
{
  get { return _NumControl; }
  set { _NumControl = value; }
}
        public frmDetalleAlumno()
        {
            InitializeComponent();
        }

        private void frmDetalleAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_seguro' Puede moverla o quitarla según sea necesario.
                this.spdetalle_seguroTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_seguro, NumControl);
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_servicios' Puede moverla o quitarla según sea necesario.
                this.spdetalle_serviciosTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_servicios, NumControl);
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_practicas' Puede moverla o quitarla según sea necesario.
                this.spdetalle_practicasTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_practicas, NumControl);

                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_emprendedores' Puede moverla o quitarla según sea necesario.
                this.spdetalle_emprendedoresTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_emprendedores, NumControl);
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_becas' Puede moverla o quitarla según sea necesario.
                this.spdetalle_becasTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_becas, NumControl);
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_permisos' Puede moverla o quitarla según sea necesario.
                this.spdetalle_permisosTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_permisos, NumControl);
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalle_reportes' Puede moverla o quitarla según sea necesario.
                this.spdetalle_reportesTableAdapter.Fill(this.dsDetalle_Alumno.spdetalle_reportes, NumControlR);
                // TODO: esta línea de código carga datos en la tabla 'dsDetalle_Alumno.spdetalleAlumno' Puede moverla o quitarla según sea necesario.
                this.spdetalleAlumnoTableAdapter.Fill(this.dsDetalle_Alumno.spdetalleAlumno, NumControl);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception err)
            {

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
