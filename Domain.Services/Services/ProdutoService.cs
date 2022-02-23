using Application.DTO.DTO;
using Domain.Core.Interfaces.Repository;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository): base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void AdicionarProdutoAoBancoDeDados(Produto produto)
        {
            _produtoRepository.AddAsync(produto);
        }


        public async Task<Produto> BuscarProdutoPorIdNaBaseDeDados(int id)
        {
            return await _produtoRepository.GetByIdAsync(id);
        }

        public bool ProdutoNaoEncontrado(Produto produto)
        {
            return produto == null ? true : false;
        }

        public async void AtualizarProduto(Produto produto)
        {
            await _produtoRepository.UpdateAsync(produto);
        }

        public async Task<IEnumerable<Produto>> RetornarTodosProdutosDaBaseDeDados()
        {
            return await _produtoRepository.ListAsync();
        }

        public async void RemoverProdutoDaBaseDeDados(Produto produto)
        {
            await _produtoRepository.RemoveAsync(produto);
        }

        public void RetornarDataHoraDaConsulta(LerProdutoDto produtoDto)
        {
            produtoDto.HoraDaConsulta = DateTime.Now;
        }
    }
}
