

using EShop.Data.Entities.Common;

namespace EShop.Data.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public Task AddEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeEntities(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task AddRengeEntities(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletePermanent(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRangeEntities(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteRangeEtities(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public void EditEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetEntityById(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
