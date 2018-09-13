using Microsoft.EntityFrameworkCore;
using RapprocheWebApi.DAL.UnitOfWork;
using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RapprocheWebApi.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AnemContext _context;
        private DbSet<T> _dbset;

        public Repository(AnemContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public void Add(T entity)
        {
            if( entity == null )
            {
                throw new ArgumentNullException("entity");
            }
            _dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            T existing = _dbset.Find(entity);
            if (existing != null) _dbset.Remove(existing);
        }

        public IQueryable<T> Get()
        {
            return _dbset.AsQueryable();
        }

        public IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).AsQueryable();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _dbset.Update(entity);
        }

        private void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
