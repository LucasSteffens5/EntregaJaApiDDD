using Domain.Core.Interfaces.Repository;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Domain.Services.Services
{
    public class ProdutoNaVendaService :  ServiceBase<ProdutoNaVenda>, IProdutoNaVendaService
    {
        private readonly IProdutoNaVendaRepository _produtoNaVendaRepository;

        public ProdutoNaVendaService(IProdutoNaVendaRepository produtoNaVendaRepository) : base(produtoNaVendaRepository)
        {
            _produtoNaVendaRepository = produtoNaVendaRepository;
        }


        public void AdicionarProdutoNaVendaNaBaseDeDados(ProdutoNaVenda produtoNaVenda)
        {
            _produtoNaVendaRepository.AddAsync(produtoNaVenda);
        }


        public void PreecnherDadosBasicosDoProdutoNaVenda(ProdutoNaVenda produto, Produto item)
        {
            produto.Nome = item.Nome;
            produto.Preco = item.Preco;
        }

    }
}
