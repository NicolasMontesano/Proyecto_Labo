namespace winform_app
{
    partial class frmClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlu = new System.Windows.Forms.Button();
            this.btnEliminarAlu = new System.Windows.Forms.Button();
            this.btnModificarAl = new System.Windows.Forms.Button();
            this.lblFiltroDni = new System.Windows.Forms.Label();
            this.txtFiltroDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNombreAl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroApeAL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(34, 106);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 45;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(804, 245);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnAgregarAlu
            // 
            this.btnAgregarAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarAlu.Location = new System.Drawing.Point(34, 385);
            this.btnAgregarAlu.Name = "btnAgregarAlu";
            this.btnAgregarAlu.Size = new System.Drawing.Size(99, 26);
            this.btnAgregarAlu.TabIndex = 1;
            this.btnAgregarAlu.Text = "Agregar";
            this.btnAgregarAlu.UseVisualStyleBackColor = false;
            this.btnAgregarAlu.Click += new System.EventHandler(this.btnAgregarAlu_Click);
            // 
            // btnEliminarAlu
            // 
            this.btnEliminarAlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminarAlu.Location = new System.Drawing.Point(286, 385);
            this.btnEliminarAlu.Name = "btnEliminarAlu";
            this.btnEliminarAlu.Size = new System.Drawing.Size(99, 26);
            this.btnEliminarAlu.TabIndex = 2;
            this.btnEliminarAlu.Text = "Eliminar";
            this.btnEliminarAlu.UseVisualStyleBackColor = false;
            this.btnEliminarAlu.Click += new System.EventHandler(this.btnEliminarAlu_Click_1);
            // 
            // btnModificarAl
            // 
            this.btnModificarAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificarAl.Location = new System.Drawing.Point(159, 385);
            this.btnModificarAl.Name = "btnModificarAl";
            this.btnModificarAl.Size = new System.Drawing.Size(99, 26);
            this.btnModificarAl.TabIndex = 3;
            this.btnModificarAl.Text = "Modificar";
            this.btnModificarAl.UseVisualStyleBackColor = false;
            this.btnModificarAl.Click += new System.EventHandler(this.btnModificarAl_Click);
            // 
            // lblFiltroDni
            // 
            this.lblFiltroDni.AutoSize = true;
            this.lblFiltroDni.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroDni.Location = new System.Drawing.Point(601, 54);
            this.lblFiltroDni.Name = "lblFiltroDni";
            this.lblFiltroDni.Size = new System.Drawing.Size(66, 16);
            this.lblFiltroDni.TabIndex = 4;
            this.lblFiltroDni.Text = "Filtrar DNI";
            // 
            // txtFiltroDni
            // 
            this.txtFiltroDni.Location = new System.Drawing.Point(683, 53);
            this.txtFiltroDni.Name = "txtFiltroDni";
            this.txtFiltroDni.Size = new System.Drawing.Size(120, 20);
            this.txtFiltroDni.TabIndex = 5;
            this.txtFiltroDni.TextChanged += new System.EventHandler(this.txtFiltroDni_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(414, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 26);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "FIltrar Nombre";
            // 
            // txtFiltroNombreAl
            // 
            this.txtFiltroNombreAl.Location = new System.Drawing.Point(139, 55);
            this.txtFiltroNombreAl.Name = "txtFiltroNombreAl";
            this.txtFiltroNombreAl.Size = new System.Drawing.Size(141, 20);
            this.txtFiltroNombreAl.TabIndex = 9;
            this.txtFiltroNombreAl.TextChanged += new System.EventHandler(this.txtFiltroNombreAl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar Apellido";
            // 
            // txtFiltroApeAL
            // 
            this.txtFiltroApeAL.Location = new System.Drawing.Point(414, 53);
            this.txtFiltroApeAL.Name = "txtFiltroApeAL";
            this.txtFiltroApeAL.Size = new System.Drawing.Size(143, 20);
            this.txtFiltroApeAL.TabIndex = 11;
            this.txtFiltroApeAL.TextChanged += new System.EventHandler(this.txtFiltroApeAL_TextChanged);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(883, 440);
            this.Controls.Add(this.txtFiltroApeAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroNombreAl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtFiltroDni);
            this.Controls.Add(this.lblFiltroDni);
            this.Controls.Add(this.btnModificarAl);
            this.Controls.Add(this.btnEliminarAlu);
            this.Controls.Add(this.btnAgregarAlu);
            this.Controls.Add(this.dgvClientes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(899, 479);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(899, 479);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregarAlu;
        private System.Windows.Forms.Button btnEliminarAlu;
        private System.Windows.Forms.Button btnModificarAl;
        private System.Windows.Forms.Label lblFiltroDni;
        private System.Windows.Forms.TextBox txtFiltroDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombreAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroApeAL;
    }
}