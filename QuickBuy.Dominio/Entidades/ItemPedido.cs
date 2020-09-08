using System;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarMensagemValidacao("Atenção - O Campo ProdutoId deve está preenchido.");
            if (Quantidade == 0)
                AdicionarMensagemValidacao("Atenção - O Campo Quantidade deve está preenchido.");
        }
    }
}
