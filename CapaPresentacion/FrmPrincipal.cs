using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
     
        public String Idadministrador = "";

        public string Idusuario = "";
        public string NombreUsuario = "";
        public string Password = "";
        public string Acceso = "";



        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
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

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();

            
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListaAlumnos Lista_Alumnos = FrmListaAlumnos.GetInstancia();
                Lista_Alumnos.MdiParent = this;
                Lista_Alumnos.Show();
            }catch(Exception err){
                MensajeError("No se pudo iniciar");
            }


        }

        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lblusuario.Text = NombreUsuario;
            this.GestionUsuario();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarDatos cambiar = new FrmCambiarDatos();            
            cambiar.Idusuario = Idusuario;
            cambiar.Usuario = NombreUsuario;
            cambiar.Password = Password;
            cambiar.MdiParent = this;
            cambiar.Show();
        }

        private void GestionUsuario()
        {
            //Controlar los accesos
            if (Acceso == "Administrador")
            {
                this.listaAumnos.Enabled = true;
                this.listaBecarios.Enabled = true;
                this.listaEmprendedores.Enabled = true;
                this.listaPermisos.Enabled = true;
                this.listaReportes.Enabled = true;
                this.listaSeguro.Enabled = true;
                this.listaServicio.Enabled = true;
                this.listaPracticas.Enabled = true;

            }
            else if (Acceso == "Becas")
            {
                this.listaAumnos.Enabled = false;
                this.listaBecarios.Enabled = true;
                this.listaEmprendedores.Enabled = false;
                this.listaPermisos.Enabled = false;
                this.listaReportes.Enabled = false;
                this.listaSeguro.Enabled = false;
                this.listaServicio.Enabled = false;
                this.listaPracticas.Enabled = false;

            }
            else if (Acceso == "ServicioSocial")
            {
                this.listaAumnos.Enabled = false;
                this.listaBecarios.Enabled = false;
                this.listaEmprendedores.Enabled = false;
                this.listaPermisos.Enabled = false;
                this.listaReportes.Enabled = false;
                this.listaSeguro.Enabled = false;
                this.listaServicio.Enabled = true;
                this.listaPracticas.Enabled = false;

            }
            else if (Acceso == "PracticasProfesionales")
            {
                this.listaAumnos.Enabled = false;
                this.listaBecarios.Enabled = false;
                this.listaEmprendedores.Enabled = false;
                this.listaPermisos.Enabled = false;
                this.listaReportes.Enabled = false;
                this.listaSeguro.Enabled = false;
                this.listaServicio.Enabled = false;
                this.listaPracticas.Enabled = true;

            }
            else if (Acceso == "Emprendedores")
            {
                this.listaAumnos.Enabled = false;
                this.listaBecarios.Enabled = false;
                this.listaEmprendedores.Enabled = true;
                this.listaPermisos.Enabled = false;
                this.listaReportes.Enabled = false;
                this.listaSeguro.Enabled = false;
                this.listaServicio.Enabled = false;
                this.listaPracticas.Enabled = false;

            }
            else if (Acceso == "SeguroSocial")
            {
                this.listaAumnos.Enabled = false;
                this.listaBecarios.Enabled = false;
                this.listaEmprendedores.Enabled = false;
                this.listaPermisos.Enabled = false;
                this.listaReportes.Enabled = false;
                this.listaSeguro.Enabled = true;
                this.listaServicio.Enabled = false;
                this.listaPracticas.Enabled = false;

            }
            else
            {
                this.listaAumnos.Enabled = false;
                this.listaBecarios.Enabled = false;
                this.listaEmprendedores.Enabled = false;
                this.listaPermisos.Enabled = false;
                this.listaReportes.Enabled = false;
                this.listaSeguro.Enabled = false;
                this.listaServicio.Enabled = false;
                this.listaPracticas.Enabled = false;

            }
        }

        private void listaDeBecariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBecas alta_becas = FrmBecas.GetInstancia();
                alta_becas.MdiParent = this;
                alta_becas.Show();
            }catch(Exception er){
                MensajeError("No se pudo iniciar");
            }
        }

        private void listaDeEmprendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEmprendedores Actividad_Emprendedores = FrmEmprendedores.GetInstancia();
                Actividad_Emprendedores.MdiParent = this;
                Actividad_Emprendedores.Show();
            }catch(Exception er){
                MensajeError("No se pudo iniciar");
            }
        }

        private void listaDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPermisos Permisos = FrmPermisos.GetInstancia();
                Permisos.MdiParent = this;
                Permisos.Show();
            }
            catch (Exception er)
            {
                MensajeError("No se pudo iniciar");
            }
        }

        private void listaDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportes Reportes = FrmReportes.GetInstancia();
                Reportes.MdiParent = this;
                Reportes.Show();
            }
            catch (Exception er)
            {
                MensajeError("No se pudo iniciar");
            }
        }

        private void listaDeSeguroSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSeguro Alta_Seguro = FrmSeguro.GetInstancia();
                Alta_Seguro.MdiParent = this;
                Alta_Seguro.Show();
            }catch(Exception er){
                MensajeError("No se pudo iniciar");
            }
        }

        private void listaDeServicioSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmServicio Servicio_Social = FrmServicio.GetInstancia();
                Servicio_Social.MdiParent = this;
                Servicio_Social.Show();
            }
            catch (Exception err)
            {
                MensajeError("No se pudo iniciar");
            }
        }

        private void listaDePrácticasProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPracticas Practicas_Profesionales = FrmPracticas.GetInstancia();
                Practicas_Profesionales.MdiParent = this;
                Practicas_Profesionales.Show();
            }catch(Exception err){
                MensajeError("No se pudo iniciar");
            }
        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManual Manual = new FrmManual();
            Manual.MdiParent = this;
            Manual.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
