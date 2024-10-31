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
                gbxIngreso.Visible = true;
                lblFecha.Visible = true;
                lblHora.Visible = true;
                lblMinutos.Visible = true;
                txtHora.Visible = true;
                txtMinutos.Visible = true;
                dtpFechaIngreso.Visible = true;

                cbxHoraSalida.Visible = true;
                cbxHoraSalida.Checked = false;
            }
            else
            {
                lblFecha.Visible = false;
                lblHora.Visible = false;
                lblMinutos.Visible = false;
                txtHora.Visible = false;
                txtHora.Text = "";
                txtMinutos.Visible = false;
                txtMinutos.Text = "";
                dtpFechaIngreso.Visible = false;
                dtpFechaIngreso.Value = DateTime.Now;

                cbxHoraSalida.Visible = false;
                cbxHoraSalida.Checked = false;
                gbxIngreso.Visible = false;
                grbxSalida.Visible = false;
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
            else if (txtDNIAlumno.Text.Length != 8)
            {
                MessageBox.Show("El DNI Debe tener 8 números");
                return;
            }

            try
            {
                AlumnoNegocio alumnoNegocio = new AlumnoNegocio();
                Alumno alumno = new Alumno();
                IngresoNegocio ingresoNegocio = new IngresoNegocio();

                alumno = alumnoNegocio.ObtenerAlumnoxDNI(txtDNIAlumno.Text);

                if (String.IsNullOrEmpty(alumno.DNI) || alumno.idAlumno == 0)
                {
                    MessageBox.Show("No hay alumno que coincida con ese DNI ");
                    return;
                }

                DateTime fecha = DateTime.Now;

                if (cbxFechaManual.Checked)
                {
                    if (txtHora.Text.Trim() == "" || soloNumeros(txtHora.Text) || txtHora.Text.Length > 2 || Convert.ToInt32(txtHora.Text) > 23 || Convert.ToInt32(txtHora.Text) < 0)
                    {
                        MessageBox.Show("Hora inválida");
                        return;
                    }
                    else if (txtMinutos.Text.Trim() == "" || soloNumeros(txtMinutos.Text) || txtMinutos.Text.Length > 2 || Convert.ToInt32(txtMinutos.Text) > 59 || Convert.ToInt32(txtMinutos.Text) < 0)
                    {
                        MessageBox.Show("Minutos inválidos");
                        return;
                    }

                    fecha = dtpFechaIngreso.Value;
                    int horas = int.Parse(txtHora.Text);
                    int minutos = int.Parse(txtMinutos.Text);

                    DateTime fechaParaBaseDatos = new DateTime(fecha.Year, fecha.Month, fecha.Day, horas, minutos, fecha.Second);
                    fecha = fechaParaBaseDatos;

                    if (fecha > DateTime.Now)
                    {
                        MessageBox.Show("La fecha debe ser menor a la actual");
                        return;
                    }

                    DateTime fechaSalida = DateTime.MinValue;

                    if (cbxHoraSalida.Checked)
                    {
                        if (txtHoraSalida.Text.Trim() == "" || soloNumeros(txtHoraSalida.Text) || txtHoraSalida.Text.Length > 2 || Convert.ToInt32(txtHoraSalida.Text) > 23 || Convert.ToInt32(txtHoraSalida.Text) < 0)
                        {
                            MessageBox.Show("Hora inválida");
                            return;
                        }
                        else if (txtMinutosSalida.Text.Trim() == "" || soloNumeros(txtMinutosSalida.Text) || txtMinutosSalida.Text.Length > 2 || Convert.ToInt32(txtMinutosSalida.Text) > 59 || Convert.ToInt32(txtMinutosSalida.Text) < 0)
                        {
                            MessageBox.Show("Minutos inválidos");
                            return;
                        }
                        else if (Convert.ToInt32(txtHoraSalida.Text) < Convert.ToInt32(txtHora.Text) ||
                            (Convert.ToInt32(txtHoraSalida.Text) == Convert.ToInt32(txtHora.Text) && Convert.ToInt32(txtMinutosSalida.Text) < Convert.ToInt32(txtHora.Text)))
                        {
                            MessageBox.Show("La fecha de salida debe ser mayor o igual a la fecha de entrada");
                            return;
                        }
                        else if (Convert.ToInt32(txtHoraSalida.Text) < Convert.ToInt32(txtHora.Text))
                        {
                            MessageBox.Show("La fecha de salida debe ser mayor o igual a la fecha de entrada");
                            return;
                        }

                        fechaSalida = new DateTime(fecha.Year, fecha.Month, fecha.Day, horas, minutos, fecha.Second);

                        if (fechaSalida > DateTime.Now)
                        {
                            MessageBox.Show("La fecha debe ser menor a la actual");
                            return;
                        }

                    }

                    ingresoNegocio.AgregarAsistencia(fecha, fechaSalida, alumno.idAlumno, 1);//falta pasarle idEmpleado
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error");
            }
        }

        private void frmAlta_Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void cbxHoraSalida_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxFechaManual.Checked)
            {
                lblHoraSalida.Visible = true;
                lblMinutosSalida.Visible = true;
                txtHoraSalida.Visible = true;
                txtMinutosSalida.Visible = true;
            }
            else
            {
                lblHoraSalida.Visible = false;
                lblMinutosSalida.Visible = false;
                txtHoraSalida.Visible = false;
                txtHoraSalida.Text = "";
                txtMinutosSalida.Visible = false;
                txtMinutosSalida.Text = "";

                grbxSalida.Visible = false;
            }
        }
    }
}
