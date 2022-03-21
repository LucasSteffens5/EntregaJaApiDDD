using Autofac;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Module = Autofac.Module;

namespace Application
{
    [ExcludeFromCodeCoverage]
    public class ApplicationModule : Module
    {
        private readonly IConfiguration _configuration;

        public ApplicationModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(new[] { typeof(ApplicationModule).GetTypeInfo().Assembly })
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            RegisterAutoMapper(builder);
        }

        private void RegisterAutoMapper(ContainerBuilder builder)
        {
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(new[] { typeof(ApplicationModule) });
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
