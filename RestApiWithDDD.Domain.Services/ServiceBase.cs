using RestApiWithDDD.Domain.Core.Interfaces.Repositorys;
using RestApiWithDDD.Domain.Core.Interfaces.Services;

namespace RestApiWithDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repository = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
            
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}
