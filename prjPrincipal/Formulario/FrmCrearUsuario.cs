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
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            long cedula;
            string nombre,  apellido,  password ;
            
            cedula =  Convert.ToInt64(txtCedula.Text);
            nombre  = txtNombre.Text;
            apellido =  txtApellido.Text;
            password = txtPassword.Text;

            generarCodigoUsuario(cedula, nombre,apellido);
            

        }

        public void generarCodigoUsuario(long cedula, string nombre, string apellido )
        { 
            ClsUsuario objUsuario =  new ClsUsuario();
            ClsCorreo objCorreo = new ClsCorreo();
            objUsuario.cedula = cedula;
            objUsuario.nombre = nombre;
            objUsuario.primerApellido = apellido;
            string codigoUsuario = objUsuario.generarCodigo();
            
            txtCodigoUsuario.Text = codigoUsuario;
            
            //envio correo
            objCorreo.asunto = "Generacion Usuario";
            objCorreo.destinatario = "melag77@gmail.com";
            objCorreo.mensaje = "Hola estimado " + objUsuario.nombre + " su codigo de usuario es " + codigoUsuario;
            //objCorreo.correo = (byte)ClsCorreo.servidores.gmail;
            objCorreo.enviarCorreo();
        }

        private void btnValidarPassword_Click(object sender, EventArgs e)
        {
            string codigoUsuario, password;
            codigoUsuario = txtCodigoUsuario.Text;
            password = txtPassword.Text;
            validarPassword(password, codigoUsuario);
        }

        private void validarPassword(string password, string codigoUsuario)
        {
            ClsUsuario objUsuario = new ClsUsuario();
            objUsuario.password = password;

            if (objUsuario.validarPassword(codigoUsuario) == true)
                MessageBox.Show("El password es valido");
            else
                MessageBox.Show("El password NO es valido");
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            long cedula;
            string nombre, apellido, password;
            cedula = Convert.ToInt64(txtCedula.Text);
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            password = txtPassword.Text;

            //generarCodigoUsuario(cedula, nombre, apellido);
            crearUsuario(cedula, nombre, apellido, password);
             
            
        }

        public void crearUsuario(long cedula, string nombre, string apellido, string password)
        {
            ClsUsuario objUsuario = new ClsUsuario();
            objUsuario.cedula = cedula;
            objUsuario.nombre = nombre;
            objUsuario.primerApellido = apellido;
            objUsuario.password = password;
            string resultado = objUsuario.crearUsuario();
            if (resultado.Equals("ERROR"))
                MessageBox.Show("Usuario NO creado en base datos");
            else
            {
                MessageBox.Show("Usuario  creado en base datos");
                txtCodigoUsuario.Text = resultado;
            }
        }
    }
}

