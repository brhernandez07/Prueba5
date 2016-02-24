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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void calcularSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmCalcularSalario fCalcularSalario = new frmCalcularSalario();
            fCalcularSalario.Show();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmString fFormularioString = new frmString();
            fFormularioString.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.Show();
        }

        private void enviarCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCorreo().Show();
        }
    }
}
