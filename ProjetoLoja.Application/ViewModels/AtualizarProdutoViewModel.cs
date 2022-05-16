using System;

namespace ProjetoLoja.Application.ViewModels
{
    public  class AtualizarProdutoViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
