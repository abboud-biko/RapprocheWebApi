using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Employeurs
    {
        public Employeurs()
        {
            Contacts = new HashSet<Contacts>();
            EmployeurDocuments = new HashSet<EmployeurDocuments>();
            InverseEntrepriseMere = new HashSet<Employeurs>();
            NomenclatureActivites = new HashSet<NomenclatureActivites>();
            Offres = new HashSet<Offres>();
            Visites = new HashSet<Visites>();
        }

        public Guid EmployeurId { get; set; }
        public string Numero { get; set; }
        public Guid? EntrepriseMereId { get; set; }
        public bool Actif { get; set; }
        public string Adresse { get; set; }
        public string RaisonSociale { get; set; }
        public string NumeroRc { get; set; }
        public Guid StatutJuridiqueId { get; set; }
        public bool EntrepriseEtrangere { get; set; }
        public Guid SecteurActiviteId { get; set; }
        public Guid BrancheActiviteId { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public Guid WilayaId { get; set; }
        public Guid CommuneId { get; set; }
        public Guid PaysId { get; set; }
        public string Responsable { get; set; }
        public string Fonction { get; set; }
        public string AutresIndications { get; set; }
        public string CauseDesactivation { get; set; }
        public DateTime DateInscription { get; set; }
        public string Rib { get; set; }
        public short NombreEmployesNonDaip { get; set; }
        public short NombreEmployesDaipenCours { get; set; }
        public short NombreEmployesCta { get; set; }
        public short NombreEmployesClassique { get; set; }
        public string CompteBancaire { get; set; }
        public string DenomnationCommerciale { get; set; }
        public byte Position { get; set; }
        public string Nif { get; set; }
        public DateTime? DateInscriptionCnas { get; set; }
        public DateTime? DateDebutActivite { get; set; }
        public string CodeAgenceCnrss { get; set; }
        public Guid? CodePostalId { get; set; }
        public Guid SecteurJuridiqueId { get; set; }
        public Guid IntervenantUserId { get; set; }
        public short? TypeEmployeur { get; set; }
        public bool? IsGeneratedByAnem { get; set; }
        public short? TypeCreationEmployeur { get; set; }
        public string NumeroOld { get; set; }
        public bool? ByOnline { get; set; }
        public DateTime? DateEnregistrement { get; set; }

        public BranchesActivites BrancheActivite { get; set; }
        public CodesPostaux CodePostal { get; set; }
        public Communes Commune { get; set; }
        public Employeurs EntrepriseMere { get; set; }
        public Intervenants IntervenantUser { get; set; }
        public Pays Pays { get; set; }
        public SecteursActivites SecteurActivite { get; set; }
        public SecteursJuridiques SecteurJuridique { get; set; }
        public StatutsJuridiques StatutJuridique { get; set; }
        public Wilayas Wilaya { get; set; }
        public ICollection<Contacts> Contacts { get; set; }
        public ICollection<EmployeurDocuments> EmployeurDocuments { get; set; }
        public ICollection<Employeurs> InverseEntrepriseMere { get; set; }
        public ICollection<NomenclatureActivites> NomenclatureActivites { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<Visites> Visites { get; set; }
    }
}
