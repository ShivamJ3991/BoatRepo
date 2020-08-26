using Boat.Contract;
using Boat.Data;
using Boat.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Boat.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        private readonly EntityContext context;
        private DbSet<TEntity> entities;
        string errorMessage = string.Empty;

        //public IQueryable<TEntity> Select()
        //{
        //    return this.context.CreateObjectSet<TEntity>();
        //}

        public Repository(EntityContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return entities.AsEnumerable();
        }
        public TEntity Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public TEntity Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
            return entity;
        }
        public TEntity Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
            return entity;
        }
        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.Where(predicate);
        }
    }
}
