﻿namespace winform_app
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
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEmpleados
            // 
            this.tsmiEmpleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.tsmiEmpleados.Name = "tsmiEmpleados";
            this.tsmiEmpleados.Size = new System.Drawing.Size(77, 20);
            this.tsmiEmpleados.Text = "Empleados";
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.profesoresToolStripMenuItem.Text = "Agregar";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiDisciplinas
            // 
            this.tsmiDisciplinas.Name = "tsmiDisciplinas";
            this.tsmiDisciplinas.Size = new System.Drawing.Size(75, 20);
            this.tsmiDisciplinas.Text = "Disciplinas";
            // 
            // tsmiFacturas
            // 
            this.tsmiFacturas.Name = "tsmiFacturas";
            this.tsmiFacturas.Size = new System.Drawing.Size(63, 20);
            this.tsmiFacturas.Text = "Facturas";
            this.tsmiFacturas.Click += new System.EventHandler(this.vistasToolStripMenuItem_Click);
            // 
            // tsmiRutinas
            // 
            this.tsmiRutinas.Name = "tsmiRutinas";
            this.tsmiRutinas.Size = new System.Drawing.Size(58, 20);
            this.tsmiRutinas.Text = "Rutinas";
            // 
            // tsmiEjercicios
            // 
            this.tsmiEjercicios.Name = "tsmiEjercicios";
            this.tsmiEjercicios.Size = new System.Drawing.Size(68, 20);
            this.tsmiEjercicios.Text = "Ejercicios";
            // 
            // tsmiIngresos
            // 
            this.tsmiIngresos.Name = "tsmiIngresos";
            this.tsmiIngresos.Size = new System.Drawing.Size(63, 20);
            this.tsmiIngresos.Text = "Ingresos";
            this.tsmiIngresos.Click += new System.EventHandler(this.tsmiIngresos_Click);
            // 
            // frmPanel_Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(770, 369);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(786, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(786, 408);
            this.Name = "frmPanel_Gestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem tsmiFacturas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRutinas;
        private System.Windows.Forms.ToolStripMenuItem tsmiEjercicios;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresos;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}