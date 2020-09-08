using System;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<Tentity> : IDisposable where Tentity : class
    {
        void Adicionar(Tentity entity);
        Tentity ObterPorId(int id);
        Tentity OdterTodos();
        void Atualizar(Tentity entity);
        void Remover(Tentity entity);
    }
}
