using Application.DTO.DTO;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interface
{
    public interface IApplicationServiceVenda
    {
        public void RealizarVenda(CriarVendaDto criarVendaDto);

        public LerVendaDto RecuperarVendaPorId(int id);

        public IEnumerable<Venda> HistoricoDeVenda();

        public void CancelarVenda(int id);

    }
}
