namespace Financeira
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cadastroPessoas = new CadastroPessoas();

            string opcao;
            do
            {
                Console.WriteLine("Cadastro de Contratos. Escolha a opção desejada ou digite S para sair:\n"+
                                  "1 Cadastro de Pessoa Física.\n"+
                                  "2 Cadastro de Pessoa Jurídica.");
                opcao = Console.ReadLine().ToUpper();
                if (opcao == "1")
                {
                    Console.Clear();
                    var contratante = cadastroPessoas.ObterContratante();
                    var cpf = cadastroPessoas.ObterCPF();
                    var dataNascimento = cadastroPessoas.ObterDataNascimento();
                    var valor = cadastroPessoas.ObterValor();
                    var prazo = cadastroPessoas.ObterPrazo();
                    var pessoa1 = new ContratoPessoaFisica(contratante, valor, prazo, cpf, dataNascimento);
                    pessoa1.ExibirInfo();
                    
                }
                else if (opcao == "2")
                {
                    Console.Clear();
                    var contratante = cadastroPessoas.ObterContratante();
                    var cnpj = cadastroPessoas.ObterCNPJ();
                    var inscricaoEstadual = cadastroPessoas.ObterInscricaoEstadual();
                    var valor = cadastroPessoas.ObterValor();
                    var prazo = cadastroPessoas.ObterPrazo();
                    var pessoa1 = new ContratoPessoaJuridica(contratante, valor, prazo, cnpj, inscricaoEstadual);
                    pessoa1.ExibirInfo();
                }
                else if (opcao == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            } while (opcao != "S");

            
        }
    }
}