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
            this.lblFecha.Location = new System.Drawing.Point(68, 114);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(75, 165);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora:";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(259, 165);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(47, 13);
            this.lblMinutos.TabIndex = 3;
            this.lblMinutos.Text = "Minutos:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(114, 114);
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
            this.txtHora.Location = new System.Drawing.Point(114, 162);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(94, 20);
            this.txtHora.TabIndex = 6;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(312, 162);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(94, 20);
            this.txtMinutos.TabIndex = 7;
            // 
            // cbxFechaManual
            // 
            this.cbxFechaManual.AutoSize = true;
            this.cbxFechaManual.Location = new System.Drawing.Point(114, 79);
            this.cbxFechaManual.Name = "cbxFechaManual";
            this.cbxFechaManual.Size = new System.Drawing.Size(157, 17);
            this.cbxFechaManual.TabIndex = 8;
            this.cbxFechaManual.Text = "Cargar Fecha Manualmente";
            this.cbxFechaManual.UseVisualStyleBackColor = true;
            this.cbxFechaManual.CheckedChanged += new System.EventHandler(this.cbxFechaManual_CheckedChanged);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(44, 252);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 9;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // frmAlta_Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 386);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.cbxFechaManual);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDNIAlumno);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDNI);
            this.Name = "frmAlta_Ingreso";
            this.Text = "frmAlta_Ingreso";
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
    }
}