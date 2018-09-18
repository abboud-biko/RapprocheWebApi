using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Offres
    {
        public Offres()
        {
            Convocations = new HashSet<Convocations>();
            ConvocationsEnLigne = new HashSet<ConvocationsEnLigne>();
            InverseOffreOriginale = new HashSet<Offres>();
            OffreActiviteBase = new HashSet<OffreActiviteBase>();
            OffreActiviteSpecifique = new HashSet<OffreActiviteSpecifique>();
            OffreCompetenceBase = new HashSet<OffreCompetenceBase>();
            OffreCompetenceSpecifique = new HashSet<OffreCompetenceSpecifique>();
            OffreOptionDiplome = new HashSet<OffreOptionDiplome>();
            OffreSpecialiteDiplome = new HashSet<OffreSpecialiteDiplome>();
            OffreStructureCompensation = new HashSet<OffreStructureCompensation>();
            OffresLangues = new HashSet<OffresLangues>();
            Orientations = new HashSet<Orientations>();
            Postulations = new HashSet<Postulations>();
            Rapprochements = new HashSet<Rapprochements>();
        }

        public Guid OffreId { get; set; }[JsonIgnore]
        public short PorteeOffre { get; set; }[JsonIgnore]
        public Guid EmployeurId { get; set; }[JsonIgnore]
        public byte Etat { get; set; }
        public int NombreCandidats { get; set; }
        public int NombrePostesCree { get; set; }[JsonIgnore]
        public string CauseDesactivation { get; set; }[JsonIgnore]
        public DateTime? DateExpiration { get; set; }[JsonIgnore]
        public Guid? NiveauInstructionId { get; set; }[JsonIgnore]
        public Guid? NiveauQualificationId { get; set; }[JsonIgnore]
        public string CauseCloture { get; set; }[JsonIgnore]
        public short Mobilite { get; set; }[JsonIgnore]
        public Guid? VisiteId { get; set; }
        public DateTime DateInscription { get; set; }[JsonIgnore]
        public string Numero { get; set; }
        public int NombrePlacesLibres { get; set; }
        public byte Experience { get; set; }[JsonIgnore]
        public Guid MetierOffertId { get; set; }[JsonIgnore]
        public Guid CommuneId { get; set; }[JsonIgnore]
        public decimal? SalaireOffert { get; set; }[JsonIgnore]
        public Guid TypeContratId { get; set; }[JsonIgnore]
        public bool IsRechercheActive { get; set; }[JsonIgnore]
        public Guid StructureId { get; set; }[JsonIgnore]
        public short NiveauCompensation { get; set; }[JsonIgnore]
        public Guid UserId { get; set; }[JsonIgnore]
        public byte EtatAvancement { get; set; }[JsonIgnore]
        public bool IsAnonyme { get; set; }[JsonIgnore]
        public DateTime DateSuivi { get; set; }[JsonIgnore]
        public int NombrePostesAnnules { get; set; }[JsonIgnore]
        public int NombrePostesSatisfaits { get; set; }[JsonIgnore]
        public string LieuTravail { get; set; }[JsonIgnore]
        public Guid? SituationServiceMilitaireId { get; set; }[JsonIgnore]
        public byte CategoriePermisConduire { get; set; }[JsonIgnore]
        public byte? AgeMinimum { get; set; }[JsonIgnore]
        public byte? AgeMaximum { get; set; }[JsonIgnore]
        public byte? NiveauMaitriseOutilInformatique { get; set; }[JsonIgnore]
        public Guid? OffreOriginaleId { get; set; }[JsonIgnore]
        public DateTime? DateCloture { get; set; }[JsonIgnore]
        public DateTime? DateAnnulation { get; set; }[JsonIgnore]
        public bool? IsModifieeEnLigne { get; set; }[JsonIgnore]
        public string NumeroOld { get; set; }[JsonIgnore]
        public bool? ByOnline { get; set; }[JsonIgnore]
        public bool? IsValide { get; set; }[JsonIgnore]
        public bool? IsShared { get; set; }[JsonIgnore]
        public DateTime? DateShared { get; set; }[JsonIgnore]
        public Guid? SharedBy { get; set; }[JsonIgnore]
        public bool? CanShared { get; set; }

        
        public Communes Commune { get; set; }
        
        public Employeurs Employeur { get; set; }
        
        public Appellations MetierOffert { get; set; }
        
        public NiveauxInstructions NiveauInstruction { get; set; }
        
        public NiveauxQualifications NiveauQualification { get; set; }
        [JsonIgnore]
        public Offres OffreOriginale { get; set; }
        [JsonIgnore]
        public SituationsServiceMilitaires SituationServiceMilitaire { get; set; }
        [JsonIgnore]
        public Structures Structure { get; set; }
        
        public TypesContrats TypeContrat { get; set; }
        [JsonIgnore]
        public Intervenants User { get; set; }
        [JsonIgnore]
        public Visites Visite { get; set; }
        [JsonIgnore]
        public ICollection<Convocations> Convocations { get; set; }
        [JsonIgnore]
        public ICollection<ConvocationsEnLigne> ConvocationsEnLigne { get; set; }
        [JsonIgnore]
        public ICollection<Offres> InverseOffreOriginale { get; set; }
        [JsonIgnore]
        public ICollection<OffreActiviteBase> OffreActiviteBase { get; set; }
        [JsonIgnore]
        public ICollection<OffreActiviteSpecifique> OffreActiviteSpecifique { get; set; }
        [JsonIgnore]
        public ICollection<OffreCompetenceBase> OffreCompetenceBase { get; set; }
        [JsonIgnore]
        public ICollection<OffreCompetenceSpecifique> OffreCompetenceSpecifique { get; set; }
        [JsonIgnore]
        public ICollection<OffreOptionDiplome> OffreOptionDiplome { get; set; }
        [JsonIgnore]
        public ICollection<OffreSpecialiteDiplome> OffreSpecialiteDiplome { get; set; }
        [JsonIgnore]
        public ICollection<OffreStructureCompensation> OffreStructureCompensation { get; set; }
        [JsonIgnore]
        public ICollection<OffresLangues> OffresLangues { get; set; }
        [JsonIgnore]
        public ICollection<Orientations> Orientations { get; set; }
        [JsonIgnore]
        public ICollection<Postulations> Postulations { get; set; }
        [JsonIgnore]
        public ICollection<Rapprochements> Rapprochements { get; set; }
    }
}
