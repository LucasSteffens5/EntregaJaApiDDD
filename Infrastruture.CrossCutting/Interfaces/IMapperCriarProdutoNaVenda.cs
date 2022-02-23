using Application.DTO.DTO;
using Domain.Entities;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCriarProdutoNaVenda
    {

        ProdutoNaVenda MapperToEntity(CriarProdutoNaVendaDto criarProdutoNaVendaDto);

        CriarProdutoNaVendaDto MapperToDTO(ProdutoNaVenda produtoNaVenda);
    }
}
