namespace CapaPresentacion
{
    partial class frmDetalleAlumno
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spdetalleAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetalle_Alumno = new CapaPresentacion.dsDetalle_Alumno();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spdetalleAlumnoTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalleAlumnoTableAdapter();
            this.spdetalle_reportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_reportesTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_reportesTableAdapter();
            this.spdetalle_permisosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_permisosTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_permisosTableAdapter();
            this.spdetalle_becasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_becasTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_becasTableAdapter();
            this.spdetalle_emprendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_emprendedoresTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_emprendedoresTableAdapter();
            this.spdetalle_practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_practicasTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_practicasTableAdapter();
            this.spdetalle_serviciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_serviciosTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_serviciosTableAdapter();
            this.spdetalle_seguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spdetalle_seguroTableAdapter = new CapaPresentacion.dsDetalle_AlumnoTableAdapters.spdetalle_seguroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalleAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalle_Alumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_reportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_permisosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_becasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_emprendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_seguroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spdetalleAlumnoBindingSource
            // 
            this.spdetalleAlumnoBindingSource.DataMember = "spdetalleAlumno";
            this.spdetalleAlumnoBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // dsDetalle_Alumno
            // 
            this.dsDetalle_Alumno.DataSetName = "dsDetalle_Alumno";
            this.dsDetalle_Alumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spdetalleAlumnoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.spdetalle_reportesBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.spdetalle_permisosBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.spdetalle_becasBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.spdetalle_emprendedoresBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.spdetalle_practicasBindingSource;
            reportDataSource7.Name = "DataSet7";
            reportDataSource7.Value = this.spdetalle_serviciosBindingSource;
            reportDataSource8.Name = "DataSet8";
            reportDataSource8.Value = this.spdetalle_seguroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptDetalle_Alumno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(733, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // spdetalleAlumnoTableAdapter
            // 
            this.spdetalleAlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_reportesBindingSource
            // 
            this.spdetalle_reportesBindingSource.DataMember = "spdetalle_reportes";
            this.spdetalle_reportesBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_reportesTableAdapter
            // 
            this.spdetalle_reportesTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_permisosBindingSource
            // 
            this.spdetalle_permisosBindingSource.DataMember = "spdetalle_permisos";
            this.spdetalle_permisosBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_permisosTableAdapter
            // 
            this.spdetalle_permisosTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_becasBindingSource
            // 
            this.spdetalle_becasBindingSource.DataMember = "spdetalle_becas";
            this.spdetalle_becasBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_becasTableAdapter
            // 
            this.spdetalle_becasTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_emprendedoresBindingSource
            // 
            this.spdetalle_emprendedoresBindingSource.DataMember = "spdetalle_emprendedores";
            this.spdetalle_emprendedoresBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_emprendedoresTableAdapter
            // 
            this.spdetalle_emprendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_practicasBindingSource
            // 
            this.spdetalle_practicasBindingSource.DataMember = "spdetalle_practicas";
            this.spdetalle_practicasBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_practicasTableAdapter
            // 
            this.spdetalle_practicasTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_serviciosBindingSource
            // 
            this.spdetalle_serviciosBindingSource.DataMember = "spdetalle_servicios";
            this.spdetalle_serviciosBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_serviciosTableAdapter
            // 
            this.spdetalle_serviciosTableAdapter.ClearBeforeFill = true;
            // 
            // spdetalle_seguroBindingSource
            // 
            this.spdetalle_seguroBindingSource.DataMember = "spdetalle_seguro";
            this.spdetalle_seguroBindingSource.DataSource = this.dsDetalle_Alumno;
            // 
            // spdetalle_seguroTableAdapter
            // 
            this.spdetalle_seguroTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetalleAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 490);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDetalleAlumno";
            this.Text = "frmDetalleAlumno";
            this.Load += new System.EventHandler(this.frmDetalleAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spdetalleAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalle_Alumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_reportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_permisosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_becasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_emprendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_serviciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdetalle_seguroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spdetalleAlumnoBindingSource;
        private dsDetalle_Alumno dsDetalle_Alumno;
        private dsDetalle_AlumnoTableAdapters.spdetalleAlumnoTableAdapter spdetalleAlumnoTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_reportesBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_reportesTableAdapter spdetalle_reportesTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_permisosBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_permisosTableAdapter spdetalle_permisosTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_becasBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_becasTableAdapter spdetalle_becasTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_emprendedoresBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_emprendedoresTableAdapter spdetalle_emprendedoresTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_practicasBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_practicasTableAdapter spdetalle_practicasTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_serviciosBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_serviciosTableAdapter spdetalle_serviciosTableAdapter;
        private System.Windows.Forms.BindingSource spdetalle_seguroBindingSource;
        private dsDetalle_AlumnoTableAdapters.spdetalle_seguroTableAdapter spdetalle_seguroTableAdapter;
    }
}