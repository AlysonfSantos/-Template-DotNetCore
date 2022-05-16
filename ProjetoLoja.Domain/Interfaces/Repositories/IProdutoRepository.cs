using ProjetoLoja.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ListarProdutos();
    }
}