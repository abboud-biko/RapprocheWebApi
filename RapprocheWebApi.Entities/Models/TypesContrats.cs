using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class TypesContrats
    {
        public TypesContrats()
        {
            Contrats = new HashSet<Contrats>();
            CorrespondancesIdqc = new HashSet<CorrespondancesIdqc>();
            Demandes = new HashSet<Demandes>();
            Offres = new HashSet<Offres>();
            TypeContratNatureDemande = new HashSet<TypeContratNatureDemande>();
            TypesContratReconductionTypesContratsEligiblesReconductionTypeContrat = new HashSet<TypesContratReconduction>();
            TypesContratReconductionTypesContratsSourceReconductionTypeContrat = new HashSet<TypesContratReconduction>();
        }
        [JsonIgnore]
        public Guid TypeContratId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }[JsonIgnore]
        public bool IsRenouvelable { get; set; }[JsonIgnore]
        public short Duree { get; set; }[JsonIgnore]
        public bool IsReconductible { get; set; }[JsonIgnore]
        public short DureeProlongation { get; set; }[JsonIgnore]
        public decimal MontantAide { get; set; }[JsonIgnore]
        public bool IsFormation { get; set; }[JsonIgnore]
        public Guid CategorieContratId { get; set; }[JsonIgnore]
        public Guid SecteurActiviteId { get; set; }[JsonIgnore]
        public short AgeMaximumAutorise { get; set; }[JsonIgnore]
        public string Code { get; set; }[JsonIgnore]
        public bool IsNecessiteDossier { get; set; }

        public CategoriesContrats CategorieContrat { get; set; }[JsonIgnore]
        public SecteursActivites SecteurActivite { get; set; }[JsonIgnore]
        public ICollection<Contrats> Contrats { get; set; }[JsonIgnore]
        public ICollection<CorrespondancesIdqc> CorrespondancesIdqc { get; set; }[JsonIgnore]
        public ICollection<Demandes> Demandes { get; set; }[JsonIgnore]
        public ICollection<Offres> Offres { get; set; }[JsonIgnore]
        public ICollection<TypeContratNatureDemande> TypeContratNatureDemande { get; set; }[JsonIgnore]
        public ICollection<TypesContratReconduction> TypesContratReconductionTypesContratsEligiblesReconductionTypeContrat { get; set; }[JsonIgnore]
        public ICollection<TypesContratReconduction> TypesContratReconductionTypesContratsSourceReconductionTypeContrat { get; set; }
    }
}
