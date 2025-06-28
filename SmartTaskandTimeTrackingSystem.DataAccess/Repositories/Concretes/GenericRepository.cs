using Microsoft.EntityFrameworkCore;
using SmartTaskandTimeTrackingSystem.DataAccess.Context;
using SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Interfaces;
using SmartTaskandTimeTrackingSystem.Domain.Entities;

namespace SmartTaskandTimeTrackingSystem.DataAccess.Repositories.Concretes
{
    public class GenericRepository<TEntity>(AppDbContext context) : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var entry = await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entry.Entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
             context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var response = await context.Set<TEntity>().ToListAsync();
            return response;
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var entry = context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
            return entry.Entity;
        }
    }
}
