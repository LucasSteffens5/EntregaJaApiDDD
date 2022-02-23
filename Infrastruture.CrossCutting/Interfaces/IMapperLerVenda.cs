using Application.DTO.DTO;
using Domain.Entities;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperLerVenda
    {

        Venda MapperToEntity(LerVendaDto lerVendaDto);

        LerVendaDto MapperToDTO(Venda venda);
    }
}
