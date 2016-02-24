using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPrincipal
{
    public partial class frmCalcularSalario : Form
    {
        public frmCalcularSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float porcentajeCargas = (float.Parse(txtPorcentajeCargasProyectado.Text)) / 100;
            byte cantidaHoras = Convert.ToByte(txtCantidadHoras.Text);
            float precioHora = float.Parse(txtPrecioHora.Text);
            double miResultado = fCalcularSalarioNeto(cantidaHoras, precioHora, porcentajeCargas);
            txtSalarioNeto.Text = miResultado.ToString();


        }

        private void btnCalcularDos_Click(object sender, EventArgs e)
        {
            float porcentajeCargas = (float.Parse(txtPorcentajeCargasProyectado.Text)) / 100;
            byte cantidaHoras = Convert.ToByte(txtCantidadHoras.Text);
            float precioHora = float.Parse(txtPrecioHora.Text);
            double miResultado = fCalcularSalarioNeto(cantidaHoras, precioHora, porcentajeCargas);
            txtSalarioNeto.Text = miResultado.ToString();
        }

        public void calcularSalarioNeto()
        {
            
        }

        public double fCalcularSalarioNeto(byte cantidaHoras, float precioHora, float porcentajeCargas)
        {
            float  montoCargas;
            float salarioBruto, salarioNeto;
            salarioBruto = precioHora * cantidaHoras;
            montoCargas = salarioBruto * porcentajeCargas;
            salarioNeto = salarioBruto - montoCargas ;
            return salarioNeto;
        }

        //REFERENCIA
        public void calcularSalarioNetoMSGBOX()
        {
            byte cantidaHoras;
            float precioHora;
            float porcentajeCargas, montoCargas;
            float salarioBruto, salarioNeto;

            cantidaHoras = Convert.ToByte(txtCantidadHoras.Text);
            precioHora = float.Parse(txtPrecioHora.Text);
            porcentajeCargas = (float.Parse(txtPorcentajeCargas.Text)) / 100;

            salarioBruto = precioHora * cantidaHoras;
            montoCargas = salarioBruto * porcentajeCargas;
            salarioNeto = salarioBruto - montoCargas;

            MessageBox.Show("El salario neto es " + salarioNeto);
            
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            float porcentajeCargas = (float.Parse(txtPorcentajeCargasProyectado.Text)) / 100;
            byte cantidaHoras = Convert.ToByte(txtCantidadHoras.Text);
            float precioHora = float.Parse(txtPrecioHora.Text);
            double miResultado = fCalcularSalarioNeto(cantidaHoras, precioHora, porcentajeCargas);
            MessageBox.Show("El salario neto es " + miResultado);
        }

        private void txtCantidadHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 48) && (e.KeyChar <= 57)))
                e.Handled = true;
        }

    }
}
