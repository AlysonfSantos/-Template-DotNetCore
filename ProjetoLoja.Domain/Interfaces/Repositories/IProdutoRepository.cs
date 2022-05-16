using ProjetoLoja.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Task<IEnumerable<Produto>> ListarProdutos();
        Task CadastrarProduto(Produto produto);
        Task AtualizarProduto(Produto produto);
        Task DeletarProduto(Produto produto);
    }
}