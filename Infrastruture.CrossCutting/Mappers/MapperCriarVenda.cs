using Application.DTO.DTO;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;

namespace Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperCriarVenda : IMapperCriarVenda
    {
        public CriarVendaDto MapperToDTO(Venda venda)
        {
            CriarVendaDto criarVendaDto = new CriarVendaDto
            {
                Cep = venda.Cep,
                ProdutosDaVenda = venda.ProdutosDaVenda
            };

            return criarVendaDto;
        }

        public Venda MapperToEntity(CriarVendaDto criarVendaDto)
        {
            Venda venda = new Venda
            {
                ProdutosDaVenda = criarVendaDto.ProdutosDaVenda,
                Cep = criarVendaDto.Cep
            };

            return venda;
        }
    }
}
