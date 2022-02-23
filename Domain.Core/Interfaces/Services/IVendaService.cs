using Domain.Entities;

namespace Domain.Core.Interfaces.Services
{
    public interface IVendaService : IServiceBase<Venda>
    {
        public void RealizarVenda(Venda venda);
    }
}
