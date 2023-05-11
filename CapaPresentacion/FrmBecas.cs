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
    public partial class FrmBecas : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        DataGridViewCheckBoxCell chkEliminar;

        public string ruta = "";



        private static FrmBecas _instancia;

        public static FrmBecas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmBecas();
            }
            return _instancia;
        }

        public void setAlumno(string numcontrol, string nombre, string apaterno, string amaterno)
        {
            this.txtnControl.Text = numcontrol;
            this.txtNombre.Text = nombre+" "+apaterno+" "+amaterno;
           
            
        }

        public FrmBecas()
        {
            InitializeComponent();
            this.Mostrar();
        }

        private void OcultarColumnas()
        {
        }

        private void Limpiar()
        {
            this.txtValidacionBId.Clear();
            this.txtnControl.Clear();
            this.txtModalidad.Clear();
            this.txtEstadoBeca.Clear();
            this.txtNombre.Clear();
            //this.dtFechaValidacion.Clear();

        }
        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListadoBecas.DataSource = NBeca.Mostrar();
            this.OcultarColumnas();
            lblRegistros.Text = Convert.ToString(dataListadoBecas.Rows.Count);
            dataListadoBecas.Columns["idBecas"].HeaderText = "VALIDACION";
            dataListadoBecas.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListadoBecas.Columns["nombre_alu"].HeaderText = "NOMBRE";
            dataListadoBecas.Columns["apellidoPa_alu"].HeaderText = "APELLIDO PATERNO";
            dataListadoBecas.Columns["apellidoMa_alu"].HeaderText = "APELLIDO MATERNO";
            dataListadoBecas.Columns["modalidad_bec"].HeaderText = "MODALIDAD";
            dataListadoBecas.Columns["estado_bec"].HeaderText = "ESTADO";
            dataListadoBecas.Columns["fechaValidacion_bec"].HeaderText = "FECHA DE VALIDACION";


        }

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
            this.txtValidacionBId.ReadOnly = !valor;
            this.txtnControl.ReadOnly = !valor;
            this.btnExplorar.Enabled = valor;
            this.txtNombre.ReadOnly = true;
            this.txtModalidad.ReadOnly = !valor;
            this.txtEstadoBeca.ReadOnly = !valor;
            this.dtFechaValidacion.Enabled = valor;
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

        private void BuscarNombre()
        {
            this.dataListadoBecas.DataSource = NBeca.BuscarNombre(this.txtBuscarNombre.Text);
            this.OcultarColumnas();
            lblRegistros.Text = Convert.ToString(dataListadoBecas.Rows.Count);
        }

        
     
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnControl.Focus();
            if (IsNuevo == true)
            {
                txtnControl.Text = "1740707021";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un producto no puede modificar
            if (!this.txtnControl.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe buscar un registro para Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtValidacionBId.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtValidacionBId.Text == string.Empty)
                {
                    MensajeError("Importante el no control");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        string rpta = "";

                        try
                        {

                            rpta = NBeca.Insertar(
                                Convert.ToInt32(this.txtValidacionBId.Text),
                                Convert.ToInt64(this.txtnControl.Text),
                                this.txtModalidad.Text.Trim(),
                                this.txtEstadoBeca.Text.Trim().ToUpper(),
                                this.dtFechaValidacion.Value);

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
                            rpta = NBeca.Editar(
                             Convert.ToInt32(this.txtValidacionBId.Text),
                             Convert.ToInt64(this.txtnControl.Text),
                             this.txtModalidad.Text.Trim(),
                             this.txtEstadoBeca.Text.Trim().ToUpper(),
                             this.dtFechaValidacion.Value);


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
                    this.txtValidacionBId.Text = "";


                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void Eliminar()
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema Escolar Cecyt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListadoBecas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NBeca.Eliminar(Convert.ToInt32(Codigo));
                        }
                    }

                    if (Rpta.Equals("OK"))
                    {
                        this.Mostrar();
                        this.MensajeOk("Se Eliminó Correctamente el registro");

                    }
                    else
                    {
                        this.MensajeError("Selecciona al menos un registro para poder eliminar");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            this.Limpiar();
            lblRegistros.Text = Convert.ToString(dataListadoBecas.Rows.Count);
        }

        private void FrmBecas_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }

        private void dataListadoBecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoBecas.Columns["columEliminar"].Index)
            {
                chkEliminar = (DataGridViewCheckBoxCell)dataListadoBecas.Rows[e.RowIndex].Cells["columEliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }   
        }

        private void dataListadoBecas_DoubleClick(object sender, EventArgs e)
        {
            this.txtValidacionBId.Text = Convert.ToString(this.dataListadoBecas.CurrentRow.Cells["idBecas"].Value);
            this.txtnControl.Text = Convert.ToString(this.dataListadoBecas.CurrentRow.Cells["numControl"].Value);
            this.txtModalidad.Text = Convert.ToString(this.dataListadoBecas.CurrentRow.Cells["modalidad_bec"].Value);
            this.txtEstadoBeca.Text = Convert.ToString(this.dataListadoBecas.CurrentRow.Cells["estado_bec"].Value);
            this.dtFechaValidacion.Value = Convert.ToDateTime(this.dataListadoBecas.CurrentRow.Cells["fechaValidacion_bec"].Value);
        }

        private void txtBuscarNumControl_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            vistaAlumnosBecas vista = new vistaAlumnosBecas();
            vista.Show();
        }

        private void FrmBecas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {


            if (this.cmbBuscarSem.Text.Equals("<Seleccionar>") && this.cmbBuscarGru.Text.Equals("<Seleccionar>"))
            {MessageBox.Show("Seleccione Semestre y Grupo", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            
            else if(this.cmbBuscarSem.Text.Equals("<Seleccionar>"))
            {MessageBox.Show("Seleccione Semestre", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information);}

            else if (this.cmbBuscarGru.Text.Equals("<Seleccionar>"))
            { MessageBox.Show("Seleccione Grupo", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else
            {
                frmLista_Becarios frm = new frmLista_Becarios();

                frm.Grupo = ConvertGrupo(this.cmbBuscarGru.Text);

                frm.Semestre = Convert.ToInt32(this.cmbBuscarSem.Text);
                frm.ShowDialog();

            }


        }



        public int ConvertGrupo(string grupo)
        {
            int g=0;

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
