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
    public partial class FrmServicio : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        DataGridViewCheckBoxCell chkEliminar;
        String idServicioSocial = "";

        public FrmServicio()
        {
            InitializeComponent();
        }

        private static FrmServicio _instancia;

        public static FrmServicio GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmServicio();
            }
            return _instancia;

        }

        public void setAlumno(string numcontrol, string nombre, string apaterno, string amaterno)
        {
            this.txtControl.Text = numcontrol;
            this.txtNombre.Text = nombre + " " + apaterno + " " + amaterno;
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
        //Habilita los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        private void Habilitar(bool valor)
        {
            this.txtControl.ReadOnly = !valor;
            this.btnExplorar.Enabled = valor;
            this.txtNombre.ReadOnly = true;
            this.txtInstituto.Enabled = valor;
            this.dtInicioServicio.Enabled = valor;
            this.dtTerminoServicio.Enabled = valor;
            this.dtExpConsServicio.Enabled = valor;
            this.txtObservaciones.ReadOnly = !valor;
        }       
        
        private void FrmServicio_Load(object sender, EventArgs e)
        {
            this.txtControl.ReadOnly = true;
            this.Mostrar();
            this.alternarColorFilasDataGridView(dataListadoServicioS);
            this.Habilitar(false);
            this.Botones();
        }
        public void alternarColorFilasDataGridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        private void Mostrar()
        {
            this.dataListadoServicioS.DataSource = NServicioSocial.Mostrar();
            lblRegistros.Text = Convert.ToString(dataListadoServicioS.Rows.Count);

            //ENCABEZADO DE LA TABLA
            //dataListadoServicioS.Columns["idServicioSocial"].HeaderText = "ID SERVICIO SOCIAL";
            dataListadoServicioS.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListadoServicioS.Columns["nombre_alu"].HeaderText = "NOMBRE";   
            dataListadoServicioS.Columns["institucionSP_serv"].HeaderText = "INSTITUCION DE SERVICIO PUBLICO";
            dataListadoServicioS.Columns["inicio_serv"].HeaderText = "INICIO";
            dataListadoServicioS.Columns["termino_serv"].HeaderText = "TERMINO";
            dataListadoServicioS.Columns["fechaExpCons_serv"].HeaderText = "FECHA EXPEDICION DE CONSTANCIA";
            dataListadoServicioS.Columns["observaciones_serv"].HeaderText = "OBSERVACIONES";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
        }
        private void Limpiar()
        {

            this.txtControl.Clear();
            this.txtInstituto.Clear();
            //this.dtInicioPracticas.Enabled = valor;
            //this.dtTerminoPracticas.Enabled = valor;
            //this.dtExpConsPracticas.Enabled = valor;
            this.txtObservaciones.Clear();
            this.txtNombre.Clear();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtControl.Focus(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtControl.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe buscar un registro para poder Modificar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (this.txtControl.Text == string.Empty)
                {
                    MensajeError("Necesario Número de Control del Alumno");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        string rpta = "";

                        try
                        {
                            rpta = NServicioSocial.Insertar(
                               Convert.ToInt64(this.txtControl.Text.Trim()),
                                this.txtInstituto.Text,
                                this.dtInicioServicio.Value,
                                this.dtTerminoServicio.Value,
                                this.dtExpConsServicio.Value,
                                this.txtObservaciones.Text
                                );

                            if (rpta.Equals("OK"))
                            {
                                this.Mostrar();
                                this.MensajeOk("Se Insertó correctamente el registro");
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
                    else
                    {
                        string rpta = "";
                        try
                        {
                            rpta = NServicioSocial.Editar(
                               Convert.ToInt32(this.idServicioSocial),
                               Convert.ToInt64(this.txtControl.Text.Trim()),
                                this.txtInstituto.Text,
                                this.dtInicioServicio.Value,
                                this.dtTerminoServicio.Value,
                                this.dtExpConsServicio.Value,
                                this.txtObservaciones.Text
                               );


                            if (rpta.Equals("OK"))
                            {

                                this.Mostrar();
                                this.MensajeOk("Se actualizó correctamente el registro");
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

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.txtControl.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListadoServicioS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoServicioS.Columns["columEliminar"].Index)
            {
                chkEliminar = (DataGridViewCheckBoxCell)dataListadoServicioS.Rows[e.RowIndex].Cells["columEliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dataListadoServicioS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.info();
            }
            catch (Exception err)
            {
            }
        }

        public void info()
        {
            //this.idServicioSocial = Convert.ToString(this.dataListadoServicioS.CurrentRow.Cells["idServicioSocial"].Value);
            this.txtControl.Text = Convert.ToString(this.dataListadoServicioS.CurrentRow.Cells["numControl"].Value);
            string nombre  = Convert.ToString(this.dataListadoServicioS.CurrentRow.Cells["nombre_alu"].Value);
            string apellidos = Convert.ToString(this.dataListadoServicioS.CurrentRow.Cells["APELLIDOS"].Value);
            this.txtNombre.Text = apellidos+" "+nombre;
            this.txtInstituto.Text = Convert.ToString(this.dataListadoServicioS.CurrentRow.Cells["institucionSP_serv"].Value);
            this.dtInicioServicio.Value = Convert.ToDateTime(this.dataListadoServicioS.CurrentRow.Cells["inicio_serv"].Value);
            this.dtTerminoServicio.Value = Convert.ToDateTime(this.dataListadoServicioS.CurrentRow.Cells["termino_serv"].Value);
            this.dtExpConsServicio.Value = Convert.ToDateTime(this.dataListadoServicioS.CurrentRow.Cells["fechaExpCons_serv"].Value);
            this.txtObservaciones.Text = Convert.ToString(this.dataListadoServicioS.CurrentRow.Cells["Observaciones_serv"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema Escolar Cecyt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListadoServicioS.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells["idServicioSocial"].Value);
                            Rpta = NServicioSocial.Eliminar(Convert.ToInt32(Codigo));
                        }
                    }

                    if (Rpta.Equals("OK"))
                    {
                        this.Mostrar();
                        this.MensajeOk("Se Eliminó Correctamente el registro");

                    }
                    else
                    {
                        this.MensajeError("Ocurrió un error al eliminar el registro");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            this.Limpiar();
            lblRegistros.Text = Convert.ToString(dataListadoServicioS.Rows.Count);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataListadoServicioS.DataSource = NServicioSocial.BuscarNumControl(this.txtBuscarNoControl.Text);
            lblRegistros.Text = Convert.ToString(dataListadoServicioS.Rows.Count);
        }

        private void FrmServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            vistaServicioSocial vista = new vistaServicioSocial();
            vista.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {


            if (this.cmbBuscarSem.Text.Equals("<Seleccionar>") && this.cmbBuscarGru.Text.Equals("<Seleccionar>"))
            { MessageBox.Show("Seleccione Semestre y Grupo", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else if (this.cmbBuscarSem.Text.Equals("<Seleccionar>"))
            { MessageBox.Show("Seleccione Semestre", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else if (this.cmbBuscarGru.Text.Equals("<Seleccionar>"))
            { MessageBox.Show("Seleccione Grupo", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else
            {
                frmLista_Servicio frm = new frmLista_Servicio();

                frm.Grupo = ConvertGrupo(this.cmbBuscarGru.Text);

                frm.Semestre = Convert.ToInt32(this.cmbBuscarSem.Text);
                frm.ShowDialog();


            }
        }
              public int ConvertGrupo(string grupo)
        {
            int g = 0;

            switch (grupo)
            {
                case "A":
                    g = 1;
                    break;
                case "B":
                    g = 2;
                    break;
                case "C":
                    g = 3;
                    break;
                case "D":
                    g = 4;
                    break;
                case "E":
                    g = 5;
                    break;
                case "F":
                    g = 6;
                    break;
                case "G":
                    g = 7;
                    break;
                case "H":
                    g = 8;
                    break;
                case "I":
                    g = 9;
                    break;

            }
            return g;
        }

    }


}
