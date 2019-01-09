using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBancoDeDados
{
    public class ProdutoDAOEntity : IProdutoDAO
    {
        private LojaContext context;

        public ProdutoDAOEntity()
        {
            context = new LojaContext();
        }

        public void Adicionar(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
        }

        public IList<Produto> Produtos()
        {
            return context.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }
    }
}
