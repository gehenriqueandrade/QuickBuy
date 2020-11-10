namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        /* Validação */

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (ProdutoId.Equals(0))
            {
                AdicionarCritica("Crítica - Não foi identificado qual a referência do produto.");
            }
            if (Quantidade.Equals(0))
            {
                AdicionarCritica("Crítica - Quantidade não foi informada.");
            }
        }
    }
}
