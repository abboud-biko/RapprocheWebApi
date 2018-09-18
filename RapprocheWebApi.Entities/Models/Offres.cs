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

        public Guid OffreId { get; set; }
        public short PorteeOffre { get; set; }
        public Guid EmployeurId { get; set; }
        public byte Etat { get; set; }
        public int NombreCandidats { get; set; }
        public int NombrePostesCree { get; set; }
        public string CauseDesactivation { get; set; }
        public DateTime? DateExpiration { get; set; }
        public Guid? NiveauInstructionId { get; set; }
        public Guid? NiveauQualificationId { get; set; }
        public string CauseCloture { get; set; }
        public short Mobilite { get; set; }
        public Guid? VisiteId { get; set; }
        public DateTime DateInscription { get; set; }
        public string Numero { get; set; }
        public int NombrePlacesLibres { get; set; }
        public byte Experience { get; set; }
        public Guid MetierOffertId { get; set; }
        public Guid CommuneId { get; set; }
        public decimal? SalaireOffert { get; set; }
        public Guid TypeContratId { get; set; }
        public bool IsRechercheActive { get; set; }
        public Guid StructureId { get; set; }
        public short NiveauCompensation { get; set; }
        public Guid UserId { get; set; }
        public byte EtatAvancement { get; set; }
        public bool IsAnonyme { get; set; }
        public DateTime DateSuivi { get; set; }
        public int NombrePostesAnnules { get; set; }
        public int NombrePostesSatisfaits { get; set; }
        public string LieuTravail { get; set; }
        public Guid? SituationServiceMilitaireId { get; set; }
        public byte CategoriePermisConduire { get; set; }
        public byte? AgeMinimum { get; set; }
        public byte? AgeMaximum { get; set; }
        public byte? NiveauMaitriseOutilInformatique { get; set; }
        public Guid? OffreOriginaleId { get; set; }
        public DateTime? DateCloture { get; set; }
        public DateTime? DateAnnulation { get; set; }
        public bool? IsModifieeEnLigne { get; set; }
        public string NumeroOld { get; set; }
        public bool? ByOnline { get; set; }
        public bool? IsValide { get; set; }
        public bool? IsShared { get; set; }
        public DateTime? DateShared { get; set; }
        public Guid? SharedBy { get; set; }
        public bool? CanShared { get; set; }

        [JsonIgnore]
        public Communes Commune { get; set; }
        [JsonIgnore]
        public Employeurs Employeur { get; set; }
        [JsonIgnore]
        public Appellations MetierOffert { get; set; }
        [JsonIgnore]
        public NiveauxInstructions NiveauInstruction { get; set; }
        [JsonIgnore]
        public NiveauxQualifications NiveauQualification { get; set; }
        [JsonIgnore]
        public Offres OffreOriginale { get; set; }
        [JsonIgnore]
        public SituationsServiceMilitaires SituationServiceMilitaire { get; set; }
        [JsonIgnore]
        public Structures Structure { get; set; }
        [JsonIgnore]
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
