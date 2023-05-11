namespace CapaPresentacion
{
    partial class FrmCambiarDatos
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
            this.gbVerificar = new System.Windows.Forms.GroupBox();
            this.txtActualContra = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtIdadmin = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCambiarContraseña = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbVerificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.gbCambiarContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVerificar
            // 
            this.gbVerificar.Controls.Add(this.label3);
            this.gbVerificar.Controls.Add(this.txtActualContra);
            this.gbVerificar.Controls.Add(this.btnValidar);
            this.gbVerificar.Controls.Add(this.txtIdadmin);
            this.gbVerificar.Location = new System.Drawing.Point(9, 12);
            this.gbVerificar.Name = "gbVerificar";
            this.gbVerificar.Size = new System.Drawing.Size(291, 124);
            this.gbVerificar.TabIndex = 37;
            this.gbVerificar.TabStop = false;
            this.gbVerificar.Text = "Verificar Contraseña";
            // 
            // txtActualContra
            // 
            this.txtActualContra.Location = new System.Drawing.Point(75, 28);
            this.txtActualContra.Name = "txtActualContra";
            this.txtActualContra.Size = new System.Drawing.Size(186, 20);
            this.txtActualContra.TabIndex = 28;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(61, 59);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(103, 24);
            this.btnValidar.TabIndex = 32;
            this.btnValidar.Text = "&Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtIdadmin
            // 
            this.txtIdadmin.Font = new System.Drawing.Font("Elephant", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdadmin.Location = new System.Drawing.Point(183, 54);
            this.txtIdadmin.Multiline = true;
            this.txtIdadmin.Name = "txtIdadmin";
            this.txtIdadmin.Size = new System.Drawing.Size(34, 29);
            this.txtIdadmin.TabIndex = 33;
            this.txtIdadmin.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(122, 94);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 24);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "&Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(83, 51);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(186, 20);
            this.txtConfirmarContra.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirmar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nueva:";
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Location = new System.Drawing.Point(83, 25);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(186, 20);
            this.txtNuevaContra.TabIndex = 20;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // gbCambiarContraseña
            // 
            this.gbCambiarContraseña.Controls.Add(this.btnGuardar);
            this.gbCambiarContraseña.Controls.Add(this.txtConfirmarContra);
            this.gbCambiarContraseña.Controls.Add(this.txtNuevaContra);
            this.gbCambiarContraseña.Controls.Add(this.label2);
            this.gbCambiarContraseña.Controls.Add(this.label1);
            this.gbCambiarContraseña.Location = new System.Drawing.Point(321, 12);
            this.gbCambiarContraseña.Name = "gbCambiarContraseña";
            this.gbCambiarContraseña.Size = new System.Drawing.Size(316, 124);
            this.gbCambiarContraseña.TabIndex = 36;
            this.gbCambiarContraseña.TabStop = false;
            this.gbCambiarContraseña.Text = "Cambiar Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Actual:";
            // 
            // FrmCambiarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 148);
            this.Controls.Add(this.gbVerificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbCambiarContraseña);
            this.Name = "FrmCambiarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Datos";
            this.Load += new System.EventHandler(this.FrmCambiarContrasseña_Load);
            this.gbVerificar.ResumeLayout(false);
            this.gbVerificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.gbCambiarContraseña.ResumeLayout(false);
            this.gbCambiarContraseña.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVerificar;
        private System.Windows.Forms.TextBox txtActualContra;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtIdadmin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.GroupBox gbCambiarContraseña;
        private System.Windows.Forms.Label label3;
    }
}