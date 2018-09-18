using RapprocheWebApi.DAL.UnitOfWork;
using RapprocheWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RapprocheWebApi.BLL.Services
{
    public class DemandeurBLL : IDemandeurBLL
    {

        private IUnitOfWork _unitOfWork;

        public DemandeurBLL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public List<Demandeurs> GetAllDemandeurs()
        {
            IQueryable<Demandeurs> demandeurs = _unitOfWork.Demandeurs.GetAll();
            return demandeurs.ToList();

        }



        public List<Demandeurs> GetDemandeur(Guid id)
        {
            IQueryable<Demandeurs> demandeurs = _unitOfWork.Demandeurs.FindBy(a => a.WilayaNaissanceId == id).Take(5);
            return demandeurs.ToList();
        }
    }
}
