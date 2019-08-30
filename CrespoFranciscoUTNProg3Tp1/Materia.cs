using System;
using System.Collections.Generic;
using System.Text;

namespace CrespoFranciscoUTNProg3Tp1
{
    class Materia
    {
        public string nombre { get; set; }
        public List<string> correlativas { get; set; }

        public List<float> notas{ get; set; }
        public List<DateTime> fechaExamenes  { get; set; }
    }
}
