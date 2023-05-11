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
    public partial class FrmManual : Form
    {
        public bool PDFAvailable;
        public FrmManual()
        {
            InitializeComponent();
            PDFAvailable = pdf.LoadFile("manual.pdf".ToString());
        }

        private void FrmManual_Load(object sender, EventArgs e)
        {
            if (PDFAvailable == true)
            {
                pdf.LoadFile("manual.pdf".ToString());
                pdf.setShowToolbar(false); //disable pdf toolbar.
                pdf.Enabled = true;

            }
        }
    }
}
