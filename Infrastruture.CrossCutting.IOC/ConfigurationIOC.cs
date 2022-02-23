using Application.Interface;
using Application.Service;
using Autofac;
using Domain.Core.Interfaces.Services;
using Domain.Services.Services;

namespace Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ProdutoService>().As<IProdutoService>();

            //builder.RegisterType<MapperCriarProduto>().As<IMapperCriarProduto>();
        }
    }
}
