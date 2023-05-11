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
    public partial class frmLista_Becarios : Form
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


        public frmLista_Becarios()
        {
            InitializeComponent();
        }

        private void frmLista_Becarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSet1.splista_becarios' Puede moverla o quitarla según sea necesario.
                this.splista_becariosTableAdapter.Fill(this.DataSet1.splista_becarios, Semestre, Grupo);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception err)
            {
                this.reportViewer1.RefreshReport();
            }

        }
    }
}
