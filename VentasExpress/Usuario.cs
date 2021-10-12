using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasExpress
{
    class Usuario
    {
        protected string usuario1;

        public string Usuario1
        {
            get { return usuario1; }
            set { usuario1 = value; }
        }

        protected string contraseña1;

        public string Contraseña1
        {
            get { return contraseña1; }
            set { contraseña1 = value; }
        }
    }
}
