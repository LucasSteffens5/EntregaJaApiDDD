using Application.DTO.DTO;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces.Services
{
    public interface IProdutoService: IServiceBase<Produto>
    {
        void AdicionarProdutoAoBancoDeDados(Produto produto);

        Task<Produto> BuscarProdutoPorIdNaBaseDeDados(int id);

        bool ProdutoNaoEncontrado(Produto produto);

        Task<IEnumerable<Produto>> RetornarTodosProdutosDaBaseDeDados();

        void RemoverProdutoDaBaseDeDados(Produto produto);

        void RetornarDataHoraDaConsulta(LerProdutoDto produtoDto);

        public void AtualizarProduto(Produto produto);
    }
}
