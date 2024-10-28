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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(34, 32);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 45;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(946, 346);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnAgregarAlu
            // 
            this.btnAgregarAlu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarAlu.Location = new System.Drawing.Point(34, 436);
            this.btnAgregarAlu.Name = "btnAgregarAlu";
            this.btnAgregarAlu.Size = new System.Drawing.Size(125, 36);
            this.btnAgregarAlu.TabIndex = 1;
            this.btnAgregarAlu.Text = "AGREGAR";
            this.btnAgregarAlu.UseVisualStyleBackColor = false;
            this.btnAgregarAlu.Click += new System.EventHandler(this.btnAgregarAlu_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 619);
            this.Controls.Add(this.btnAgregarAlu);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregarAlu;
    }
}