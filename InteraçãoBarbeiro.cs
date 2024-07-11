namespace CSBarbearia
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque gerenciador = new Estoque();

            ExibirMenu(gerenciador);
        }

        static void ExibirMenu(Estoque gerenciador)
        {
            while (true) //Codigo responsavel pela interação com o usuario. Levando em conta as possibilidades de na interação do barbeiro (Casos) se aplica
            // tambem um tema importante aprendida na aula do professor, que e como excluir um item de do estoque. Se cria um vetor menor (1 posição) e as informações
            // do vetor anterior para o novo vetor excluindo o item digitado pelo barbeiro. 
            {
                Console.WriteLine("\n\n Controle de Estoque da CSBarbearia - A melhor da Iputinga, Te deixando sempre na régua!\n\n \n[1] Novo\n[2] Listar Produtos\n[3] Remover Produtos\n[4] Entrada Estoque\n[5] Saída Estoque\n[0] Sair");
                Console.Write("Escolha uma opção por favor: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a quantidade do produto: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço do novo produto: ");
                        double preco = double.Parse(Console.ReadLine());

                        Console.Write("Digite a marca do produto: ");
                        string marca = Console.ReadLine();

                        Console.Write("Digite o preço comprado do fornecedor(Leve o valor em consideração de for dar um desconto): ");
                        double precoFornecedor = double.Parse(Console.ReadLine());

                        Console.Write("É para adultos? (sim/nao): ");
                        string paraAdulto = Console.ReadLine();

                        gerenciador.AdicionarNovoProduto(nome, preco, quantidade, marca, precoFornecedor, paraAdulto);
                        break;
                    case 2:
                        gerenciador.Listar();//simplismente chamando a função Listar.
                        break;
                    case 3:
                        Console.Write("Digite o número do produto que deseja remover: ");
                        int numeroRemover = int.Parse(Console.ReadLine());
                        gerenciador.RemoverProduto(numeroRemover);
                        break;
                    case 4:
                        Console.Write("Digite o número do produto para entrada de estoque: ");
                        int numeroEntrada = int.Parse(Console.ReadLine());

                        Console.Write("Digite a quantidade para entrada de estoque: ");
                        int qtdEntrada = int.Parse(Console.ReadLine());

                        Console.Write("Produto adicionado com sucesso: ");

                        gerenciador.EntradaEstoque(numeroEntrada - 1, qtdEntrada);
                        break;
                    case 5:
                        Console.Write("Digite o número do produto para saída de estoque: ");
                        int numeroSaida = int.Parse(Console.ReadLine());

                        Console.Write("Digite a quantidade para saída de estoque: ");
                        int qtdSaida = int.Parse(Console.ReadLine());

                         Console.Write("\nQuantidade removida com sucesso! Parabéns pela venda Barbeiro!: ");

                        gerenciador.SaidaEstoque(numeroSaida - 1, qtdSaida);
                        break;
                    case 0:
                        Console.WriteLine("Saindo... Bons cortes para você!\n");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
