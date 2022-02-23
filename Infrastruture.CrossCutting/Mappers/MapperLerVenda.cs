using Application.DTO.DTO;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;

namespace Infrastruture.CrossCutting.Adapter.Mappers
{
    public class MapperLerVenda : IMapperLerVenda
    {
        public LerVendaDto MapperToDTO(Venda venda)
        {
            LerVendaDto lerVendaDto = new LerVendaDto
            {
                Cep = venda.Cep,
                IdVenda = venda.Id,
                DataHoraVenda = venda.DataHoraVenda,
                DataHoraCancelamentoVenda = venda.DataHoraCancelamentoVenda,
                ProdutosDaVenda = venda.ProdutosDaVenda,
                ValorFrete = venda.ValorFrete,
                ValorTotalVenda = venda.ValorTotalVenda
            };

            return lerVendaDto;
        }

        public Venda MapperToEntity(LerVendaDto lerVendaDto)
        {
            Venda venda = new Venda
            {
                Cep = lerVendaDto.Cep,
                DataHoraCancelamentoVenda = lerVendaDto.DataHoraCancelamentoVenda,
                ProdutosDaVenda = lerVendaDto.ProdutosDaVenda,
                ValorFrete = lerVendaDto.ValorFrete,
                ValorTotalVenda = lerVendaDto.ValorTotalVenda,
                DataHoraVenda = lerVendaDto.DataHoraVenda,
                Id = lerVendaDto.IdVenda
            };

            return venda;
        }
    }
}
