using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Application.Services.Interfaces;
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
        public async Task<IActionResult> CadastrarProduto()
        {
            return Ok();
        }
    }
}