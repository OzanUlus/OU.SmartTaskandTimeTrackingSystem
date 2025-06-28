using SmartTaskandTimeTrackingSystem.Domain.Entities;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task DeleteAsync(TEntity entity);
    }
}
