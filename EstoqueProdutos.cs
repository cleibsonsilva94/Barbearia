using System;

namespace CSBarbearia
{
    class Estoque
    {
        Produto[] Produtos;

        public Estoque()
        {
            Produtos = new Produto[0];
        }

        // Adiciona um novo produto ao estoque, e claro para isso a criaçao do vetor
        public void Adicionar(Produto novoProduto)
        {
            Produto[] novoVetor = new Produto[Produtos.Length + 1];

            for (int pos = 0; pos < Produtos.Length; pos++)
            {
                novoVetor[pos] = Produtos[pos];
            }

            novoVetor[novoVetor.Length - 1] = novoProduto;

            Produtos = novoVetor;
        }

        // Mostrando ao barbeiro a Lista os produtos do estoque
        public void Listar()
        {
            Console.WriteLine("\n\n=== Lista de produtos da CSBarbearia - A melhor da Iputinga, Te deixando sempre na régua! ===\n");

            if (Produtos.Length == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                for (int pos = 0; pos < Produtos.Length; pos++)
                {
                    Produto item = Produtos[pos];
                    Console.WriteLine($"{pos + 1}. {item.Nome} - R$ {item.Preco} - Estoque: {item.Estoque} - Marca: {item.Marca} - Preço Fornecedor: R$ {item.PrecoFornecedor} - {(item.Adulto ? "Adulto" : "Infantil")}");
                }
            }
        }

        // Remove um produto do estoque
        public void Remover(int posRemover)
        {
            Produto[] novoVetor = new Produto[Produtos.Length - 1];

            for (int pos = 0, novaPos = 0; pos < Produtos.Length; pos++)
            {
                if (pos != posRemover)
                {
                    novoVetor[novaPos++] = Produtos[pos];
                }
            }

            Produtos = novoVetor;
        }

        // Exclui permanentemente um produto do estoque
        public void Excluir(int posExcluir)
        {
            Produto[] novoVetor = new Produto[Produtos.Length - 1];

            for (int pos = 0, novaPos = 0; pos < Produtos.Length; pos++)
            {
                if (pos != posExcluir)
                {
                    novoVetor[novaPos++] = Produtos[pos];
                }
            }

            Produtos = novoVetor;
        }

        // Adiciona um novo produto ao estoque com base nos daod fornecidos pelo barbeiro
        public void AdicionarNovoProduto(string nome, double preco, int quantidade, string marca, double precoFornecedor, string paraAdulto)
        {
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Preco = preco,
                Estoque = quantidade,
                Marca = marca,
                PrecoFornecedor = precoFornecedor,
                Adulto = (paraAdulto.ToLower() == "sim" || paraAdulto.ToLower() == "s")
            };

            Adicionar(novoProduto);

            Console.WriteLine("Novo produto adicionado com sucesso!");
        }

        // Remove um produto do estoque com base no número digitado pelo barbeiro 
        public void RemoverProduto(int numeroProduto)
        {
            if (numeroProduto >= 1 && numeroProduto <= Produtos.Length)
            {
                Remover(numeroProduto - 1);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Número de produto inválido.");
            }
        }

        // Exclui permanentemente um produto do estoque com base no número que o barbeiro digitou
        public void ExcluirProduto(int numeroProduto)
        {
            if (numeroProduto >= 1 && numeroProduto <= Produtos.Length)
            {
                Excluir(numeroProduto - 1);
                Console.WriteLine("Produto excluído permanentemente com sucesso!");
            }
            else
            {
                Console.WriteLine("Número de produto inválido.");
            }
        }

        // Aumenta a quantidade em estoque de um produto com base na posição e quantidade fornecidas
        public void EntradaEstoque(int posicao, int qtd)
        {
            if (posicao >= 0 && posicao < Produtos.Length)
            {
                Produtos[posicao].Estoque += qtd;
            }
            else
            {
                Console.WriteLine("Número de produto inválido.");
            }
        }

        // Diminui a quantidade em estoque de um produto com base na posição e quantidade fornecidas
        public void SaidaEstoque(int posicao, int qtd)
        {
            if (posicao >= 0 && posicao < Produtos.Length)
            {
                if (Produtos[posicao].Estoque >= qtd)
                {
                    Produtos[posicao].Estoque -= qtd;
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Número de produto inválido.");
            }
        }
    }
}