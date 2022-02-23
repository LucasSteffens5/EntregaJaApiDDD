using Application.DTO.DTO;
using Domain.Entities;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperAtualizarProduto
    {
        Produto MapperToEntity(AtualizarProdutoDto atualizarProdutoDto);

        AtualizarProdutoDto MapperToDTO(Produto produto);
    }
}
