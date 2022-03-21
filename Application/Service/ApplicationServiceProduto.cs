using Application.DTO.DTO;
using Application.Interface;
using AutoMapper;
using Domain.Core.Interfaces.Services;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;
       
        public ApplicationServiceProduto(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
            
        }

        public void AdicionarProduto(CriarProdutoDto produtoDto)
        {
            var objProduct = _mapper.Map<Produto>(produtoDto);
            _produtoService.AddAsync(objProduct);
        }

        public void AtualizarProduto(int id, AtualizarProdutoDto produtoDto)
        {
            var objProduct = _mapper.Map<Produto>(produtoDto);
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
            return _mapper.Map<LerProdutoDto>(product);
        }
        


        public Task<IEnumerable<Produto>> RecuperarTodosProdutos()
            => _produtoService.RetornarTodosProdutosDaBaseDeDados();
    }
}
