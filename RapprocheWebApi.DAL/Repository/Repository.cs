using Microsoft.EntityFrameworkCore;
using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnemAPI.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
     where TEntity : class
    {

        private readonly AnemContext _dbContext;


        private DbSet<TEntity> dbset;
        public Repository(AnemContext dbContext)
        {
            _dbContext = dbContext;
            dbset = _dbContext.Set<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbset.Add(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbset.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbset.AsQueryable();
        }

        public TEntity GetById(Guid? id)
        {

            return dbset.Find(id);
        }

        public IQueryable<TEntity> FindBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {

            IQueryable<TEntity> query = _dbContext.Set<TEntity>().Where(predicate);
            return query;
        }

        public void Update(TEntity entity)
        {


            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            // _dbContext.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
            dbset.Update(entity);

            // _dbContext.Attach(entity);
        }
        

        private void SaveChange()
        {

            _dbContext.SaveChanges();
        }

    }
}