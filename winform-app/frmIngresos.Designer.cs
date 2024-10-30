namespace winform_app
{
    partial class frmIngresos
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbxSoloActivos = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.dtpFiltro = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.panelHorario = new System.Windows.Forms.Panel();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cboHoraDesde = new System.Windows.Forms.ComboBox();
            this.cboHoraHasta = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.cboMinutosDesde = new System.Windows.Forms.ComboBox();
            this.cboMinutosHasta = new System.Windows.Forms.ComboBox();
            this.btnNuevoIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.panelHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(193, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(387, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(106, 24);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtro";
            // 
            // cbxSoloActivos
            // 
            this.cbxSoloActivos.AutoSize = true;
            this.cbxSoloActivos.Location = new System.Drawing.Point(100, 161);
            this.cbxSoloActivos.Name = "cbxSoloActivos";
            this.cbxSoloActivos.Size = new System.Drawing.Size(128, 17);
            this.cbxSoloActivos.TabIndex = 2;
            this.cbxSoloActivos.Text = "Solo Alumnos Activos";
            this.cbxSoloActivos.UseVisualStyleBackColor = true;
            this.cbxSoloActivos.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(827, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIngresos.Location = new System.Drawing.Point(100, 209);
            this.dgvIngresos.MultiSelect = false;
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.RowHeadersWidth = 45;
            this.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresos.Size = new System.Drawing.Size(802, 321);
            this.dgvIngresos.TabIndex = 4;
            // 
            // dtpFiltro
            // 
            this.dtpFiltro.Location = new System.Drawing.Point(109, 68);
            this.dtpFiltro.MaxDate = new System.DateTime(2100, 10, 28, 21, 50, 0, 0);
            this.dtpFiltro.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFiltro.Name = "dtpFiltro";
            this.dtpFiltro.Size = new System.Drawing.Size(200, 20);
            this.dtpFiltro.TabIndex = 5;
            this.dtpFiltro.Value = new System.DateTime(2024, 10, 28, 0, 0, 0, 0);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(11, 35);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "Desde";
            // 
            // panelHorario
            // 
            this.panelHorario.Controls.Add(this.cboMinutosHasta);
            this.panelHorario.Controls.Add(this.cboMinutosDesde);
            this.panelHorario.Controls.Add(this.lblMinutos);
            this.panelHorario.Controls.Add(this.lblHora);
            this.panelHorario.Controls.Add(this.cboHoraHasta);
            this.panelHorario.Controls.Add(this.cboHoraDesde);
            this.panelHorario.Controls.Add(this.lblHasta);
            this.panelHorario.Controls.Add(this.lblDesde);
            this.panelHorario.Location = new System.Drawing.Point(344, 59);
            this.panelHorario.Name = "panelHorario";
            this.panelHorario.Size = new System.Drawing.Size(369, 119);
            this.panelHorario.TabIndex = 7;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(14, 83);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta";
            // 
            // cboHoraDesde
            // 
            this.cboHoraDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraDesde.FormattingEnabled = true;
            this.cboHoraDesde.Location = new System.Drawing.Point(58, 32);
            this.cboHoraDesde.Name = "cboHoraDesde";
            this.cboHoraDesde.Size = new System.Drawing.Size(87, 21);
            this.cboHoraDesde.TabIndex = 8;
            // 
            // cboHoraHasta
            // 
            this.cboHoraHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraHasta.FormattingEnabled = true;
            this.cboHoraHasta.Location = new System.Drawing.Point(58, 80);
            this.cboHoraHasta.Name = "cboHoraHasta";
            this.cboHoraHasta.Size = new System.Drawing.Size(87, 21);
            this.cboHoraHasta.TabIndex = 9;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(84, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "Hora";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(244, 9);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 11;
            this.lblMinutos.Text = "Minutos";
            // 
            // cboMinutosDesde
            // 
            this.cboMinutosDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinutosDesde.FormattingEnabled = true;
            this.cboMinutosDesde.Location = new System.Drawing.Point(214, 32);
            this.cboMinutosDesde.Name = "cboMinutosDesde";
            this.cboMinutosDesde.Size = new System.Drawing.Size(87, 21);
            this.cboMinutosDesde.TabIndex = 12;
            // 
            // cboMinutosHasta
            // 
            this.cboMinutosHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinutosHasta.FormattingEnabled = true;
            this.cboMinutosHasta.Location = new System.Drawing.Point(214, 80);
            this.cboMinutosHasta.Name = "cboMinutosHasta";
            this.cboMinutosHasta.Size = new System.Drawing.Size(87, 21);
            this.cboMinutosHasta.TabIndex = 13;
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.Location = new System.Drawing.Point(950, 463);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(116, 23);
            this.btnNuevoIngreso.TabIndex = 8;
            this.btnNuevoIngreso.Text = "Nuevo Ingreso";
            this.btnNuevoIngreso.UseVisualStyleBackColor = true;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 542);
            this.Controls.Add(this.btnNuevoIngreso);
            this.Controls.Add(this.panelHorario);
            this.Controls.Add(this.dtpFiltro);
            this.Controls.Add(this.dgvIngresos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxSoloActivos);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmIngresos";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.panelHorario.ResumeLayout(false);
            this.panelHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.CheckBox cbxSoloActivos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.DateTimePicker dtpFiltro;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Panel panelHorario;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cboHoraHasta;
        private System.Windows.Forms.ComboBox cboHoraDesde;
        private System.Windows.Forms.ComboBox cboMinutosHasta;
        private System.Windows.Forms.ComboBox cboMinutosDesde;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnNuevoIngreso;
    }
}