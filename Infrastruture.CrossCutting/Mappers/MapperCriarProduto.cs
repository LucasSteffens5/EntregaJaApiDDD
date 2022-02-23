using Application.DTO.DTO;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;

namespace Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperCriarProduto : IMapperCriarProduto
    {
        public CriarProdutoDto MapperToDTO(Produto produto)
        {
            CriarProdutoDto produtoDto = new CriarProdutoDto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco
            };

            return produtoDto;
        }

        public Produto MapperToEntity(CriarProdutoDto criarProdutoDto)
        {
            Produto produto = new Produto
            {
                Nome = criarProdutoDto.Nome,
                Descricao = criarProdutoDto.Descricao,
                Preco = criarProdutoDto.Preco
            };

            return produto;
        }
    }
}
