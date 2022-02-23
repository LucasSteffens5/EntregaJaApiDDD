using Application.DTO.DTO;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;

namespace Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperCriarProdutoNaVenda : IMapperCriarProdutoNaVenda
    {
        public CriarProdutoNaVendaDto MapperToDTO(ProdutoNaVenda produtoNaVenda)
        {
            CriarProdutoNaVendaDto produtoNaVendaDto = new CriarProdutoNaVendaDto
            {
                IdProduto = produtoNaVenda.Id,
                Quantidade = produtoNaVenda.Quantidade
            };

            return produtoNaVendaDto;
        }

        public ProdutoNaVenda MapperToEntity(CriarProdutoNaVendaDto criarProdutoNaVendaDto)
        {
            ProdutoNaVenda produtoNaVenda = new ProdutoNaVenda
            {
                Id = criarProdutoNaVendaDto.IdProduto,
                Quantidade = criarProdutoNaVendaDto.Quantidade
            };

            return produtoNaVenda;
        }
    }
}
