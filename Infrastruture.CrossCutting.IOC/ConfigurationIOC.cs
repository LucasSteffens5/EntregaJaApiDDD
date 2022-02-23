using Application.Interface;
using Application.Service;
using Autofac;
using Domain.Core.Interfaces.Services;
using Domain.Services.Services;
using Infrastruture.CrossCutting.Adapter.Interfaces;
using Infrastruture.CrossCutting.Adapter.Mappers;

namespace Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ProdutoService>().As<IProdutoService>();

            builder.RegisterType<MapperCriarProduto>().As<IMapperCriarProduto>();
            
            builder.RegisterType<MapperAtualizarProduto>().As<IMapperAtualizarProduto>();
           
            builder.RegisterType<MapperLerProduto>().As<IMapperLerProduto>();
            
            builder.RegisterType<ApplicationServiceVenda>().As<IApplicationServiceVenda>();

            builder.RegisterType<MapperLerVenda>().As<IMapperLerVenda>();

            builder.RegisterType<MapperCriarVenda>().As<IMapperCriarVenda>();
            
            builder.RegisterType<MapperCriarProdutoNaVenda>().As<IMapperCriarProdutoNaVenda>();
        }
    }
}
