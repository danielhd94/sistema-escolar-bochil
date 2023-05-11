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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
           LblHora.Text = DateTime.Now.ToString();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ToolTip mensajetooltip = new ToolTip();            
            mensajetooltip.SetToolTip(this.txtContraseña, "Ingrese Contraseña");
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ingresar();  //Error controlado
            }catch(Exception ex){
                MessageBox.Show("No tiene acceso al sistema", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ingresar()
        {

            DataTable Datos = Nusuario.Login(this.txtNombre.Text, this.txtContraseña.Text);
            string idusuario, usuario, password, acceso;
            //Evaluar si existe el usuario
            try
            {
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No tiene acceso al sistema", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    idusuario = Datos.Rows[0][0].ToString();
                    usuario = Datos.Rows[0][1].ToString();
                    password = Datos.Rows[0][2].ToString();
                    acceso = Datos.Rows[0][3].ToString();

                    if (usuario.Equals(this.txtNombre.Text) && password.Equals(this.txtContraseña.Text))
                    {
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.Idusuario = idusuario;
                        frm.NombreUsuario = usuario;
                        frm.Password = password;
                        frm.Acceso = acceso;

                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err, "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            //this.cbTipoUsuario.Text = "<Seleccionar Tipo  de Usuario>";
            this.txtContraseña.Clear();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                this.ingresar();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.ingresar();
            }
        }

        
    }
}
