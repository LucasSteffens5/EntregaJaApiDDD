using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.DTO
{
    public class CriarVendaDto
	{

		[Required(ErrorMessage = "O campo CEP é obrigatório")]
		public string Cep { get; set; }
		public List<CriarProdutoNaVendaDto> ProdutosDaVenda { get; set; }

	}
}
