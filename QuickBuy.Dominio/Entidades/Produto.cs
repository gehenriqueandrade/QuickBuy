﻿namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica - Nome do produto não foi informado.");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Crítica - Descrição do produto não informada.");
            }
            if (Preco.Equals(0))
            {
                AdicionarCritica("Crítica - Preço do produto não informado.");
            }
        }
    }
}
