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
    public partial class FrmListaAlumnos : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        DataGridViewCheckBoxCell chkEliminar;
        public string ruta="";

        int idGrupo = 0;
        int idCarrera = 0;
        public FrmListaAlumnos()
        {
            InitializeComponent();
            this.Mostrar();
        }

        private static FrmListaAlumnos _instancia;

        public static FrmListaAlumnos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmListaAlumnos();
            }
            return _instancia;

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

        private void Limpiar()
        {
            this.txtnControl.Clear();
            this.txtApellidoPa.Clear();
            this.txtApellidoMa.Clear();
            this.txtNombre.Clear();
            this.cmbSemestre.Text="<Seleccionar>";
            this.cmbGrupo.Text = "<Seleccionar>";
            this.cmbCarrera.Text = "<Seleccionar>";
            this.txtCurp.Clear();
            this.cmbEscProcedencia.Text = "<Seleccionar>";
                 
        }

        private void LlenarComboGrupo()
        {
            this.cmbGrupo.DataSource = NGrupo.Mostrar();
            this.cmbGrupo.ValueMember = "idGrupos";
            this.cmbGrupo.DisplayMember = "grupo";
        }
        private void LlenarComboCarrera()
        {
            this.cmbCarrera.DataSource = NCarrera.Mostrar();
            this.cmbCarrera.ValueMember = "idCarreras";
            this.cmbCarrera.DisplayMember = "nombre_carreras";
        }
        
        private void FrmListaAlumnos_Load(object sender, EventArgs e)
        {
            this.alternarColorFilasDataGridView(dataListadoAlumno);

            this.imgAlumno.BackgroundImage = global::CapaPresentacion.Properties.Resources.iconoImagen;
            LlenarComboGrupo();
            LlenarComboCarrera();
            this.txtOtraProc.Visible = false;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
        public void alternarColorFilasDataGridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;       
        }       

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListadoAlumno.DataSource = NAlumnos.Mostrar();
            this.OcultarColumnas();
            lblRegistros.Text = Convert.ToString(dataListadoAlumno.Rows.Count);

            dataListadoAlumno.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListadoAlumno.Columns["apellidoPa_alu"].HeaderText = "APELLIDO PATERNO";
            dataListadoAlumno.Columns["apellidoMa_alu"].HeaderText = "APELLIDO MATERNO";
            dataListadoAlumno.Columns["nombre_alu"].HeaderText = "NOMBRE";
            dataListadoAlumno.Columns["semestre_alu"].HeaderText = "SEMESTRE";
            dataListadoAlumno.Columns["grupo"].HeaderText = "GRUPO";
            dataListadoAlumno.Columns["nombre_carreras"].HeaderText = "CARRERA";
            dataListadoAlumno.Columns["curp_alu"].HeaderText = "CURP";
            dataListadoAlumno.Columns["genero_alu"].HeaderText = "GENERO";
            dataListadoAlumno.Columns["procedencia_alu"].HeaderText = "PROCEDENCIA";

        }
        private void BuscarNombre()
        {
            this.dataListadoAlumno.DataSource = NAlumnos.BuscarNombre(this.txtBuscarNombre.Text);
            this.OcultarColumnas();
            lblRegistros.Text = Convert.ToString(dataListadoAlumno.Rows.Count);
        }
        private void OcultarColumnas()
        {
        }
        public void info()
        {
            String genero;
            String rutaa = "\\Images";

            this.txtnControl.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["numControl"].Value);
            this.txtApellidoPa.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["apellidoPa_alu"].Value);
            this.txtApellidoMa.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["apellidoMa_alu"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["nombre_alu"].Value);
            this.cmbSemestre.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["semestre_alu"].Value);
            this.cmbGrupo.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["grupo"].Value);
            this.cmbCarrera.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["nombre_carreras"].Value);
           
            this.txtCurp.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["curp_alu"].Value);
            
            

            //////////////////////////////REVISADO////////////////////////////////
            genero = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["genero_alu"].Value);
            if (genero.Equals("M"))
            {
                this.rbMasculino.Checked = true;

            }
            else
            {
                this.rbFemenino.Checked = true;
            }

            cmbEscProcedencia.Text = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["procedencia_alu"].Value);
            ////////////////////////////////////////////////////////////////////////////

            ruta = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["Ruta"].Value);            
             if (!ruta.Equals(""))
             {
                 
                 this.imgAlumno.BackgroundImage = Image.FromFile(ruta);

             }
             else
             {

                 this.imgAlumno.BackgroundImage = global::CapaPresentacion.Properties.Resources.iconoImagen;
             }

           
           
        }
        public void Seleccionar()
        {
            string grup = this.cmbGrupo.Text;
            string carre = this.cmbCarrera.Text;
            switch (grup)
            {
                case "A":
                    idGrupo = 1;
                    break;
                case "B":
                    idGrupo = 2;
                    break;
                case "C":
                    idGrupo = 3;
                    break;
                case "D":
                    idGrupo = 4;
                    break;
                case "E":
                    idGrupo = 5;
                    break;
                case "F":
                    idGrupo = 6;
                    break;
                case "G":
                    idGrupo = 7;
                    break;
                case "H":
                    idGrupo = 8;
                    break;
                case "I":
                    idGrupo = 9;
                    break;


            }

            switch (carre)
            {
                case "Proceso de Gestión Administrativa":
                    idCarrera = 1;
                    break;
                case "Laboratorio Clinico":
                    idCarrera = 2;
                    break;
                case "Suelos y Fertilizantes":
                    idCarrera = 3;
                    break;
                case "Soporte y Mantenimiento Equipo de Computo":
                    idCarrera = 4;
                    break;

            }
        }             
        private void FrmListaAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }


        //ACCIONES
        private void nuevo()
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
        private void guardar()
        {
            try
            {
                string Rpta = "";
                if (this.txtnControl.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        string procedencia = "";
                        string rpta = "";
                        string genero = "";


                        try
                        {

                            procedencia = this.cmbEscProcedencia.Text == "Otra..." ? procedencia = this.txtOtraProc.Text : procedencia = this.cmbEscProcedencia.Text; ;
                            genero = this.rbMasculino.Checked == true ? "M" : "F";
                            Seleccionar();

                            rpta = NAlumnos.Insertar(
                                Convert.ToInt64(this.txtnControl.Text.Trim()),
                                this.txtNombre.Text.Trim().ToUpper(),
                                this.txtApellidoPa.Text.Trim().ToUpper(),
                                this.txtApellidoMa.Text.Trim().ToUpper(),
                                this.cmbSemestre.Text,

                                //======================================
                                idGrupo,
                                idCarrera,
                                //======================================

                                this.txtCurp.Text.Trim().ToUpper(),
                                genero,
                                procedencia,
                                ruta);

                            if (rpta.Equals("OK"))
                            {
                                this.Mostrar();

                                this.MensajeOk("Se Insertó correctamente el registro");
                                this.LimpiarImagen();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                                this.LimpiarImagen();
                            }



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ex.StackTrace);
                        }


                    }
                    else
                    {

                        string procedencia = "";
                        string rpta = "";
                        String genero = "";
                        try
                        {

                            procedencia = this.cmbEscProcedencia.Text == "Otra..." ? procedencia = this.txtOtraProc.Text : procedencia = this.cmbEscProcedencia.Text;
                            genero = this.rbMasculino.Checked == true ? "M" : "F";
                            Seleccionar();

                            rpta = NAlumnos.Editar(
                                Convert.ToInt64(this.txtnControl.Text.Trim()),
                                this.txtNombre.Text.Trim().ToUpper(),
                             this.txtApellidoPa.Text.Trim().ToUpper(),
                             this.txtApellidoMa.Text.Trim().ToUpper(),
                             this.cmbSemestre.Text,
                             idGrupo,
                             idCarrera,
                             this.txtCurp.Text.Trim().ToUpper(),
                             genero,
                             procedencia,
                             ruta);


                            if (rpta.Equals("OK"))
                            {

                                this.Mostrar();
                                this.MensajeOk("Se actualizó correctamente el registro");
                                this.LimpiarImagen();
                            }
                            else
                            {
                                this.MensajeError(rpta);
                                this.LimpiarImagen();
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
        private void detalles()
        {
            if (this.txtnControl.Text.Equals(""))
            {
                this.MensajeError("Selecciona al menos un alumno");
            }
            else
            {
                this.colocarAlumno();
            }
        }
        private void eliminar()
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema Escolar Cecyt", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListadoAlumno.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NAlumnos.Eliminar(Convert.ToInt64(Codigo));
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
            lblRegistros.Text = Convert.ToString(dataListadoAlumno.Rows.Count);
        }
        private void cancelar()
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.LimpiarImagen();
            this.txtnControl.Text = string.Empty;
        }
        private void editar()
        {
            //Si no ha seleccionado un producto no puede modificar
            if (!this.txtnControl.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }
        private void cargarImagen()
        {
            String ncontrol = txtnControl.Text;

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*|*.*)";
            open.FilterIndex = 1;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if (open.CheckFileExists)
                {
                    String CorrectFilename = System.IO.Path.GetFileName(open.FileName);
                    String paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    ruta = paths + "\\Images\\" + CorrectFilename;

                    try
                    {
                        System.IO.File.Copy(open.FileName, ruta);
                        //imgAlumno.Load(ruta);
                        this.imgAlumno.BackgroundImage = Image.FromFile(ruta);
                    }
                    catch (Exception errr)
                    {
                        //MensajeError("La imágen ya existe");
                        this.imgAlumno.BackgroundImage = Image.FromFile(ruta);
                    }

                }

            }
        }
        private void imprimir()
        {
            if (this.cmbBuscarGru.Text.Equals("<Seleccionar>") && this.cmbBuscarSem.Text.Equals("<Seleccionar>"))
            {
                MessageBox.Show("Sleccione Semestre y Grupo", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (this.cmbBuscarGru.Text.Equals("<Seleccionar>"))
            {
                MessageBox.Show("Seleccione Grupo", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (this.cmbBuscarSem.Text.Equals("<Seleccionar>"))
            {
                MessageBox.Show("Seleccione Semestre", "Sistema Escolar Cecyt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                FrmLista_Alumnos frm = new FrmLista_Alumnos();
                frm.Semestre = Convert.ToInt32(this.cmbBuscarSem.Text);
                frm.Grupo = this.cmbBuscarGru.Text;
                frm.ShowDialog();
            }
        }
        private void unclic(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoAlumno.Columns["columEliminar"].Index)
            {
                chkEliminar = (DataGridViewCheckBoxCell)dataListadoAlumno.Rows[e.RowIndex].Cells["columEliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }

            try
            {
                this.info();

            }
            catch (Exception err)
            {
            }
        }
        private void dobleclic(EventArgs e)
        {
            try
            {
                this.info();
            }
            catch (Exception err)
            {
            }
        }
        private void LimpiarImagen()
        {
            this.imgAlumno.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imgAlumno.BackgroundImage = global::CapaPresentacion.Properties.Resources.iconoImagen;
        }
        public void colocarAlumno()
        {
            FrmDetallesAlumno Historial = new FrmDetallesAlumno();
            string numControl, apellidoPa, apellidoMa, nombre, semestre, grupo, carrera, genero, curp, procedencia;
            Boolean genero2;

            numControl = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["numControl"].Value);
            apellidoPa = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["apellidoPa_alu"].Value);
            apellidoMa = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["apellidoMa_alu"].Value);
            nombre = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["nombre_alu"].Value);
            semestre = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["semestre_alu"].Value);
            grupo = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["grupo"].Value);
            carrera = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["nombre_carreras"].Value);
            curp = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["curp_alu"].Value);
            genero = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["genero_alu"].Value);
            //genero2 = (genero.Equals("M")) ? true : false;

            procedencia = Convert.ToString(this.dataListadoAlumno.CurrentRow.Cells["procedencia_alu"].Value);
            Historial.NumControl = numControl;
            Historial.setInfo(numControl, apellidoPa, apellidoMa, nombre, semestre, grupo, carrera, curp, genero, procedencia, ruta);
            Historial.ShowDialog();

        }
        private void otraProcedencia()
        {
            this.txtOtraProc.Visible = this.cmbEscProcedencia.Text == "Otra..." ? true : false;
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
            if (IsEditar)
            {
                this.txtnControl.ReadOnly = valor;
                this.txtApellidoPa.Focus();
            }
            else
            {
                this.txtnControl.ReadOnly = !valor;
            }

            //this.txtnControl.ReadOnly = !valor;
            this.txtApellidoPa.ReadOnly = !valor;
            this.txtApellidoMa.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.btnCargarImagen.Enabled = valor;
            this.btnEliminarImagen.Enabled = valor;
            this.cmbSemestre.Enabled = valor;
            this.cmbGrupo.Enabled = valor;
            this.rbMasculino.Enabled = valor;
            this.rbFemenino.Enabled = valor;
            this.cmbCarrera.Enabled = valor;
            this.txtCurp.ReadOnly = !valor;
            this.cmbEscProcedencia.Enabled = valor;
        }

        //EVENTOS DE LOS BOTONES
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.detalles();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.imprimir();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
        private void dataListadoAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.unclic(e);
        }
        private void dataListadoAlumno_DoubleClick(object sender, EventArgs e)
        {
            this.dobleclic(e);
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            this.cargarImagen();
        }
        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            this.LimpiarImagen();
        }
        private void cmbEscProcedencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.otraProcedencia();
        }
    }
}
