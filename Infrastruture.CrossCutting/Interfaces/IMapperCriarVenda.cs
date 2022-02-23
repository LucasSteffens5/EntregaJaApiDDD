using Application.DTO.DTO;
using Domain.Entities;

namespace Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCriarVenda
    {
        Venda MapperToEntity(CriarVendaDto criarVendaDto);

        CriarVendaDto MapperToDTO(Venda venda);
    }
}
