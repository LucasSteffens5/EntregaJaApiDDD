using Application;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Infrastruture.CrossCutting.IOC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace EntregaJaApi
{
    [ExcludeFromCodeCoverage]
    public class DefaultModule : Module
    {
        private readonly IConfiguration _configuration;
        public DefaultModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new ApplicationModule(_configuration));
            builder.RegisterModule(new InfrastructureModule(_configuration));
            RegisterCommonDependencies(builder);
        }
        private void RegisterCommonDependencies(ContainerBuilder builder)
        {
            builder.RegisterInstance(_configuration).As<IConfiguration>();
            
            var serviceCollection = new ServiceCollection();

            builder.Populate(serviceCollection);
        }
    }
}
