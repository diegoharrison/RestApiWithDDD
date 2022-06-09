using RestApiWithDDD.Domain.Core.Interfaces.Services;

namespace RestApiWithDDD.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient _repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            this._repositoryClient = repositoryClient;
        }
    }
}
