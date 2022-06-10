using Autofac;
using RestApiWithDDD.Application.Interfaces;
using RestApiWithDDD.Application.Interfaces.Mappers;
using RestApiWithDDD.Application.Mappers;
using RestApiWithDDD.Domain.Core.Interfaces.Services;
using RestApiWithDDD.Domain.Infrastructure.Data.Repositorys;
using RestApiWithDDD.Domain.Services;

namespace RestApiWithDDD.Domain.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion
        }
    }
}
