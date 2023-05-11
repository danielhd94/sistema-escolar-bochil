using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLista_Reportes : Form
    {
        int _Semestre;

        public int Semestre
        {
            get { return _Semestre; }
            set { _Semestre = value; }
        }
        int _Grupo;

        public int Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }



        public frmLista_Reportes()
        {
            InitializeComponent();
        }

        private void frmLista_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSet1.splista_reportes' Puede moverla o quitarla según sea necesario.
                this.splista_reportesTableAdapter.Fill(this.DataSet1.splista_reportes, Semestre, Grupo);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception err)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
