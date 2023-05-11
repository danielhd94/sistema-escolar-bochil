namespace CapaPresentacion
{
    partial class FrmLista_Alumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spgruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new CapaPresentacion.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spgruposTableAdapter = new CapaPresentacion.DataSet1TableAdapters.spgruposTableAdapter();
            this.splista_becariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splista_becariosTableAdapter = new CapaPresentacion.DataSet1TableAdapters.splista_becariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spgruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splista_becariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spgruposBindingSource
            // 
            this.spgruposBindingSource.DataMember = "spgrupos";
            this.spgruposBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spgruposBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptListaAlumnos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(863, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // spgruposTableAdapter
            // 
            this.spgruposTableAdapter.ClearBeforeFill = true;
            // 
            // splista_becariosBindingSource
            // 
            this.splista_becariosBindingSource.DataMember = "splista_becarios";
            this.splista_becariosBindingSource.DataSource = this.DataSet1;
            // 
            // splista_becariosTableAdapter
            // 
            this.splista_becariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLista_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmLista_Alumnos";
            this.Text = "FrmLista_Alumnos";
            this.Load += new System.EventHandler(this.FrmLista_Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spgruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splista_becariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spgruposBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.spgruposTableAdapter spgruposTableAdapter;
        private System.Windows.Forms.BindingSource splista_becariosBindingSource;
        private DataSet1TableAdapters.splista_becariosTableAdapter splista_becariosTableAdapter;
    }
}