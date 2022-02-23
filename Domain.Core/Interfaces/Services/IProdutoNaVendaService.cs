using Domain.Entities;

namespace Domain.Core.Interfaces.Services
{
    public interface IProdutoNaVendaService : IServiceBase<ProdutoNaVenda>
    {
        public void PreecnherDadosBasicosDoProdutoNaVenda(ProdutoNaVenda produto, Produto item);

        public void AdicionarProdutoNaVendaNaBaseDeDados(ProdutoNaVenda produtoNaVenda);

    }
}
