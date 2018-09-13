using RapprocheWebApi.DAL.Repository;
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

        IRepository<Demandeurs> _demandeurs;

        public IRepository<Demandeurs> Demandeurs
        {
            get
            {
                if (_demandeurs == null)
                {
                    _demandeurs = new Repository<Demandeurs>(_context);
                }
                return _demandeurs;
            }
        }

        IRepository<Demandeurs> IUnitOfWork.Demandeurs => throw new NotImplementedException();

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
