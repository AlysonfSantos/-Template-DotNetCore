using AutoMapper;
using ProjetoLoja.Application.Services.Interfaces;
using ProjetoLoja.Application.ViewModels;
using ProjetoLoja.Domain.Interfaces.Services;
using ProjetoLoja.Domain.Models;
using ProjetoLoja.Domain.Models.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoLoja.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;
        public ProdutoAppService(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoViewModel>> ListarProdutos()
        {
            var produtos = await _produtoService.ListarProdutos();
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
        }

        public async Task<ProdutoViewModel> CadastrarProduto(NovoProdutoViewModel novoProdutoViewModel)
        {
            var novoProduto = new Produto(novoProdutoViewModel.Nome,
                novoProdutoViewModel.DataLancamento,
                novoProdutoViewModel.Valor);

            var produtoCadastrado = await _produtoService.CadastrarProduto(novoProduto);

            return _mapper.Map<ProdutoViewModel>(produtoCadastrado);
        }


    }
}