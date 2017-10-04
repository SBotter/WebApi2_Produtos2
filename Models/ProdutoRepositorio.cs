using System;
using System.Collections.Generic;


namespace WebApi2_Produtos.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Guarana Antartica", Categoria = "Refrigerantes", Preco = 4.59M });
            Add(new Produto { Nome = "Suco de Laranja", Categoria = "Sucos", Preco = 5.75M });
            Add(new Produto { Nome = "Mostarda Hammer", Categoria = "Condimentos", Preco = 3.90M });
            Add(new Produto { Nome = "Molho de Tomate Cepera", Categoria = "Condimentos", Preco = 2.99M });
            Add(new Produto { Nome = "Suco de Uva Aurora", Categoria = "Sucos", Preco = 6.50M });
            Add(new Produto { Nome = "Pepsi", Categoria = "Refrigerantes", Preco = 4.25M });
        }
        
        public Produto Add(Produto item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int Id)
        {
            return produtos.Find(p => p.Id == Id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int Id)
        {
            produtos.RemoveAll(p => p.Id == Id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = produtos.FindIndex(p => p.Id == item.Id);

            if(index == -1)
            {
                return false;
            }

            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }

    }
}