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

        public List<Rapprochements> GetRapprochementsByDate(DateTime date)
        {
            IQueryable<Rapprochements> rapprochements = _unitOfWork.Rapprochements.FindBy(

                d => d.Offre.DateInscription >= date
                && d.Offre.Etat == 1
                && d.Offre.NombrePlacesLibres > 0
                && d.Offre.IsRechercheActive == false
                //&& d.Offre.IsValide == true
                && d.Demande.Demandeur.Email != null
                && d.Demande.Demandeur.Email != ""
                && d.Demande.Actuelle == true
                && (d.Demande.Etat == 1 || d.Demande.Etat == 2)
                )
                .Include(a => a.Offre)
                .Include(a => a.Demande.Demandeur)
                .Include(a => a.Offre.Commune.Wilaya)
                .Include(a => a.Offre.Employeur)
                .Include(a => a.Offre.MetierOffert)
                .Include(a => a.Offre.NiveauInstruction)
                .Include(a => a.Offre.NiveauQualification)
                .Include(a => a.Offre.TypeContrat.CategorieContrat.Dispositif)
                .OrderBy(o => o.Demande.DemandeurId);
            return rapprochements.ToList();
        }


        

    }
}
