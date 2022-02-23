using Application.DTO.DTO;
using Domain.Entities;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperLerProduto
    {
        Produto MapperToEntity(LerProdutoDto lerProdutoDto);

        LerProdutoDto MapperToDTO(Produto produto);
    }
}
