using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmAlta_Ingreso : Form
    {
        public frmAlta_Ingreso()
        {
            InitializeComponent();
        }

        private void cbxFechaManual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFechaManual.Checked)
            {
                lblFecha.Visible = true;
                lblHora.Visible = true;
                lblMinutos.Visible = true;
                txtHora.Visible = true;
                txtMinutos.Visible = true;
                dtpFechaIngreso.Visible = true;
            }
            else
            {
                lblFecha.Visible = false;
                lblHora.Visible = false;
                lblMinutos.Visible = false;
                txtHora.Visible = false;
                txtHora.Text= "";
                txtMinutos.Visible = false;
                txtMinutos.Text = "";
                dtpFechaIngreso.Visible = false;
                dtpFechaIngreso.Value = DateTime.Now;
            }
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {

            if (soloNumeros(txtDNIAlumno.Text))
            {
                MessageBox.Show("Solo Números");
                return;
            }
            else if(txtDNIAlumno.Text.Length != 8)
            {
                MessageBox.Show("El DNI Debe tener 8 números");
                return;
            }

            try
            {
                AlumnoNegocio alumnoNegocio = new AlumnoNegocio();
                Alumno alumno = new Alumno();

                alumno = alumnoNegocio.ObtenerAlumnoxDNI(txtDNIAlumno.Text);

                if(String.IsNullOrEmpty(alumno.DNI) || alumno.idAlumno == 0)
                {
                    MessageBox.Show("No hay alumno que coincida con ese DNI ");
                    return;
                }

                DateTime fecha = DateTime.Now;

                if (cbxFechaManual.Checked)
                {
                    if (txtHora.Text.Trim() == "" || soloNumeros(txtHora.Text) || txtHora.Text.Length > 2)
                    {
                        MessageBox.Show("Hora inválida");
                        return;
                    }
                    else if (txtMinutos.Text.Trim() == "" || soloNumeros(txtMinutos.Text) || txtMinutos.Text.Length > 2)
                    {
                        MessageBox.Show("Minutos inválidos");
                        return;
                    }
                    
                    fecha = dtpFechaIngreso.Value;
                    int horas = int.Parse(txtHora.Text);
                    int minutos = int.Parse(txtMinutos.Text);


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error");
            }
        }
    }
}
