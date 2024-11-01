namespace winform_app
{
    partial class AgregarEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombreEmple = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtApellidoEmple = new System.Windows.Forms.TextBox();
            this.txtDNIemple = new System.Windows.Forms.TextBox();
            this.texUsuarioEmple = new System.Windows.Forms.TextBox();
            this.texContraEmple = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.cbCatEmple = new System.Windows.Forms.ComboBox();
            this.dtpFechNacEmp = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(128, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(128, 82);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(86, 127);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblNacimiento.TabIndex = 2;
            this.lblNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(128, 164);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(129, 268);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(55, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Categoria:";
            // 
            // txtNombreEmple
            // 
            this.txtNombreEmple.Location = new System.Drawing.Point(210, 39);
            this.txtNombreEmple.Name = "txtNombreEmple";
            this.txtNombreEmple.Size = new System.Drawing.Size(209, 20);
            this.txtNombreEmple.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(230, 318);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtApellidoEmple
            // 
            this.txtApellidoEmple.Location = new System.Drawing.Point(210, 79);
            this.txtApellidoEmple.Name = "txtApellidoEmple";
            this.txtApellidoEmple.Size = new System.Drawing.Size(209, 20);
            this.txtApellidoEmple.TabIndex = 7;
            // 
            // txtDNIemple
            // 
            this.txtDNIemple.Location = new System.Drawing.Point(210, 164);
            this.txtDNIemple.Name = "txtDNIemple";
            this.txtDNIemple.Size = new System.Drawing.Size(209, 20);
            this.txtDNIemple.TabIndex = 8;
            // 
            // texUsuarioEmple
            // 
            this.texUsuarioEmple.Location = new System.Drawing.Point(210, 201);
            this.texUsuarioEmple.Name = "texUsuarioEmple";
            this.texUsuarioEmple.Size = new System.Drawing.Size(209, 20);
            this.texUsuarioEmple.TabIndex = 9;
            // 
            // texContraEmple
            // 
            this.texContraEmple.Location = new System.Drawing.Point(210, 234);
            this.texContraEmple.Name = "texContraEmple";
            this.texContraEmple.Size = new System.Drawing.Size(209, 20);
            this.texContraEmple.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(129, 201);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(129, 234);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(64, 13);
            this.lblContra.TabIndex = 12;
            this.lblContra.Text = "Contraseña:";
            // 
            // cbCatEmple
            // 
            this.cbCatEmple.FormattingEnabled = true;
            this.cbCatEmple.Location = new System.Drawing.Point(210, 268);
            this.cbCatEmple.Name = "cbCatEmple";
            this.cbCatEmple.Size = new System.Drawing.Size(209, 21);
            this.cbCatEmple.TabIndex = 13;
            // 
            // dtpFechNacEmp
            // 
            this.dtpFechNacEmp.Location = new System.Drawing.Point(210, 121);
            this.dtpFechNacEmp.MaximumSize = new System.Drawing.Size(209, 20);
            this.dtpFechNacEmp.MinimumSize = new System.Drawing.Size(209, 20);
            this.dtpFechNacEmp.Name = "dtpFechNacEmp";
            this.dtpFechNacEmp.Size = new System.Drawing.Size(209, 20);
            this.dtpFechNacEmp.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(324, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(574, 371);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpFechNacEmp);
            this.Controls.Add(this.cbCatEmple);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.texContraEmple);
            this.Controls.Add(this.texUsuarioEmple);
            this.Controls.Add(this.txtDNIemple);
            this.Controls.Add(this.txtApellidoEmple);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreEmple);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(590, 410);
            this.Name = "AgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombreEmple;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtApellidoEmple;
        private System.Windows.Forms.TextBox txtDNIemple;
        private System.Windows.Forms.TextBox texUsuarioEmple;
        private System.Windows.Forms.TextBox texContraEmple;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.ComboBox cbCatEmple;
        private System.Windows.Forms.DateTimePicker dtpFechNacEmp;
        private System.Windows.Forms.Button btnCancelar;
    }
}