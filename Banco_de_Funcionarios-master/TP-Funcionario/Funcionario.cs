using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Funcionario
{
    internal class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        public int ValorHora { get; set; }

        public int HorasTrabalhadas { get; set; }

        public double Salario { get; private set; }

        public void CalcularSalario()
        {
            Salario = ValorHora * HorasTrabalhadas;
        }

    }
}
