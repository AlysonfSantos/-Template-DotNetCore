using System;

namespace ProjetoLoja.Domain.Models
{
    public class Produto
    {
        public Produto() { }

        public long Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataLancamento { get; private set; }

        public Produto(string nome, DateTime dataLancamento, decimal valor)
        {
            Nome = nome;
            DataLancamento = dataLancamento;
            Valor = valor;
        }

        public void AtualizarValor(decimal valor)
        {
            Valor = valor;
        }
    }
}