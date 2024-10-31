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
            this.btnFiltroDni = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.lblFiltroDni.Location = new System.Drawing.Point(31, 54);
            this.lblFiltroDni.Name = "lblFiltroDni";
            this.lblFiltroDni.Size = new System.Drawing.Size(66, 16);
            this.lblFiltroDni.TabIndex = 4;
            this.lblFiltroDni.Text = "Filtrar DNI";
            // 
            // txtFiltroDni
            // 
            this.txtFiltroDni.Location = new System.Drawing.Point(119, 53);
            this.txtFiltroDni.Name = "txtFiltroDni";
            this.txtFiltroDni.Size = new System.Drawing.Size(104, 20);
            this.txtFiltroDni.TabIndex = 5;
            // 
            // btnFiltroDni
            // 
            this.btnFiltroDni.Location = new System.Drawing.Point(229, 53);
            this.btnFiltroDni.Name = "btnFiltroDni";
            this.btnFiltroDni.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroDni.TabIndex = 6;
            this.btnFiltroDni.Text = "BUSCAR";
            this.btnFiltroDni.UseVisualStyleBackColor = true;
            this.btnFiltroDni.Click += new System.EventHandler(this.btnFiltroDni_Click);
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
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(883, 440);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFiltroDni);
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
        private System.Windows.Forms.Button btnFiltroDni;
        private System.Windows.Forms.Button btnCancelar;
    }
}