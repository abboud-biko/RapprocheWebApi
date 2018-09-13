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

        public Guid TypeContratId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public bool IsRenouvelable { get; set; }
        public short Duree { get; set; }
        public bool IsReconductible { get; set; }
        public short DureeProlongation { get; set; }
        public decimal MontantAide { get; set; }
        public bool IsFormation { get; set; }
        public Guid CategorieContratId { get; set; }
        public Guid SecteurActiviteId { get; set; }
        public short AgeMaximumAutorise { get; set; }
        public string Code { get; set; }
        public bool IsNecessiteDossier { get; set; }

        public CategoriesContrats CategorieContrat { get; set; }
        public SecteursActivites SecteurActivite { get; set; }
        public ICollection<Contrats> Contrats { get; set; }
        public ICollection<CorrespondancesIdqc> CorrespondancesIdqc { get; set; }
        public ICollection<Demandes> Demandes { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<TypeContratNatureDemande> TypeContratNatureDemande { get; set; }
        public ICollection<TypesContratReconduction> TypesContratReconductionTypesContratsEligiblesReconductionTypeContrat { get; set; }
        public ICollection<TypesContratReconduction> TypesContratReconductionTypesContratsSourceReconductionTypeContrat { get; set; }
    }
}
