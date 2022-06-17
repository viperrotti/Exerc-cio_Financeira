using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class ContratoPessoaFisica : Contrato
    {
            
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public ContratoPessoaFisica(string contratante, decimal valor, int prazo, string cPF, DateTime dataNascimento)
        {
            base.Contratante = contratante;
            base.Valor = valor;
            base.Prazo = prazo;
            CPF = cPF;
            DataNascimento = dataNascimento;
        }
        
        public int Idade
        {
            get
            {
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - DataNascimento.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (DataNascimento.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public override decimal CalcularPrestação()
        {
            decimal adicional;
            if (Idade <= 30)
            {
                adicional = 1;
            }
            else if (Idade <= 40)
            {
                adicional = 2;
            }
            else if (Idade <= 50)
            {
                adicional = 3;
            }
            else
            {
                adicional = 4;
            }
            return Math.Round(Valor / Prazo + adicional, 2);
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"O valor do contrato é R$ {Valor:f2}.\n" +
                              $"O prazo é {Prazo} meses.\n" + 
                              $"O valor da prestação é R$ {CalcularPrestação():f2}.\n" +
                              $"A idade do contratante é {Idade} anos.\n");
        }

    }
}
