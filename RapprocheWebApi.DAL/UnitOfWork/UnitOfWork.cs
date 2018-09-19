using AnemAPI.DAL.Repository;
using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RapprocheWebApi.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AnemContext _context;

        public UnitOfWork()
        {
            _context = new AnemContext();
        }
        
        IRepository<Rapprochements> _rapprochements;

        public IRepository<Rapprochements> Rapprochements
        {
            get
            {
                if (_rapprochements == null)
                {
                    _rapprochements = new Repository<Rapprochements>(_context);
                }
                return _rapprochements;
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
