using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace prjPrincipal
{
    class ClsCorreo
    {
        public String asunto;
        public String destinatario;
        private String remitente;
        public  String usuario;
        private String password;
        public String mensaje;
        private String servidorCorreo; //ojo
        private short puerto; // ojo
        public  string dominio;
        
        //adjunto;

        public ClsCorreo()
        {
            servidorCorreo = "smtp.gmail.com";
           //usuario = "pruebaclaseprogra@gmail.com";
            //password = "Programacion1234";
            //remitente = usuario;
            puerto = 587;
            dominio = "GMAIL";
            
        }

        private void definirServidor()
        {
            if (dominio.Equals("GMAIL"))
            {
                servidorCorreo = "smtp.gmail.com";
                usuario = "pruebaclaseprogra@gmail.com";
                password = "Programacion1234";
                remitente = usuario;
                puerto = 587;
            }
            else if (dominio.Equals("UMCA"))
            {
                servidorCorreo = "smtp.UMCA.com";
                usuario = "USUARIOUMCA@UMCA.com";
                password = "Programav";
                remitente = usuario;
                puerto = 689;
            }
        }

        public void enviarCorreo()
        {
            definirServidor();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(this.servidorCorreo);
            mail.From = new MailAddress(this.remitente);
            mail.To.Add(this.destinatario);
            mail.Subject = this.asunto;
            mail.Body = this.mensaje;

            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            //mail.Attachments.Add(attachment);

            SmtpServer.Port = this.puerto;
            SmtpServer.Credentials = new System.Net.NetworkCredential(this.usuario, this.password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
