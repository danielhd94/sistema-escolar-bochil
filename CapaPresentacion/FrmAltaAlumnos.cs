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
    public partial class FrmAltaAlumnos : Form
    {
        public FrmAltaAlumnos()
        {
            InitializeComponent();
        }

        private void cmbEscProcedencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEscProcedencia.Text.Equals("Otra..."))
            {
                this.txtOtraProc.Visible = true;
            }

            else
            {
                this.txtOtraProc.Visible = false;
            }

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

        private void FrmAltaAlumnos_Load(object sender, EventArgs e)
        {
            this.txtOtraProc.Visible= false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           

            if (this.txtOtraProc.Visible == true)
            {
                this.txtOtraProc.Visible = false;
            }

            txtApellidoMa.Clear();
            txtApellidoPa.Clear();
            txtCurp.Clear();
            txtnControl.Clear();
            txtNombre.Clear();
            cmbGrupo.Text ="<Seleccionar>";
            cmbSemestre.Text = "<Seleccionar>";
            cmbCarrera.Text = "<Opciones>";
            cmbEscProcedencia.Text = "<Opciones>";
            


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string procedencia="";
            string rpta = "";
            String genero="";
            try
            {

                procedencia = this.cmbEscProcedencia.Text == "Otra..." ? procedencia = this.txtOtraProc.Text : procedencia = this.cmbEscProcedencia.Text; ;
                genero = this.rbMasculino.Checked== true ? "H" : "M";

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.imgAlumno.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imagen = ms.GetBuffer();


                rpta = NAlumnos.Insertar(Convert.ToInt32(this.txtnControl.Text.Trim()), this.txtNombre.Text.Trim().ToUpper(),
                 this.txtApellidoPa.Text.Trim().ToUpper(), this.txtApellidoMa.Text.Trim().ToUpper(),
                 this.cmbSemestre.Text, Convert.ToInt32(this.cmbGrupo.Text), Convert.ToInt32(this.cmbCarrera.Text), this.txtCurp.Text.Trim().ToUpper(),
                 genero,procedencia,"ruta");

                if (rpta.Equals("OK"))
                {
                    
                        this.MensajeOk("Se Insertó de forma correcta el registro");
                }else{
                        this.MensajeError(rpta);
               }
               
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.imgAlumno.SizeMode = PictureBoxSizeMode.StretchImage;
                this.imgAlumno.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.imgAlumno.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imgAlumno.Image = global::CapaPresentacion.Properties.Resources.iconoImagen;
        }

        private void cmbEscProcedencia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEscProcedencia.Text.Equals("Otra..."))
            {
                this.txtOtraProc.Visible = true;
            }

            else
            {
                this.txtOtraProc.Visible = false;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.txtApellidoMa.Clear();
            this.txtApellidoPa.Clear();
            this.txtCurp.Clear();
            this.txtnControl.Clear();
            this.txtNombre.Clear();
            this.txtOtraProc.Clear();
            this.txtOtraProc.Visible = false;
            this.cmbCarrera.Text = "<Opciones>";
            this.cmbSemestre.Text = "<Seleccionar>";
            this.cmbGrupo.Text = "<Seleccionar>";
            this.cmbEscProcedencia.Text="<Opciones>";

            this.rbMasculino.Checked = false;
            this.rbFemenino.Checked = false;



        }

        
    
    }
}
