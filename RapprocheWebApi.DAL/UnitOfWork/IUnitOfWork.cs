using AnemAPI.DAL.Repository;
using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RapprocheWebApi.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Demandeurs> Demandeurs { get; }
        IRepository<Rapprochements> Rapprochements { get; }
        void Dispose();
        void SaveChanges();
    }
}
