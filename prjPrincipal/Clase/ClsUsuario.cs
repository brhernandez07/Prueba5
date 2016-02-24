using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrincipal
{
    class ClsUsuario
    {
        //atributos
        //modificador acceso + tipo dato + nombre SIGNIFICATIVO
        public long cedula;
        public String nombre;
        public String primerApellido;
        public String password;
        private String codigoUsuario;

        // constructor

        //procedimientos / funciones

        public string crearUsuario()
        {
            bool usuarioCreado = true;

            generarCodigo();
            if (validarPassword(codigoUsuario))
                return codigoUsuario;
            else
                return "ERROR";
            
        
        }
        public String generarCodigo()
        { 
            string cedulaTexto =  cedula.ToString();
            if (validarInformacion())
            {
                codigoUsuario = nombre[0] + primerApellido + cedulaTexto.Substring(cedulaTexto.Length - 3);
                codigoUsuario = codigoUsuario.ToLower();
            }
            else
                codigoUsuario = "Informacion Invalida";
            return codigoUsuario;
        }

        private bool validarInformacion()
        {
            string cedulaTexto = cedula.ToString();
            bool esValido = true;
            if ((primerApellido.Length > 15) || (cedulaTexto.Length < 5))
                esValido = false;
            else if (fContieneNumero(nombre,0))
                esValido = false;
            return esValido;
        
        }

        public bool validarPassword(string codigoUsuario)
        {
            bool esValido = true;
            if (codigoUsuario.Equals(password))
                esValido = false;
            else if ((password.Length > 20) || (password.Length < 10))
                esValido = false;
            else if ((password[0] >= 48) && (password[0] <= 57))
            {
                esValido = false;
            }
            else
            {
                if (!fContieneNumero(password,1))
                    esValido = false;
            }
         return esValido;
        }

        public bool fContieneNumero(string texto, int inicio)
        {
            bool contieneNumero = false;
            for (int i = inicio; i < texto.Length; i++)
            {
                if (Char.IsNumber(texto[i]))
                {
                    contieneNumero = true;
                    break;
                }
            }
            return contieneNumero;
        }
        
    }
}
