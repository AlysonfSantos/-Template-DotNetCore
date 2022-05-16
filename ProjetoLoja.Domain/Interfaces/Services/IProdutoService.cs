using ProjetoLoja.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ListarProdutos();
    }
}