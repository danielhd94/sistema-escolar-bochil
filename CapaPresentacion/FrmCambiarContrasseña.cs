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
    public partial class FrmCambiarContrasseña : Form
    {
        public string Idadmin = "";


        public string Usuario = "";
        public string Password = "";

        public FrmCambiarContrasseña()
        {
            InitializeComponent();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Escolar Bochil", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Escolar Bochil", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (this.txtActualContra.Text.Equals(Password))
            {
                this.gbVerificar.Enabled = false;
                this.gbCambiarContraseña.Enabled = true;
                this.btnValidar.Enabled = false;
            }
            else
            {
                MensajeError("Error de contraseña");
            }
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNuevaContra.Text == "" || this.txtConfirmarContra.Text == "")
            {
                MensajeError("Verifique los campos");
                errorIcono.SetError(txtNuevaContra, "Inserte la contraseña");
            }
            else
            {
                if (this.txtConfirmarContra.Text != this.txtNuevaContra.Text)
                {

                    MensajeError("Las contraseñas no coinciden. Verifique los campos");
                    errorIcono.SetError(txtConfirmarContra, "Verifique la confirmacion de la contraseña");
                }
                else
                {

                    string Editar = Nusuario.EditarAdmin(Convert.ToInt32(Idadmin), this.txtNuevaContra.Text);
                    if (Editar.Equals("OK"))
                    {
                        this.MensajeOk("Se cambió correctamente la contraseña del usuario");
                        this.Close();

                    }
                    else
                    {
                        this.MensajeError("No Se cambió correctamente la contraseña del usuario");
                    }
                }
            }
        }

        private void FrmCambiarContrasseña_Load(object sender, EventArgs e)
        {
            this.gbCambiarContraseña.Enabled = false;
        }
    }
}
