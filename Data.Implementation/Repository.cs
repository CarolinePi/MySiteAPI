using Data.Entities;
using Data.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementation
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity: BaseEntity
    {
        private DbSet<TEntity> _dbSet;
        public Repository(LibraryDbContext context)
        {
            _dbSet = context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public async Task<TEntity> GetByID(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }
    }
}
