using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmSeguro : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        DataGridViewCheckBoxCell chkEliminar;
        String idSeguro = "";

        public FrmSeguro()
        {
            InitializeComponent();
        }

        private static FrmSeguro _instancia;

        public static FrmSeguro GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmSeguro();
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
            this.txtIdSeguro.ReadOnly = !valor;
            this.txtControl.ReadOnly = !valor;
            this.btnExplorar.Enabled = valor;
            this.txtNombre.ReadOnly = true;
            this.dtValidacionSeguro.Enabled = valor;
        }       
        private void FrmSeguro_Load(object sender, EventArgs e)
        {
            this.txtControl.ReadOnly = true;
            this.Mostrar();
            this.alternarColorFilasDataGridView(dataListadoSeguro);
            this.Habilitar(false);
            this.Botones();
        }
        public void alternarColorFilasDataGridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
        }
        private void Limpiar()
        {
            this.txtIdSeguro.Clear();
            this.txtControl.Clear();
            this.dtValidacionSeguro.Value = DateTime.Now;
            this.txtNombre.Clear();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
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
                            rpta = NSeguro.Insertar(
                                Convert.ToInt32(this.txtIdSeguro.Text),
                                Convert.ToInt64(this.txtControl.Text.Trim()),
                                this.dtValidacionSeguro.Value
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
                            rpta = NSeguro.Editar(
                                Convert.ToInt32(this.txtIdSeguro.Text),
                                Convert.ToInt64(this.txtControl.Text.Trim()),
                                this.dtValidacionSeguro.Value
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

                    foreach (DataGridViewRow row in dataListadoSeguro.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells["idAfiliacion"].Value);
                            Rpta = NSeguro.Eliminar(Convert.ToInt32(Codigo));
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
            lblRegistros.Text = Convert.ToString(dataListadoSeguro.Rows.Count);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataListadoSeguro.DataSource = NSeguro.BuscarNumControl(this.txtControl.Text);
            lblRegistros.Text = Convert.ToString(dataListadoSeguro.Rows.Count);
        }
        public void info()
        {
            this.txtIdSeguro.Text = Convert.ToString(this.dataListadoSeguro.CurrentRow.Cells["idAfiliacion"].Value);
            this.txtControl.Text = Convert.ToString(this.dataListadoSeguro.CurrentRow.Cells["numControl"].Value);
            string nombre = Convert.ToString(this.dataListadoSeguro.CurrentRow.Cells["nombre_alu"].Value);
            string apellidos = Convert.ToString(this.dataListadoSeguro.CurrentRow.Cells["APELLIDOS"].Value);
            this.txtNombre.Text = apellidos + " " + nombre;
            this.dtValidacionSeguro.Value = Convert.ToDateTime(this.dataListadoSeguro.CurrentRow.Cells["fechaMovimiento"].Value);
            
        }
        private void Mostrar()
        {
            this.dataListadoSeguro.DataSource = NSeguro.Mostrar();
            lblRegistros.Text = Convert.ToString(dataListadoSeguro.Rows.Count);

            //ENCABEZADO DE LA TABLA
            dataListadoSeguro.Columns["idAfiliacion"].HeaderText = "ID SEGURO";
            dataListadoSeguro.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListadoSeguro.Columns["nombre_alu"].HeaderText = "NOMBRE";            
            dataListadoSeguro.Columns["fechaMovimiento"].HeaderText = "FECHA DE MOVIMIENTO";
        }
        private void dataListadoSeguro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoSeguro.Columns["columEliminar"].Index)
            {
                chkEliminar = (DataGridViewCheckBoxCell)dataListadoSeguro.Rows[e.RowIndex].Cells["columEliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }
        private void dataListadoSeguro_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.info();
            }
            catch (Exception err)
            {
            }
        }

        private void FrmSeguro_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            vistaAlumnosSeguroSocial vista = new vistaAlumnosSeguroSocial();
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
                frmLista_Seguro frm = new frmLista_Seguro();

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

