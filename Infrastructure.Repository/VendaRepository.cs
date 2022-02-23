using Domain.Core.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class VendaRepository : BaseRepository<Venda>, IVendaRepository
    {
        public VendaRepository(DataContext context) : base(context)
        {

        }
    }
}
