using Microsoft.EntityFrameworkCore;
using RestApiWithDDD.Domain.Core.Interfaces.Repositorys;

namespace RestApiWithDDD.Domain.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            } 
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlContext .Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
            } 
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            } 
            catch (Exception)
            {

                throw;
            }
        }
    }
}