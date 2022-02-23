﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTO.DTO
{
    public class AtualizarProdutoDto
    {

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo de preço é obrigatório")]
        public decimal Preco { get; set; }
    }
}
