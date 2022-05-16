using ProjetoLoja.Domain.Interfaces.Repositories;
using ProjetoLoja.Domain.Interfaces.Services;
using ProjetoLoja.Domain.Models;
using ProjetoLoja.Domain.Models.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Produto>> ListarProdutos()
        {
            return await _produtoRepository.ListarProdutos();
        }

        public async Task<Produto> CadastrarProduto(Produto produto)
        {
            await _produtoRepository.CadastrarProduto(produto);
            await _produtoRepository.UnitOfWork.SaveChangesAsync();

            return produto;
        }
    }
}