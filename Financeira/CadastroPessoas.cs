using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class CadastroPessoas
    {
        public string ObterContratante()
        {
            string contratante;
            do
            {
                Console.WriteLine("Insira o nome do Contratante:");
                contratante = Console.ReadLine();
                if (!string.IsNullOrEmpty(contratante))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return contratante;
        }

        public decimal ObterValor()
        {
            decimal valor;
            do
            {
                Console.WriteLine("Insira o valor do contrato:");
                if (decimal.TryParse(Console.ReadLine(), out valor))
                {
                    if(valor > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("O valor deve ser um número maior que 0.");
            } while (true);
            return valor;
        }

        public int ObterPrazo()
        {
            int prazo;
            do
            {
                Console.WriteLine("Insira o prazo do contrato em meses:");
                if (int.TryParse(Console.ReadLine(), out prazo))
                {
                    if (prazo > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("O valor deve ser um número maior que 0.");
            } while (true);
            return prazo;
        }

        public DateTime ObterDataNascimento()
        {
            DateTime dataNascimento;
            do
            {
                Console.WriteLine("Insira a data de Nascimento do Contratante (DD/MM/AAAA):");
                if (DateTime.TryParse(Console.ReadLine(), out dataNascimento))
                {
                    break;
                }
                Console.WriteLine("Data inválida.");
            } while (true);
            return dataNascimento;
        }

        public string ObterCPF()
        {
            //validação somente se a string não é vazia. Não foi feita a validação dos números inseridos.
            string cpf;
            do
            {
                Console.WriteLine("Insira o CPF do Contratante:");
                cpf = Console.ReadLine();
                if (!string.IsNullOrEmpty(cpf))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return cpf;
        }

        public string ObterCNPJ()
        {
            //validação somente se a string não é vazia. Não foi feita a validação dos números inseridos.
            string cnpj;
            do
            {
                Console.WriteLine("Insira o CNPJ do Contratante:");
                cnpj = Console.ReadLine();
                if (!string.IsNullOrEmpty(cnpj))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return cnpj;
        }

        public string ObterInscricaoEstadual()
        {
            //validação somente se a string não é vazia. Não foi feita a validação dos números inseridos.
            
            string inscricaoEstadual;
            do
            {
                Console.WriteLine("Insira a Inscrição Estadual do Contratante:");
                inscricaoEstadual = Console.ReadLine();
                if (!string.IsNullOrEmpty(inscricaoEstadual))
                {
                    break;
                }
                Console.WriteLine("O valor não pode ser vazio.");
            } while (true);
            return inscricaoEstadual;
        }

    }
}
