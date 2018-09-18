using Newtonsoft.Json;
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
        [JsonIgnore]
        public Guid EmployeurId { get; set; }[JsonIgnore]
        public string Numero { get; set; }[JsonIgnore]
        public Guid? EntrepriseMereId { get; set; }[JsonIgnore]
        public bool Actif { get; set; }[JsonIgnore]
        public string Adresse { get; set; }
        public string RaisonSociale { get; set; }[JsonIgnore]
        public string NumeroRc { get; set; }[JsonIgnore]
        public Guid StatutJuridiqueId { get; set; }[JsonIgnore]
        public bool EntrepriseEtrangere { get; set; }[JsonIgnore]
        public Guid SecteurActiviteId { get; set; }[JsonIgnore]
        public Guid BrancheActiviteId { get; set; }[JsonIgnore]
        public string Email { get; set; }[JsonIgnore]
        public string Fax { get; set; }[JsonIgnore]
        public string Telephone { get; set; }[JsonIgnore]
        public string Mobile { get; set; }[JsonIgnore]
        public Guid WilayaId { get; set; }[JsonIgnore]
        public Guid CommuneId { get; set; }[JsonIgnore]
        public Guid PaysId { get; set; }[JsonIgnore]
        public string Responsable { get; set; }[JsonIgnore]
        public string Fonction { get; set; }[JsonIgnore]
        public string AutresIndications { get; set; }[JsonIgnore]
        public string CauseDesactivation { get; set; }[JsonIgnore]
        public DateTime DateInscription { get; set; }[JsonIgnore]
        public string Rib { get; set; }[JsonIgnore]
        public short NombreEmployesNonDaip { get; set; }[JsonIgnore]
        public short NombreEmployesDaipenCours { get; set; }[JsonIgnore]
        public short NombreEmployesCta { get; set; }[JsonIgnore]
        public short NombreEmployesClassique { get; set; }[JsonIgnore]
        public string CompteBancaire { get; set; }[JsonIgnore]
        public string DenomnationCommerciale { get; set; }[JsonIgnore]
        public byte Position { get; set; }[JsonIgnore]
        public string Nif { get; set; }[JsonIgnore]
        public DateTime? DateInscriptionCnas { get; set; }[JsonIgnore]
        public DateTime? DateDebutActivite { get; set; }[JsonIgnore]
        public string CodeAgenceCnrss { get; set; }[JsonIgnore]
        public Guid? CodePostalId { get; set; }[JsonIgnore]
        public Guid SecteurJuridiqueId { get; set; }[JsonIgnore]
        public Guid IntervenantUserId { get; set; }[JsonIgnore]
        public short? TypeEmployeur { get; set; }[JsonIgnore]
        public bool? IsGeneratedByAnem { get; set; }[JsonIgnore]
        public short? TypeCreationEmployeur { get; set; }[JsonIgnore]
        public string NumeroOld { get; set; }[JsonIgnore]
        public bool? ByOnline { get; set; }[JsonIgnore]
        public DateTime? DateEnregistrement { get; set; }[JsonIgnore]

        public BranchesActivites BrancheActivite { get; set; }[JsonIgnore]
        public CodesPostaux CodePostal { get; set; }[JsonIgnore]
        public Communes Commune { get; set; }[JsonIgnore]
        public Employeurs EntrepriseMere { get; set; }[JsonIgnore]
        public Intervenants IntervenantUser { get; set; }[JsonIgnore]
        public Pays Pays { get; set; }[JsonIgnore]
        public SecteursActivites SecteurActivite { get; set; }[JsonIgnore]
        public SecteursJuridiques SecteurJuridique { get; set; }[JsonIgnore]
        public StatutsJuridiques StatutJuridique { get; set; }[JsonIgnore]
        public Wilayas Wilaya { get; set; }[JsonIgnore]
        public ICollection<Contacts> Contacts { get; set; }[JsonIgnore]
        public ICollection<EmployeurDocuments> EmployeurDocuments { get; set; }[JsonIgnore]
        public ICollection<Employeurs> InverseEntrepriseMere { get; set; }[JsonIgnore]
        public ICollection<NomenclatureActivites> NomenclatureActivites { get; set; }[JsonIgnore]
        public ICollection<Offres> Offres { get; set; }[JsonIgnore]
        public ICollection<Visites> Visites { get; set; }
    }
}
