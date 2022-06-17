using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public abstract class Contrato
    {
        public Contrato()
        {
            IdContrato = Guid.NewGuid();
        }

        public Guid IdContrato { get; protected set; }

        public string Contratante { get; protected set; }
        public decimal Valor { get; protected set; }
        public int Prazo { get; protected set; }

        public abstract decimal CalcularPrestação();

        public abstract void ExibirInfo();


    }
}
