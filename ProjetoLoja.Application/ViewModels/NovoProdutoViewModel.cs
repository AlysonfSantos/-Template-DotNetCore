﻿using System;

namespace ProjetoLoja.Application.ViewModels
{
    public class NovoProdutoViewModel
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}