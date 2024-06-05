using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoClasses
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public string Ra { get; set; } = string.Empty;

        public double P1 { get; set; }

        public double P2 { get; set; }

        public double Media { get; private set; }

        public void CalcularMedia()
        {

            Media = (P1 + P2) / 2;
        }

    }
}
