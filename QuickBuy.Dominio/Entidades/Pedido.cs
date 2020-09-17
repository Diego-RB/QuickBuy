using QuickBuy.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; } //Produto deve tem ao menos um item pedido ou muitos itens pedidos

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItemPedido.Any())
                AdicionarMensagemValidacao("Atenção - Pedido não pode ficar sem item de pedido");
            

            if (string.IsNullOrEmpty(CEP))          
                AdicionarMensagemValidacao("Atenção - O Campo CEP deve está preenchido.");
            
        }
    }
}
