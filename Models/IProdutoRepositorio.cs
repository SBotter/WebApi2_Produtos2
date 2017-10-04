using System.Collections.Generic;

namespace WebApi2_Produtos.Models
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> GetAll();
        Produto Get(int Id);
        Produto Add(Produto item);
        void Remove(int Id);
        bool Update(Produto item);


    }
}