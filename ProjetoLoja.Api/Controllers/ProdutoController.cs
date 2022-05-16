using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Application.Services.Interfaces;
using ProjetoLoja.Application.ViewModels;
using System.Threading.Tasks;

namespace ProjetoLoja.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;
        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarProdutos()
        {
            var produtos = await _produtoAppService.ListarProdutos();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarProduto([FromBody] NovoProdutoViewModel vm)
        {
            var result = await _produtoAppService.CadastrarProduto(vm);
            return Ok(result);
        }

        [HttpPut]

        public  async Task<IActionResult> AtualizarProduto([FromBody] AtualizarProdutoViewModel vm)
        {
            var result = await _produtoAppService.AtualizarProduto(vm);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> DeletarProduto(long id) 
        {
            var result = await _produtoAppService.DeletarProduto(id);
            if (result) return Ok();
            return NotFound();
        }

    }
}