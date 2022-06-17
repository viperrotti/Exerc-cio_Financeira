using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class ContratoPessoaJuridica : Contrato
    {
        public string CNPJ { get; set; } 
        public string IncricaoEstadual { get; set; }

        public ContratoPessoaJuridica(string contratante, decimal valor, int prazo, string cNPJ, string inscricaoEstadual)
        {
            base.Contratante = contratante;
            base.Valor = valor;
            base.Prazo = prazo;
            CNPJ = cNPJ;
            IncricaoEstadual = inscricaoEstadual;
        }

        public override decimal CalcularPrestação()
        {
            return Math.Round(Valor / Prazo + 3M, 2);
        }
        public override void ExibirInfo()
        {
            Console.WriteLine($"O valor do contrato é R$ {Valor:f2}.\n" +
                              $"O prazo é {Prazo} meses.\n" + 
                              $"O valor da prestação é R$ {CalcularPrestação():f2}.\n\n");
        }

    }
}
