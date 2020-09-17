using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<Tentity> : IDisposable where Tentity : class
    {
        void Adicionar(Tentity entity);
        Tentity ObterPorId(int id);
        IEnumerable<Tentity> OdterTodos();
        void Atualizar(Tentity entity);
        void Remover(Tentity entity);
    }
}
