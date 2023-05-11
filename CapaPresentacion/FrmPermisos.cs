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
    public partial class FrmPermisos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        DataGridViewCheckBoxCell chkEliminar;
        String idPermiso = "";

        public FrmPermisos()
        {
            InitializeComponent();
        }

        private static FrmPermisos _instancia;

        public static FrmPermisos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmPermisos();
            }
            return _instancia;

        }

        public void setAlumno(string numcontrol, string nombre, string apaterno, string amaterno)
        {
            this.txtnControl.Text = numcontrol;
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
            this.txtnControl.ReadOnly = !valor;
            this.btnExplorar.Enabled = valor;
            this.txtNombre.ReadOnly = true;
            this.dtFechaPermisos.Enabled = valor;
            this.txtMotivo.ReadOnly = !valor;
        }       
        private void FrmPermisos_Load(object sender, EventArgs e)
        {

            this.txtnControl.ReadOnly = true;
            this.Mostrar();
            this.alternarColorFilasDataGridView(dataListadoPermisos);
            this.Habilitar(false);
            this.Botones();
        }

        public void alternarColorFilasDataGridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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
            this.txtnControl.Clear();
            this.txtMotivo.Clear();
            this.txtNombre.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtnControl.Text == string.Empty)
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
                            
                            rpta = NPermisos.Insertar(
                                Convert.ToInt64(this.txtnControl.Text.Trim()),                                
                                this.txtMotivo.Text,
                                this.dtFechaPermisos.Value
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
                            rpta = NPermisos.Editar(
                                Convert.ToInt32(this.idPermiso),
                                Convert.ToInt64(this.txtnControl.Text.Trim()),                                
                                this.txtMotivo.Text,
                                this.dtFechaPermisos.Value
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
                    this.txtnControl.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtnControl.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe buscar un registro para poder Modificar");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnControl.Focus();            
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

                    foreach (DataGridViewRow row in dataListadoPermisos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                             Codigo = Convert.ToString(row.Cells["idPermisos"].Value);
                             Rpta = NPermisos.Eliminar(Convert.ToInt32(Codigo));
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
            lblRegistros.Text = Convert.ToString(dataListadoPermisos.Rows.Count);
        }
        private void Mostrar()
        {
            this.dataListadoPermisos.DataSource = NPermisos.Mostrar();
            lblRegistros.Text = Convert.ToString(dataListadoPermisos.Rows.Count);

            //ENCABEZADO DE LA TABLA
            //dataListadoPermisos.Columns["idPermisos"].HeaderText = "ID PERMISOS";
            dataListadoPermisos.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListadoPermisos.Columns["nombre_alu"].HeaderText = "NOMBRE";
            dataListadoPermisos.Columns["motivo_perm"].HeaderText = "MOTIVO";
            dataListadoPermisos.Columns["fecha_perm"].HeaderText = "FECHA";
        }

        private void dataListadoPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoPermisos.Columns["columEliminar"].Index)
            {
                chkEliminar = (DataGridViewCheckBoxCell)dataListadoPermisos.Rows[e.RowIndex].Cells["columEliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dataListadoPermisos_DoubleClick(object sender, EventArgs e)
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
            //this.idPermiso = Convert.ToString(this.dataListadoPermisos.CurrentRow.Cells["idPermisos"].Value);
            this.txtnControl.Text = Convert.ToString(this.dataListadoPermisos.CurrentRow.Cells["numControl"].Value);
            string nombre = Convert.ToString(this.dataListadoPermisos.CurrentRow.Cells["nombre_alu"].Value);
            string apellidos = Convert.ToString(this.dataListadoPermisos.CurrentRow.Cells["APELLIDOS"].Value);
            this.txtNombre.Text = apellidos + " " + nombre;
            this.dtFechaPermisos.Text = Convert.ToString(this.dataListadoPermisos.CurrentRow.Cells["fecha_perm"].Value);
            this.txtMotivo.Text = Convert.ToString(this.dataListadoPermisos.CurrentRow.Cells["motivo_perm"].Value);            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataListadoPermisos.DataSource = NPermisos.BuscarNumControl(this.txtNumControl.Text);
            lblRegistros.Text = Convert.ToString(dataListadoPermisos.Rows.Count);
       
        }

        private void FrmPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            vistaAlumnosPermisos vista = new vistaAlumnosPermisos();
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
                frmLista_Permisos frm = new frmLista_Permisos();

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
