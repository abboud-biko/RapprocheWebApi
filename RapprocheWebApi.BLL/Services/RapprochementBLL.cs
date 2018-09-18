using Microsoft.EntityFrameworkCore;
using RapprocheWebApi.DAL.UnitOfWork;
using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RapprocheWebApi.BLL.Services
{
    public class RapprochementBLL : IRapprochementBLL
    {

        private IUnitOfWork _unitOfWork;

        public RapprochementBLL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public List<Rapprochements> GetAllRapprochements()
        {
            return _unitOfWork.Rapprochements.GetAll().Include(b => b.Offre).Take(5).ToList();

        }

        public List<Rapprochements> GetRapprochementsByDate(DateTime date)
        {
            IQueryable<Rapprochements> rapprochements = _unitOfWork.Rapprochements.FindBy(
                d => d.Offre.DateInscription >= date)
                .Include(b => b.Offre)
                .Include(a => a.Demande.Demandeur)
                .Take(10);
            return rapprochements.ToList();
  

        }

    }
}
