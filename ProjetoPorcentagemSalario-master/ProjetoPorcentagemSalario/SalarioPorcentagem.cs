using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPorcentagemSalario
{
    internal class SalarioPorcentagem
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        public int ValorDaDiaria { get; set; }

        public int DiasTrabalhados { get; set; }

        public double valorIR { get; private set; }

        public double SalarioBase { get; private set; }

        public double SalarioLiquido { get; private set; }  
        public void CalcularSalario()
        {

            SalarioBase = DiasTrabalhados * ValorDaDiaria;

            

            if (SalarioBase <= 1903.98)
            {
                valorIR = 0;
            }

            else if (SalarioBase > 1903.98 && SalarioBase <= 2826.65)
            {
                valorIR = (0.075 * SalarioBase);
            }


            else if (SalarioBase > 2826.66 && SalarioBase <= 3751.05)
            {
                valorIR = (0.15 * SalarioBase); 
            }

            else if (SalarioBase > 3751.06 && SalarioBase <= 4664.68)
            {
                valorIR = (0.225 * SalarioBase);
            }

            else
            {
                valorIR = (0.227 * SalarioBase);
            }

            SalarioLiquido = (SalarioBase - valorIR);
            //Até R$1.903,98*                 0,00%     



            //De R$1.903,99 até R$2.826,65    7,50%


            //De R$2.826,66 até R$3.751,05    15%


            //De R$3.751,06 até R$4.664,68    22,50%


        }

    }
}
