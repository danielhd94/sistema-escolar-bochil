namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.listaBecarios = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEmprendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.listaReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSeguro = new System.Windows.Forms.ToolStripMenuItem();
            this.listaServicio = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPracticas = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolladoPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verionDelSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(756, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(72, 23);
            this.fileMenu.Text = "&Sistema";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.exitToolStripMenuItem.Text = "&Cerrar Sesion";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.editMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.editMenu.Image = global::CapaPresentacion.Properties.Resources.ajuste1;
            this.editMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(126, 23);
            this.editMenu.Text = "&Configuracion";
            this.editMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cambiarContraseñaToolStripMenuItem.Text = "C&ambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaAumnos,
            this.listaBecarios,
            this.listaEmprendedores,
            this.listaPermisos,
            this.listaReportes,
            this.listaSeguro,
            this.listaServicio,
            this.listaPracticas});
            this.toolsMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(75, 23);
            this.toolsMenu.Text = "&Listados";
            // 
            // listaAumnos
            // 
            this.listaAumnos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAumnos.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaAumnos.Name = "listaAumnos";
            this.listaAumnos.Size = new System.Drawing.Size(284, 24);
            this.listaAumnos.Text = "Li&sta de alumnos";
            this.listaAumnos.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // listaBecarios
            // 
            this.listaBecarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaBecarios.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaBecarios.Name = "listaBecarios";
            this.listaBecarios.Size = new System.Drawing.Size(284, 24);
            this.listaBecarios.Text = "Lista de becarios";
            this.listaBecarios.Click += new System.EventHandler(this.listaDeBecariosToolStripMenuItem_Click);
            // 
            // listaEmprendedores
            // 
            this.listaEmprendedores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEmprendedores.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaEmprendedores.Name = "listaEmprendedores";
            this.listaEmprendedores.Size = new System.Drawing.Size(284, 24);
            this.listaEmprendedores.Text = "Lista de Emprendedores";
            this.listaEmprendedores.Click += new System.EventHandler(this.listaDeEmprendedoresToolStripMenuItem_Click);
            // 
            // listaPermisos
            // 
            this.listaPermisos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPermisos.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaPermisos.Name = "listaPermisos";
            this.listaPermisos.Size = new System.Drawing.Size(284, 24);
            this.listaPermisos.Text = "Lista de Permisos";
            this.listaPermisos.Click += new System.EventHandler(this.listaDePermisosToolStripMenuItem_Click);
            // 
            // listaReportes
            // 
            this.listaReportes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaReportes.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaReportes.Name = "listaReportes";
            this.listaReportes.Size = new System.Drawing.Size(284, 24);
            this.listaReportes.Text = "Lista de Reportes";
            this.listaReportes.Click += new System.EventHandler(this.listaDeReportesToolStripMenuItem_Click);
            // 
            // listaSeguro
            // 
            this.listaSeguro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSeguro.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaSeguro.Name = "listaSeguro";
            this.listaSeguro.Size = new System.Drawing.Size(284, 24);
            this.listaSeguro.Text = "Lista de Seguro Social";
            this.listaSeguro.Click += new System.EventHandler(this.listaDeSeguroSocialToolStripMenuItem_Click);
            // 
            // listaServicio
            // 
            this.listaServicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaServicio.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaServicio.Name = "listaServicio";
            this.listaServicio.Size = new System.Drawing.Size(284, 24);
            this.listaServicio.Text = "Lista de Servicio Social";
            this.listaServicio.Click += new System.EventHandler(this.listaDeServicioSocialToolStripMenuItem_Click);
            // 
            // listaPracticas
            // 
            this.listaPracticas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPracticas.ForeColor = System.Drawing.Color.SteelBlue;
            this.listaPracticas.Name = "listaPracticas";
            this.listaPracticas.Size = new System.Drawing.Size(284, 24);
            this.listaPracticas.Text = "Lista de Prácticas Profesionales";
            this.listaPracticas.Click += new System.EventHandler(this.listaDePrácticasProfesionalesToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.desarrolladoPorToolStripMenuItem,
            this.verionDelSoftwareToolStripMenuItem});
            this.windowsMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.windowsMenu.Image = global::CapaPresentacion.Properties.Resources.informacion1;
            this.windowsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(74, 23);
            this.windowsMenu.Text = "&Info...";
            this.windowsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // desarrolladoPorToolStripMenuItem
            // 
            this.desarrolladoPorToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desarrolladoPorToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.desarrolladoPorToolStripMenuItem.Name = "desarrolladoPorToolStripMenuItem";
            this.desarrolladoPorToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.desarrolladoPorToolStripMenuItem.Text = "Desarrollado por...";
            // 
            // verionDelSoftwareToolStripMenuItem
            // 
            this.verionDelSoftwareToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verionDelSoftwareToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.verionDelSoftwareToolStripMenuItem.Name = "verionDelSoftwareToolStripMenuItem";
            this.verionDelSoftwareToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.verionDelSoftwareToolStripMenuItem.Text = "Vercion del software";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualToolStripMenuItem});
            this.helpMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.helpMenu.Image = global::CapaPresentacion.Properties.Resources.ayuda1;
            this.helpMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(77, 23);
            this.helpMenu.Text = "Ay&uda";
            this.helpMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManualToolStripMenuItem
            // 
            this.ManualToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem";
            this.ManualToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.ManualToolStripMenuItem.Text = "Manual de Usuario";
            this.ManualToolStripMenuItem.Click += new System.EventHandler(this.ManualToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip.BackgroundImage")));
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 465);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip.Size = new System.Drawing.Size(756, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 27);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(756, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(36, 75);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(60, 24);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "label1";
            this.lblusuario.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 487);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblusuario);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISCOES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem listaAumnos;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolladoPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verionDelSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ToolStripMenuItem listaBecarios;
        private System.Windows.Forms.ToolStripMenuItem listaEmprendedores;
        private System.Windows.Forms.ToolStripMenuItem listaPermisos;
        private System.Windows.Forms.ToolStripMenuItem listaReportes;
        private System.Windows.Forms.ToolStripMenuItem listaSeguro;
        private System.Windows.Forms.ToolStripMenuItem listaServicio;
        private System.Windows.Forms.ToolStripMenuItem listaPracticas;
    }
}



