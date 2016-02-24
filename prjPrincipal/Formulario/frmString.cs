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
    public partial class frmString : Form
    {
        public frmString()
        {
            InitializeComponent();
        }

        private void btnGenerarPlaca_Click(object sender, EventArgs e)
        {
            String nombre, primerApellido, segundoApellido, nombreCompleto;
            int posicion;
            nombreCompleto = txtNombreCompleto.Text;
            posicion = nombreCompleto.IndexOf(" ");
            nombre = nombreCompleto.Substring(0, posicion);
            nombreCompleto = nombreCompleto.Substring(posicion + 1);
            posicion = nombreCompleto.IndexOf(" ");
            primerApellido = nombreCompleto.Substring(0, posicion);

            nombreCompleto = nombreCompleto.Substring(posicion + 1);

            segundoApellido = nombreCompleto;

            String miPlaca = generarPlaca(Convert.ToInt64(txtCedula.Text), nombre, primerApellido, segundoApellido);

            txtPlaca.Text = miPlaca;
        }

        public String generarPlaca(long cedula, String nombre, String primerApellido, String segundoApellido )
        {
            String placa;
            String cedulaTexto = cedula.ToString();
            placa = nombre[0].ToString() + primerApellido[0].ToString() + segundoApellido[0].ToString() + "-" + cedulaTexto.Substring(0, 3);
            placa = placa.ToUpper();
            return placa;

        }
    }
}
