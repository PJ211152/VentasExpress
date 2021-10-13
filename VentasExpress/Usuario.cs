using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    class Usuario
    {
        protected string usuario1="admin";

        public string Usuario1
        {
            get { return usuario1; }
            set { usuario1 = value; }
        }

        protected string contraseña1= "admin123";

        public string Contraseña1
        {
            get { return contraseña1; }
            set { contraseña1 = value; }
        }

        protected string usuario2= "vendedor";

        public string Usuario2
        {
            get { return usuario2; }
            set { usuario2 = value; }
        }

        protected string contraseña2= "Vendedor123";

        public string Contraseña2
        {
            get { return contraseña2; }
            set { contraseña2 = value; }
        }

        protected string usuario3= "Invitado";

        public string Usuario3
        {
            get { return usuario3; }
            set { usuario1 = value; }
        }

        protected string contraseña3= "invitadoinvitado123";

        public string Contraseña3
        {
            get { return contraseña3; }
            set { contraseña3 = value; }
        }

        protected string usuarioactual;

        public string Usuarioactual
        {
            get { return usuarioactual; }
            set { usuarioactual = value; }
        }
    }
}
