using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace winform_app
{
    public partial class frmFacturas : Form
    {
        private List<Facturas> facturasList;
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            FacturasNegocio negocio = new FacturasNegocio();
            facturasList = negocio.Listar();
            dgvFacturas.DataSource = facturasList;
            


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


        private void btnTOTAL_Click(object sender, EventArgs e)
        {

            FacturasNegocio neg = new FacturasNegocio();
            if (String.IsNullOrEmpty(txtMes.Text.Trim()))
            {
                MessageBox.Show("DEBE INGRESAR NUMERO DE MES");
                return;
            }
            if (!soloNumeros(txtMes.Text))
            {
                MessageBox.Show("SOLO INGRESAR NUMERO DE MES");
                return;
            }
            int mes = Convert.ToInt32(txtMes.Text);

            if(mes <= 0 || mes > 12)
            {
                MessageBox.Show("Número inválido");
                return;
            }

                
            lblTotalFacutrado.Text = "$" +  neg.MontoTotal(Convert.ToInt32(txtMes.Text)).ToString();


        }
    }
}
