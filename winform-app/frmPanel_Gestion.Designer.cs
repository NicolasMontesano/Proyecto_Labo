namespace winform_app
{
    partial class frmPanel_Gestion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRutinas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEjercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleados,
            this.tsmiClientes,
            this.tsmiDisciplinas,
            this.tsmiFacturas,
            this.tsmiRutinas,
            this.tsmiEjercicios,
            this.tsmiIngresos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEmpleados
            // 
            this.tsmiEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem,
            this.recepcionistasToolStripMenuItem});
            this.tsmiEmpleados.Name = "tsmiEmpleados";
            this.tsmiEmpleados.Size = new System.Drawing.Size(85, 21);
            this.tsmiEmpleados.Text = "Empleados";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // recepcionistasToolStripMenuItem
            // 
            this.recepcionistasToolStripMenuItem.Name = "recepcionistasToolStripMenuItem";
            this.recepcionistasToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.recepcionistasToolStripMenuItem.Text = "Recepcionistas";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(65, 21);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiDisciplinas
            // 
            this.tsmiDisciplinas.Name = "tsmiDisciplinas";
            this.tsmiDisciplinas.Size = new System.Drawing.Size(81, 21);
            this.tsmiDisciplinas.Text = "Disciplinas";
            // 
            // tsmiFacturas
            // 
            this.tsmiFacturas.Name = "tsmiFacturas";
            this.tsmiFacturas.Size = new System.Drawing.Size(68, 21);
            this.tsmiFacturas.Text = "Facturas";
            this.tsmiFacturas.Click += new System.EventHandler(this.vistasToolStripMenuItem_Click);
            // 
            // tsmiRutinas
            // 
            this.tsmiRutinas.Name = "tsmiRutinas";
            this.tsmiRutinas.Size = new System.Drawing.Size(62, 21);
            this.tsmiRutinas.Text = "Rutinas";
            // 
            // tsmiEjercicios
            // 
            this.tsmiEjercicios.Name = "tsmiEjercicios";
            this.tsmiEjercicios.Size = new System.Drawing.Size(74, 21);
            this.tsmiEjercicios.Text = "Ejercicios";
            // 
            // tsmiIngresos
            // 
            this.tsmiIngresos.Name = "tsmiIngresos";
            this.tsmiIngresos.Size = new System.Drawing.Size(70, 21);
            this.tsmiIngresos.Text = "Ingresos";
            this.tsmiIngresos.Click += new System.EventHandler(this.tsmiIngresos_Click);
            // 
            // frmPanel_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPanel_Gestion";
            this.Text = "frmPanel_Gestion";
            this.Load += new System.EventHandler(this.frmPanel_Gestion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleados;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem tsmiFacturas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRutinas;
        private System.Windows.Forms.ToolStripMenuItem tsmiEjercicios;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresos;
    }
}