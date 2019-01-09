using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            //GravarUsandoEntity("Livro do Steve Jobs", "Biografias", 200.87m);
            //RecuperarProdutos();
            ExcluirProdutos();
            //RecuperarProdutos();
            //AtualizarProduto();
            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            ProdutoDAOEntity produtoDAOEntity = new ProdutoDAOEntity();

            IList<Produto> produtos = produtoDAOEntity.Produtos();
            foreach (var produto in produtos)
            {
                produto.Nome += " - Atualizado 2019";
                produtoDAOEntity.Atualizar(produto);
            }

            RecuperarProdutos();
        }

        private static void ExcluirProdutos()
        {
            ProdutoDAOEntity produtoDAOEntity = new ProdutoDAOEntity();
            IList<Produto> produtos = produtoDAOEntity.Produtos();

            foreach (var produto in produtos)
            {
                produtoDAOEntity.Remover(produto);
                Console.WriteLine($"Produto {produto.Nome} excluido com sucesso!");
            }

            RecuperarProdutos();
        }

        private static void RecuperarProdutos()
        {
            ProdutoDAOEntity produtoDAOEntity = new ProdutoDAOEntity();
            IList<Produto> produtos = produtoDAOEntity.Produtos();

            Console.WriteLine(" -- Listando Produtos --");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}");
                Console.WriteLine($"Categoria: {produto.Categoria}");
                Console.WriteLine($"Preço: {produto.Preco}");
            }
        }

        private static void GravarUsandoEntity(string nome, string categoria, decimal preco)
        {
            Produto produto = new Produto();
            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Preco = preco;

            ProdutoDAOEntity produtoDAOEntity = new ProdutoDAOEntity();
            produtoDAOEntity.Adicionar(produto);
        }
    }
}
