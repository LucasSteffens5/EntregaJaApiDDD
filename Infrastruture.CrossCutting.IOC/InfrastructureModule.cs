using Autofac;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Module = Autofac.Module;

namespace Infrastruture.CrossCutting.IOC
{
    [ExcludeFromCodeCoverage]
    public class InfrastructureModule : Module
    {
        private readonly IConfiguration _configuration;

        public InfrastructureModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(new[] { typeof(InfrastructureModule).GetTypeInfo().Assembly })
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
