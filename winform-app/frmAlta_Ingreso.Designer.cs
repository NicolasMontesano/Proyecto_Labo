namespace winform_app
{
    partial class frmAlta_Ingreso
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtDNIAlumno = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.cbxFechaManual = new System.Windows.Forms.CheckBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.gbxIngreso = new System.Windows.Forms.GroupBox();
            this.grbxSalida = new System.Windows.Forms.GroupBox();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.txtMinutosSalida = new System.Windows.Forms.TextBox();
            this.lblMinutosSalida = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.cbxHoraSalida = new System.Windows.Forms.CheckBox();
            this.gbxIngreso.SuspendLayout();
            this.grbxSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(41, 37);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(67, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI Alumno:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(15, 88);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(199, 88);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(47, 13);
            this.lblMinutos.TabIndex = 3;
            this.lblMinutos.Text = "Minutos:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(54, 37);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(266, 20);
            this.dtpFechaIngreso.TabIndex = 4;
            // 
            // txtDNIAlumno
            // 
            this.txtDNIAlumno.Location = new System.Drawing.Point(114, 34);
            this.txtDNIAlumno.Name = "txtDNIAlumno";
            this.txtDNIAlumno.Size = new System.Drawing.Size(191, 20);
            this.txtDNIAlumno.TabIndex = 1;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(54, 85);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(94, 20);
            this.txtHora.TabIndex = 6;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(252, 85);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(94, 20);
            this.txtMinutos.TabIndex = 7;
            // 
            // cbxFechaManual
            // 
            this.cbxFechaManual.AutoSize = true;
            this.cbxFechaManual.Location = new System.Drawing.Point(114, 79);
            this.cbxFechaManual.Name = "cbxFechaManual";
            this.cbxFechaManual.Size = new System.Drawing.Size(211, 17);
            this.cbxFechaManual.TabIndex = 8;
            this.cbxFechaManual.Text = "Cargar Fecha de entrada Manualmente";
            this.cbxFechaManual.UseVisualStyleBackColor = true;
            this.cbxFechaManual.CheckedChanged += new System.EventHandler(this.cbxFechaManual_CheckedChanged);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIngreso.Location = new System.Drawing.Point(440, 368);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 9;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // gbxIngreso
            // 
            this.gbxIngreso.Controls.Add(this.dtpFechaIngreso);
            this.gbxIngreso.Controls.Add(this.lblFecha);
            this.gbxIngreso.Controls.Add(this.lblHora);
            this.gbxIngreso.Controls.Add(this.txtMinutos);
            this.gbxIngreso.Controls.Add(this.lblMinutos);
            this.gbxIngreso.Controls.Add(this.txtHora);
            this.gbxIngreso.Location = new System.Drawing.Point(44, 113);
            this.gbxIngreso.Name = "gbxIngreso";
            this.gbxIngreso.Size = new System.Drawing.Size(356, 134);
            this.gbxIngreso.TabIndex = 10;
            this.gbxIngreso.TabStop = false;
            this.gbxIngreso.Text = "Ingreso";
            // 
            // grbxSalida
            // 
            this.grbxSalida.Controls.Add(this.lblHoraSalida);
            this.grbxSalida.Controls.Add(this.txtMinutosSalida);
            this.grbxSalida.Controls.Add(this.lblMinutosSalida);
            this.grbxSalida.Controls.Add(this.txtHoraSalida);
            this.grbxSalida.Location = new System.Drawing.Point(44, 296);
            this.grbxSalida.Name = "grbxSalida";
            this.grbxSalida.Size = new System.Drawing.Size(356, 95);
            this.grbxSalida.TabIndex = 11;
            this.grbxSalida.TabStop = false;
            this.grbxSalida.Text = "Salida";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(15, 45);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(33, 13);
            this.lblHoraSalida.TabIndex = 2;
            this.lblHoraSalida.Text = "Hora:";
            // 
            // txtMinutosSalida
            // 
            this.txtMinutosSalida.Location = new System.Drawing.Point(252, 42);
            this.txtMinutosSalida.Name = "txtMinutosSalida";
            this.txtMinutosSalida.Size = new System.Drawing.Size(94, 20);
            this.txtMinutosSalida.TabIndex = 7;
            // 
            // lblMinutosSalida
            // 
            this.lblMinutosSalida.AutoSize = true;
            this.lblMinutosSalida.Location = new System.Drawing.Point(199, 45);
            this.lblMinutosSalida.Name = "lblMinutosSalida";
            this.lblMinutosSalida.Size = new System.Drawing.Size(47, 13);
            this.lblMinutosSalida.TabIndex = 3;
            this.lblMinutosSalida.Text = "Minutos:";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(54, 42);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(94, 20);
            this.txtHoraSalida.TabIndex = 6;
            // 
            // cbxHoraSalida
            // 
            this.cbxHoraSalida.AutoSize = true;
            this.cbxHoraSalida.Location = new System.Drawing.Point(114, 273);
            this.cbxHoraSalida.Name = "cbxHoraSalida";
            this.cbxHoraSalida.Size = new System.Drawing.Size(208, 17);
            this.cbxHoraSalida.TabIndex = 12;
            this.cbxHoraSalida.Text = "Cargar Horario de Salida Manualmente";
            this.cbxHoraSalida.UseVisualStyleBackColor = true;
            this.cbxHoraSalida.CheckedChanged += new System.EventHandler(this.cbxHoraSalida_CheckedChanged);
            // 
            // frmAlta_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(550, 430);
            this.Controls.Add(this.cbxHoraSalida);
            this.Controls.Add(this.grbxSalida);
            this.Controls.Add(this.gbxIngreso);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.cbxFechaManual);
            this.Controls.Add(this.txtDNIAlumno);
            this.Controls.Add(this.lblDNI);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 469);
            this.Name = "frmAlta_Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlta_Ingreso";
            this.Load += new System.EventHandler(this.frmAlta_Ingreso_Load);
            this.gbxIngreso.ResumeLayout(false);
            this.gbxIngreso.PerformLayout();
            this.grbxSalida.ResumeLayout(false);
            this.grbxSalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtDNIAlumno;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.CheckBox cbxFechaManual;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.GroupBox gbxIngreso;
        private System.Windows.Forms.GroupBox grbxSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.TextBox txtMinutosSalida;
        private System.Windows.Forms.Label lblMinutosSalida;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.CheckBox cbxHoraSalida;
    }
}