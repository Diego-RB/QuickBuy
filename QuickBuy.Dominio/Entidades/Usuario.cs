using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> MyProperty { get; set; } //Usuário pode ter nenhum ou muitos pedidos

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagemValidacao("Atenção - O Campo Nome deve está preenchido.");
            if (string.IsNullOrEmpty(Sobrenome))
                AdicionarMensagemValidacao("Atenção - O Campo Sobrenome deve está preenchido.");
            if (string.IsNullOrEmpty(Email))
                AdicionarMensagemValidacao("Atenção - O Campo Email deve está preenchido.");
            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagemValidacao("Atenção - O Campo Senha deve está preenchido.");
        }
    }
}
