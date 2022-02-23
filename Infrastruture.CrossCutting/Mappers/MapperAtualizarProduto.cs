using Application.DTO.DTO;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;

namespace Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperAtualizarProduto : IMapperAtualizarProduto
    {
        public AtualizarProdutoDto MapperToDTO(Produto produto)
        {
            AtualizarProdutoDto atualizarProdutoDto = new AtualizarProdutoDto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco
            };

            return atualizarProdutoDto;
        }

        public Produto MapperToEntity(AtualizarProdutoDto atualizarProdutoDto)
        {
            Produto produto = new Produto
            {
                Nome = atualizarProdutoDto.Nome,
                Descricao = atualizarProdutoDto.Descricao,
                Preco = atualizarProdutoDto.Preco
            };

            return produto;
        }
    }
}
