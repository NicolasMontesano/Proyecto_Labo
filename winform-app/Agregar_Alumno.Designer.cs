namespace winform_app
{
    partial class frmAgregarAL
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDniAl = new System.Windows.Forms.TextBox();
            this.lblNomAl = new System.Windows.Forms.Label();
            this.lblApellidoAl = new System.Windows.Forms.Label();
            this.lblFechNacAl = new System.Windows.Forms.Label();
            this.dtpFechNacAl = new System.Windows.Forms.DateTimePicker();
            this.lblDniAl = new System.Windows.Forms.Label();
            this.btnAgregarAlu = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUsserAl = new System.Windows.Forms.TextBox();
            this.txtPassUsu = new System.Windows.Forms.TextBox();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblContrasñaAl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(170, 111);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDniAl
            // 
            this.txtDniAl.Location = new System.Drawing.Point(170, 175);
            this.txtDniAl.Name = "txtDniAl";
            this.txtDniAl.Size = new System.Drawing.Size(209, 20);
            this.txtDniAl.TabIndex = 3;
            // 
            // lblNomAl
            // 
            this.lblNomAl.AutoSize = true;
            this.lblNomAl.Location = new System.Drawing.Point(102, 80);
            this.lblNomAl.Name = "lblNomAl";
            this.lblNomAl.Size = new System.Drawing.Size(47, 13);
            this.lblNomAl.TabIndex = 5;
            this.lblNomAl.Text = "Nombre:";
            // 
            // lblApellidoAl
            // 
            this.lblApellidoAl.AutoSize = true;
            this.lblApellidoAl.Location = new System.Drawing.Point(102, 114);
            this.lblApellidoAl.Name = "lblApellidoAl";
            this.lblApellidoAl.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoAl.TabIndex = 6;
            this.lblApellidoAl.Text = "Apellido:";
            // 
            // lblFechNacAl
            // 
            this.lblFechNacAl.AutoSize = true;
            this.lblFechNacAl.Location = new System.Drawing.Point(56, 145);
            this.lblFechNacAl.Name = "lblFechNacAl";
            this.lblFechNacAl.Size = new System.Drawing.Size(93, 13);
            this.lblFechNacAl.TabIndex = 7;
            this.lblFechNacAl.Text = "FechaNacimiento:";
            // 
            // dtpFechNacAl
            // 
            this.dtpFechNacAl.Location = new System.Drawing.Point(170, 145);
            this.dtpFechNacAl.MaximumSize = new System.Drawing.Size(209, 20);
            this.dtpFechNacAl.MinimumSize = new System.Drawing.Size(209, 20);
            this.dtpFechNacAl.Name = "dtpFechNacAl";
            this.dtpFechNacAl.Size = new System.Drawing.Size(209, 20);
            this.dtpFechNacAl.TabIndex = 8;
            // 
            // lblDniAl
            // 
            this.lblDniAl.AutoSize = true;
            this.lblDniAl.Location = new System.Drawing.Point(120, 178);
            this.lblDniAl.Name = "lblDniAl";
            this.lblDniAl.Size = new System.Drawing.Size(29, 13);
            this.lblDniAl.TabIndex = 9;
            this.lblDniAl.Text = "DNI:";
            // 
            // btnAgregarAlu
            // 
            this.btnAgregarAlu.Location = new System.Drawing.Point(138, 317);
            this.btnAgregarAlu.Name = "btnAgregarAlu";
            this.btnAgregarAlu.Size = new System.Drawing.Size(101, 25);
            this.btnAgregarAlu.TabIndex = 10;
            this.btnAgregarAlu.Text = "ACEPTAR";
            this.btnAgregarAlu.UseVisualStyleBackColor = true;
            this.btnAgregarAlu.Click += new System.EventHandler(this.btnAgregarAlu_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(278, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 25);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUsserAl
            // 
            this.txtUsserAl.Location = new System.Drawing.Point(170, 209);
            this.txtUsserAl.Name = "txtUsserAl";
            this.txtUsserAl.Size = new System.Drawing.Size(209, 20);
            this.txtUsserAl.TabIndex = 12;
            // 
            // txtPassUsu
            // 
            this.txtPassUsu.Location = new System.Drawing.Point(170, 244);
            this.txtPassUsu.Name = "txtPassUsu";
            this.txtPassUsu.Size = new System.Drawing.Size(209, 20);
            this.txtPassUsu.TabIndex = 13;
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(103, 212);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(46, 13);
            this.lblUsu.TabIndex = 14;
            this.lblUsu.Text = "Usuario:";
            // 
            // lblContrasñaAl
            // 
            this.lblContrasñaAl.AutoSize = true;
            this.lblContrasñaAl.Location = new System.Drawing.Point(85, 247);
            this.lblContrasñaAl.Name = "lblContrasñaAl";
            this.lblContrasñaAl.Size = new System.Drawing.Size(64, 13);
            this.lblContrasñaAl.TabIndex = 15;
            this.lblContrasñaAl.Text = "Contraseña:";
            // 
            // frmAgregarAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 414);
            this.Controls.Add(this.lblContrasñaAl);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.txtPassUsu);
            this.Controls.Add(this.txtUsserAl);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarAlu);
            this.Controls.Add(this.lblDniAl);
            this.Controls.Add(this.dtpFechNacAl);
            this.Controls.Add(this.lblFechNacAl);
            this.Controls.Add(this.lblApellidoAl);
            this.Controls.Add(this.lblNomAl);
            this.Controls.Add(this.txtDniAl);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAgregarAL";
            this.Text = "Agregar_Alumno";
            this.Load += new System.EventHandler(this.frmAgregarAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDniAl;
        private System.Windows.Forms.Label lblNomAl;
        private System.Windows.Forms.Label lblApellidoAl;
        private System.Windows.Forms.Label lblFechNacAl;
        private System.Windows.Forms.DateTimePicker dtpFechNacAl;
        private System.Windows.Forms.Label lblDniAl;
        private System.Windows.Forms.Button btnAgregarAlu;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsserAl;
        private System.Windows.Forms.TextBox txtPassUsu;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblContrasñaAl;
    }
}