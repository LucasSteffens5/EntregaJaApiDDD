using Domain.Core.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ProdutoNaVendaRepository : BaseRepository<ProdutoNaVenda>, IProdutoNaVendaRepository
    {
        public ProdutoNaVendaRepository(DataContext context) : base(context)
        {
        }
    }
}
