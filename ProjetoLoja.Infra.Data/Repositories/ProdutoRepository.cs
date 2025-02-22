﻿using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Domain.Interfaces.Repositories;
using ProjetoLoja.Domain.Models;
using ProjetoLoja.Infra.Data.EF;
using ProjetoLoja.Infra.Data.Repositories.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly ProdutoLojaContext _context;
        public ProdutoRepository(ProdutoLojaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> ListarProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task CadastrarProduto(Produto produto)
        {
            await _context.AddAsync(produto);
        }

        public async Task AtualizarProduto(Produto produto) 
        {
            await Task.FromResult(_context.Update(produto));
        }

        public async Task DeletarProduto(Produto produto) 
        {
            await Task.FromResult(_context.Remove(produto));
        }
    
    }
}