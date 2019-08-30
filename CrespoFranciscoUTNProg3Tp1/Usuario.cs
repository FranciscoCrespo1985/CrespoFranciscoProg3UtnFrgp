using System;
using System.Collections.Generic;
using System.Text;

namespace CrespoFranciscoUTNProg3Tp1
{
    class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni{ get; set; }
        public Telefono telefono { get; set; }
        public Direccion direccion { get; set; }

        public string permisos { get; set; }

    }
}
