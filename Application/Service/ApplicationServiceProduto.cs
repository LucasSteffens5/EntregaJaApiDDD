using Application.DTO.DTO;
using Application.Interface;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapperLerProduto _mapperLerProduto;
        private readonly IMapperAtualizarProduto _mapperAtualizarProduto;
        private readonly IMapperCriarProduto _mapperCriarProduto;
        public ApplicationServiceProduto(IProdutoService produtoService, IMapperLerProduto mapperLerProduto, IMapperAtualizarProduto mapperAtualizarProduto, IMapperCriarProduto mapperCriarProduto)
        {
            _produtoService = produtoService;
            _mapperLerProduto = mapperLerProduto;
            _mapperAtualizarProduto = mapperAtualizarProduto;
            _mapperCriarProduto = mapperCriarProduto;
        }

        public void AdicionarProduto(CriarProdutoDto produtoDto)
        {
            var objProduct = _mapperCriarProduto.MapperToEntity(produtoDto);
            _produtoService.AddAsync(objProduct);
        }

        public void AtualizarProduto(int id, AtualizarProdutoDto produtoDto)
        {
            var objProduct = _mapperAtualizarProduto.MapperToEntity(produtoDto);
            _produtoService.AtualizarProduto(objProduct);
        }

        public void DeletarProduto(int id)
        {
            var objProduct = _produtoService.BuscarProdutoPorIdNaBaseDeDados(id).Result;
            _produtoService.RemoverProdutoDaBaseDeDados(objProduct);
        }

        public LerProdutoDto RecuperarProdutoPorId(int id)
        {
            var product = _produtoService.BuscarProdutoPorIdNaBaseDeDados(id).Result;
            return _mapperLerProduto.MapperToDTO(product);
        }
        


        public Task<IEnumerable<Produto>> RecuperarTodosProdutos()
            => _produtoService.RetornarTodosProdutosDaBaseDeDados();
    }
}
