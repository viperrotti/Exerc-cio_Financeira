namespace Financeira
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cadastroPessoas = new CadastroPessoas();

            Console.WriteLine("Cadastro de Contratos. Digite 1 para pessoa Física ou 2 para pessoa Jurídica:");
            string opcao = Console.ReadLine();
            if (opcao == "1")
            {
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
                var contratante = cadastroPessoas.ObterContratante();
                var cnpj = cadastroPessoas.ObterCNPJ();
                var inscricaoEstadual = cadastroPessoas.ObterInscricaoEstadual();
                var valor = cadastroPessoas.ObterValor();
                var prazo = cadastroPessoas.ObterPrazo();
                var pessoa1 = new ContratoPessoaJuridica(contratante, valor, prazo, cnpj, inscricaoEstadual);
                pessoa1.ExibirInfo();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }






        }
    }
}