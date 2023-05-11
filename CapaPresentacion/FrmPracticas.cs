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
    public partial class FrmPracticas : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        DataGridViewCheckBoxCell chkEliminar;
        String idPracticasProfesionales = "";

        public FrmPracticas()
        {
            InitializeComponent();
        }

        private static FrmPracticas _instancia;

        public static FrmPracticas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmPracticas();
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
            this.dtInicioPracticas.Enabled = valor;
            this.dtTerminoPracticas.Enabled = valor;
            this.dtExpConsPracticas.Enabled = valor;
            this.txtObservaciones.ReadOnly = !valor;
        }       

        private void FrmPracticas_Load(object sender, EventArgs e)
        {
            this.txtControl.ReadOnly = true;
            this.Mostrar();
            this.alternarColorFilasDataGridView(dataListadoPracticasPro);
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
            this.dataListadoPracticasPro.DataSource = NPracticasPro.Mostrar();
            lblRegistros.Text = Convert.ToString(dataListadoPracticasPro.Rows.Count);

            //ENCABEZADO DE LA TABLA
            //dataListadoPracticasPro.Columns["idPractica"].HeaderText = "ID PRACTICAS";
            dataListadoPracticasPro.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListadoPracticasPro.Columns["nombre_alu"].HeaderText = "NOMBRE";
            dataListadoPracticasPro.Columns["institucionSP_prac"].HeaderText = "INSTITUCION";
            dataListadoPracticasPro.Columns["inicio_prac"].HeaderText = "INICIO";
            dataListadoPracticasPro.Columns["termino_prac"].HeaderText = "TERMINO";
            dataListadoPracticasPro.Columns["fechaExpCons_prac"].HeaderText = "FECHA EXPEDICION DE CONSTANCIA";
            dataListadoPracticasPro.Columns["Observaciones_prac"].HeaderText = "OBSERVACIONES";
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

            this.txtControl.Clear();
            this.txtInstituto.Clear();
            //this.dtInicioPracticas.Enabled = valor;
            //this.dtTerminoPracticas.Enabled = valor;
            //this.dtExpConsPracticas.Enabled = valor;
            this.txtObservaciones.Clear();
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
                            rpta = NPracticasPro.Insertar(                                
                               Convert.ToInt64(this.txtControl.Text.Trim()),
                                this.txtInstituto.Text,
                                this.dtInicioPracticas.Value,
                                this.dtTerminoPracticas.Value,
                                this.dtExpConsPracticas.Value,
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
                            rpta = NPracticasPro.Editar(
                               Convert.ToInt32(this.idPracticasProfesionales),
                               Convert.ToInt64(this.txtControl.Text.Trim()),
                               this.txtInstituto.Text,
                               this.dtInicioPracticas.Value,
                               this.dtTerminoPracticas.Value,
                               this.dtExpConsPracticas.Value,
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

        private void dataListadoPracticasPro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoPracticasPro.Columns["columEliminar"].Index)
            {
                chkEliminar = (DataGridViewCheckBoxCell)dataListadoPracticasPro.Rows[e.RowIndex].Cells["columEliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dataListadoPracticasPro_DoubleClick(object sender, EventArgs e)
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
            //this.idPracticasProfesionales = Convert.ToString(this.dataListadoPracticasPro.CurrentRow.Cells["idPractica"].Value);
            this.txtControl.Text = Convert.ToString(this.dataListadoPracticasPro.CurrentRow.Cells["numControl"].Value);
            string nombre = Convert.ToString(this.dataListadoPracticasPro.CurrentRow.Cells["nombre_alu"].Value);
            string apellidos = Convert.ToString(this.dataListadoPracticasPro.CurrentRow.Cells["APELLIDOS"].Value);
            this.txtNombre.Text = apellidos + " " + nombre;
            this.txtInstituto.Text = Convert.ToString(this.dataListadoPracticasPro.CurrentRow.Cells["institucionSP_prac"].Value);
            this.dtInicioPracticas.Value = Convert.ToDateTime(this.dataListadoPracticasPro.CurrentRow.Cells["inicio_prac"].Value);
            this.dtTerminoPracticas.Value = Convert.ToDateTime(this.dataListadoPracticasPro.CurrentRow.Cells["termino_prac"].Value);
            this.dtExpConsPracticas.Value = Convert.ToDateTime(this.dataListadoPracticasPro.CurrentRow.Cells["fechaExpCons_prac"].Value);
            this.txtObservaciones.Text = Convert.ToString(this.dataListadoPracticasPro.CurrentRow.Cells["Observaciones_prac"].Value);
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

                    foreach (DataGridViewRow row in dataListadoPracticasPro.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells["idPractica"].Value);
                            Rpta = NPracticasPro.Eliminar(Convert.ToInt32(Codigo));
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
            lblRegistros.Text = Convert.ToString(dataListadoPracticasPro.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataListadoPracticasPro.DataSource = NPracticasPro.BuscarNumControl(this.txtBuscarNoControl.Text);
            lblRegistros.Text = Convert.ToString(dataListadoPracticasPro.Rows.Count);
        }

        private void FrmPracticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            vistaPracticasProfesionales vista = new vistaPracticasProfesionales();
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
                frmLista_Practicas frm = new frmLista_Practicas();

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
