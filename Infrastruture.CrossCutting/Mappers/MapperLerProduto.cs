using Application.DTO.DTO;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;

namespace Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperLerProduto : IMapperLerProduto
    {
        public LerProdutoDto MapperToDTO(Produto produto)
        {
            LerProdutoDto lerProdutoDto = new LerProdutoDto
            {
                IdProduto = produto.Id,
                Descricao = produto.Descricao,
                Nome = produto.Nome,
                Preco = produto.Preco
            };

            return lerProdutoDto;
        }

        public Produto MapperToEntity(LerProdutoDto lerProdutoDto)
        {
            Produto produto = new Produto
            {
                Id = lerProdutoDto.IdProduto,
                Preco = lerProdutoDto.Preco,
                Nome = lerProdutoDto.Nome,
                Descricao = lerProdutoDto.Descricao
            };

            return produto;
        }
    }
}
