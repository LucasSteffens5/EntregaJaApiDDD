using Application.DTO.DTO;
using Application.Interface;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Application.Service
{
    public class ApplicationServiceVenda: IApplicationServiceVenda
    {
        private readonly IVendaService _vendaService;
        private readonly IMapperCriarVenda _mapperCriarVenda;
        private readonly IMapperLerVenda _mapperLerVenda;
        public ApplicationServiceVenda(IVendaService vendaService, IMapperCriarVenda mapperCriarVenda, IMapperLerVenda mapperLerVenda)
        {
            _vendaService = vendaService;
            _mapperCriarVenda = mapperCriarVenda;
            _mapperLerVenda = mapperLerVenda;
        }

        public void CancelarVenda(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Venda> HistoricoDeVenda()
        {
            throw new System.NotImplementedException();
        }

        public void RealizarVenda(CriarVendaDto criarVendaDto)
        {
            var objSale = _mapperCriarVenda.MapperToEntity(criarVendaDto);
            
        }

        public LerVendaDto RecuperarVendaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
