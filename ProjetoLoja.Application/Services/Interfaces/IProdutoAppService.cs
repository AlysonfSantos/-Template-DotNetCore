﻿using ProjetoLoja.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Application.Services.Interfaces
{
    public interface IProdutoAppService
    {
        Task<IEnumerable<ProdutoViewModel>> ListarProdutos();
        Task<ProdutoViewModel> CadastrarProduto(NovoProdutoViewModel novoProdutoViewModel);
        Task<ProdutoViewModel> AtualizarProduto(AtualizarProdutoViewModel atualizarProdutoViewModel);
    }
}