using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using RapprocheWebApi.DAL.Repository;

namespace RapprocheWebApi.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Demandeurs> Demandeurs { get; }
        void Dispose();
        void SaveChanges();
    }
}
