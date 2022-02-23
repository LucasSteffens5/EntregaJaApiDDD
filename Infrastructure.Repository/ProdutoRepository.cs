using Domain.Core.Interfaces.Repository;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DataContext context) : base(context)
        {
        }
    }
}
