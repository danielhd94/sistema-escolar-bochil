namespace CapaPresentacion
{
    partial class frmLista_Emprendedores
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new CapaPresentacion.DataSet1();
            this.splista_emprendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splista_emprendedoresTableAdapter = new CapaPresentacion.DataSet1TableAdapters.splista_emprendedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splista_emprendedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.splista_emprendedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptLista_emprendedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splista_emprendedoresBindingSource
            // 
            this.splista_emprendedoresBindingSource.DataMember = "splista_emprendedores";
            this.splista_emprendedoresBindingSource.DataSource = this.DataSet1;
            // 
            // splista_emprendedoresTableAdapter
            // 
            this.splista_emprendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmLista_Emprendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmLista_Emprendedores";
            this.Text = ".::Actividades Emprendedores::.";
            this.Load += new System.EventHandler(this.frmLista_Emprendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splista_emprendedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource splista_emprendedoresBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.splista_emprendedoresTableAdapter splista_emprendedoresTableAdapter;
    }
}