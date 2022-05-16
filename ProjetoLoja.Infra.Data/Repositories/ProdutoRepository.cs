using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Domain.Interfaces.Repositories;
using ProjetoLoja.Domain.Models;
using ProjetoLoja.Infra.Data.EF;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoLojaContext _context;
        public ProdutoRepository(ProdutoLojaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> ListarProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}