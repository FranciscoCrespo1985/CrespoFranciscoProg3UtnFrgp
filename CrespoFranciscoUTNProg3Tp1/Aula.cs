using System;
using System.Collections.Generic;
using System.Text;

namespace CrespoFranciscoUTNProg3Tp1
{
    class Aula
    {
        public int Numero { get; set; }
        public Dictionary<int, bool> horarioDisponible;
        public int Curso { get; set; }
        
        public int cupo { get; set; }
    }
}
