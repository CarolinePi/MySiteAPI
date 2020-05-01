using Data.Entities;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstraction
{
    public interface IRepository<TEntity> where TEntity: BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task Create(TEntity entity);
        Task<TEntity> GetByID(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
