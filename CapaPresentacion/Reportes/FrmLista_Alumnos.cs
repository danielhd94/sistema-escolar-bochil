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
    public partial class FrmLista_Alumnos : Form
    {
        int _Semestre;

        public int Semestre
        {
            get { return _Semestre; }
            set { _Semestre = value; }
        }
        string _Grupo;

        public string Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        public FrmLista_Alumnos()
        {
            InitializeComponent();
        }

        private void FrmLista_Alumnos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSet1.spgrupos' Puede moverla o quitarla según sea necesario.
                this.spgruposTableAdapter.Fill(this.DataSet1.spgrupos, Semestre, Grupo);


                this.reportViewer1.RefreshReport();
            }
            catch (Exception err)
            { 
                this.reportViewer1.RefreshReport();
            }
            }
        }
    }

