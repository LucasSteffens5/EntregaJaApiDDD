using Application.DTO.DTO;
using Application.Interface;
using AutoMapper;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Service
{
    public class ApplicationServiceVenda: IApplicationServiceVenda
    {
        private readonly IVendaService _vendaService;
        private readonly IMapper _mapper;
        public ApplicationServiceVenda(IVendaService vendaService, IMapper mapper)
        {
            _vendaService = vendaService;
            _mapper = mapper;
           
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
            var objSale = _mapper.Map<Venda>(criarVendaDto);
            
        }

        public LerVendaDto RecuperarVendaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
