using Application.DTO.DTO;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IApplicationServiceProduto
    {
        void AdicionarProduto(CriarProdutoDto produto);

        public LerProdutoDto RecuperarProdutoPorId(int id);

        Task<IEnumerable<Produto>> RecuperarTodosProdutos();

        void AtualizarProduto(int id,  AtualizarProdutoDto produtoDto);

        void DeletarProduto(int id);

    }
}
