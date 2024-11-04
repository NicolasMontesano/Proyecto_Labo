namespace winform_app
{
    partial class frmFacturas
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnTOTAL = new System.Windows.Forms.Button();
            this.lblTotalFacutrado = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(31, 67);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(657, 217);
            this.dgvFacturas.TabIndex = 0;
            // 
            // btnTOTAL
            // 
            this.btnTOTAL.Location = new System.Drawing.Point(31, 332);
            this.btnTOTAL.Name = "btnTOTAL";
            this.btnTOTAL.Size = new System.Drawing.Size(87, 44);
            this.btnTOTAL.TabIndex = 1;
            this.btnTOTAL.Text = "TOTAL";
            this.btnTOTAL.UseVisualStyleBackColor = true;
            this.btnTOTAL.Click += new System.EventHandler(this.btnTOTAL_Click);
            // 
            // lblTotalFacutrado
            // 
            this.lblTotalFacutrado.AutoSize = true;
            this.lblTotalFacutrado.Location = new System.Drawing.Point(352, 348);
            this.lblTotalFacutrado.Name = "lblTotalFacutrado";
            this.lblTotalFacutrado.Size = new System.Drawing.Size(35, 13);
            this.lblTotalFacutrado.TabIndex = 2;
            this.lblTotalFacutrado.Text = "label1";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(226, 345);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(78, 20);
            this.txtMes.TabIndex = 3;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblTotalFacutrado);
            this.Controls.Add(this.btnTOTAL);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnTOTAL;
        private System.Windows.Forms.Label lblTotalFacutrado;
        private System.Windows.Forms.TextBox txtMes;
    }
}