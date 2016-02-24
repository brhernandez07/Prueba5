using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPrincipal
{

  
    public partial class frmCorreo : Form
    {
        public frmCorreo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ClsCorreo objCorreo = new ClsCorreo();
            objCorreo.asunto = txtAsunto.Text;
            objCorreo.destinatario = txtCorreo.Text;
            objCorreo.mensaje = txtMensaje.Text;
            objCorreo.usuario = txtCorreo.Text;
            objCorreo.enviarCorreo();


        }


    }
}
