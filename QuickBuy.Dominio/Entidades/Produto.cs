namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if(string.IsNullOrEmpty(Nome))
                AdicionarMensagemValidacao("Atenção - O campo Nome deve está preeenchido.");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarMensagemValidacao("Atenção - O campo Descricao deve está preenchido.");
            if (Preco == 0)
                AdicionarMensagemValidacao("Atenção - O campo Descricao deve está preechido.");
        }
    }

}
