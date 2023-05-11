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
    public partial class vistaPracticasProfesionales : Form
    {
        public vistaPracticasProfesionales()
        {
            InitializeComponent();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmPracticas form = FrmPracticas.GetInstancia();
            string numcontrol, nombre, apaterno, amaterno;

            numcontrol = Convert.ToString(this.dataListado.CurrentRow.Cells["numControl"].Value);
            nombre = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre_alu"].Value);
            apaterno = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidoPa_alu"].Value);
            amaterno = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidoMa_alu"].Value);


            form.setAlumno(numcontrol, nombre, apaterno, amaterno);
            this.Hide();
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NAlumnos.BuscarNombre(this.txtBuscar.Text);
            //this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NAlumnos.Mostrar();
            //this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

            //ENCABEZADO DE LA TABLA
            dataListado.Columns["numControl"].HeaderText = "NUMERO DE CONTROL";
            dataListado.Columns["apellidoPa_alu"].HeaderText = "APELLIDO PATERNO";
            dataListado.Columns["apellidoMa_alu"].HeaderText = "APELLIDO MATERNO";
            dataListado.Columns["nombre_alu"].HeaderText = "NOMMBRE";
            dataListado.Columns["semestre_alu"].HeaderText = "SEMESTRE";
            dataListado.Columns["grupo"].HeaderText = "GRUPO";
            dataListado.Columns["nombre_carreras"].HeaderText = "CARRERA";
            dataListado.Columns["curp_alu"].HeaderText = "CURP";
            dataListado.Columns["genero_alu"].HeaderText = "GENERO";
            dataListado.Columns["procedencia_alu"].HeaderText = "PROCEDENCIA";
        }

        private void vistaPracticasProfesionales_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.alternarColorFilasDataGridView(dataListado);
        }
        public void alternarColorFilasDataGridView(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
    }
}
