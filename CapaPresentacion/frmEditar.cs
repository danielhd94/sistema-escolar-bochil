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
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
            
        }
        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string procedencia = "";
            string rpta = "";
            String genero = "";
            try
            {

                procedencia = this.cmbEscProcedencia.Text == "Otra..." ? procedencia = this.txtOtraProc.Text : procedencia = this.cmbEscProcedencia.Text; ;
                genero = this.rbMasculino.Checked == true ? "H" : "M";

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.imgAlumno.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imagen = ms.GetBuffer();


                rpta = NAlumnos.Editar(Convert.ToInt32(this.txtnControl.Text.Trim()), this.txtNombre.Text.Trim().ToUpper(),
                 this.txtApellidoPa.Text.Trim().ToUpper(), this.txtApellidoMa.Text.Trim().ToUpper(),
                 this.cmbSemestre.Text, Convert.ToInt32(this.cmbGrupo.Text), Convert.ToInt32(this.cmbCarrera.Text), this.txtCurp.Text.Trim().ToUpper(),
                 genero, procedencia,"ruta");

                if (rpta.Equals("OK"))
                {

                    this.MensajeOk("Se Insertó de forma correcta el registro");
                }
                else
                {
                    this.MensajeError(rpta);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            this.txtOtraProc.Visible = false;
        }

        public void setMantenimiento(
            //numControl, apellidoPa, apellidoMa, nombre, semestre, grupo, carrera, imagenBuffer, curp, procedencia
            string numControl,
            string apellidoPa,
            string apellidoMa,
            string nombre,
            string semestre,
            string grupo,
            string carrera,
            byte[] imagenBuffer2,
            string curp,
            Boolean genero,
            string procedencia
            )
        {

            this.txtnControl.Text = numControl;
            this.txtApellidoPa.Text = apellidoPa;
            this.txtApellidoMa.Text = apellidoMa;
            this.txtNombre.Text = nombre;
            this.cmbSemestre.Text = semestre;
            this.cmbGrupo.Text = grupo;
            this.cmbCarrera.Text = carrera;
            byte[] imagenBuffer1 = imagenBuffer2;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer1);
            this.imgAlumno.Image = Image.FromStream(ms);
            this.imgAlumno.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtCurp.Text = curp;

            if (genero == true)
            {
                this.rbMasculino.Checked = genero;
            }
            else
            {
                this.rbFemenino.Checked = genero;
            }
            
            this.cmbEscProcedencia.Text = procedencia;

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.imgAlumno.SizeMode = PictureBoxSizeMode.StretchImage;
                this.imgAlumno.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            this.imgAlumno.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imgAlumno.Image = global::CapaPresentacion.Properties.Resources.iconoImagen;
        }

        
    }
}
