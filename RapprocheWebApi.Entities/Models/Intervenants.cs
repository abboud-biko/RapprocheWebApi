using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Intervenants
    {
        public Intervenants()
        {
            Convocations = new HashSet<Convocations>();
            Demandes = new HashSet<Demandes>();
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
            IntervenantsStructures = new HashSet<IntervenantsStructures>();
            Notifications = new HashSet<Notifications>();
            Offres = new HashSet<Offres>();
            Orientations = new HashSet<Orientations>();
            PropositionsReferentiel = new HashSet<PropositionsReferentiel>();
            ProspectionIntervenant = new HashSet<ProspectionIntervenant>();
            Traces = new HashSet<Traces>();
            Visites = new HashSet<Visites>();
        }

        public string NomAr { get; set; }
        public string NomFr { get; set; }
        public string PrenomAr { get; set; }
        public string PrenomFr { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public Guid UserId { get; set; }
        public bool? ByOnline { get; set; }

        public ICollection<Convocations> Convocations { get; set; }
        public ICollection<Demandes> Demandes { get; set; }
        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
        public ICollection<IntervenantsStructures> IntervenantsStructures { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<Orientations> Orientations { get; set; }
        public ICollection<PropositionsReferentiel> PropositionsReferentiel { get; set; }
        public ICollection<ProspectionIntervenant> ProspectionIntervenant { get; set; }
        public ICollection<Traces> Traces { get; set; }
        public ICollection<Visites> Visites { get; set; }
    }
}
