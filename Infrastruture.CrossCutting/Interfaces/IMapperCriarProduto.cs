using Application.DTO.DTO;
using Domain.Entities;
using System.Collections.Generic;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCriarProduto
    {

        Produto MapperToEntity(CriarProdutoDto criarProdutoDto);

        CriarProdutoDto MapperToDTO(Produto produto);

       
    }
}
