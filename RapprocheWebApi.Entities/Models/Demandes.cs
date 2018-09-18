using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Demandes
    {
        public Demandes()
        {
            Convocations = new HashSet<Convocations>();
            ConvocationsEnLigne = new HashSet<ConvocationsEnLigne>();
            DemandeAppellationAlternative = new HashSet<DemandeAppellationAlternative>();
            EtatsDemandes = new HashSet<EtatsDemandes>();
            Orientations = new HashSet<Orientations>();
            Postulations = new HashSet<Postulations>();
            Rapprochements = new HashSet<Rapprochements>();
        }
        [JsonIgnore]
        public Guid DemandeId { get; set; }[JsonIgnore]
        public Guid DemandeurId { get; set; }[JsonIgnore]
        public DateTime Date { get; set; }[JsonIgnore]
        public string Numero { get; set; }[JsonIgnore]
        public Guid StructureId { get; set; }[JsonIgnore]
        public short PorteeCompensation { get; set; }[JsonIgnore]
        public DateTime? DateAnnulationPrevue { get; set; }[JsonIgnore]
        public DateTime? DateCloture { get; set; }[JsonIgnore]
        public bool ClotureeParSysteme { get; set; }[JsonIgnore]
        public DateTime? DateCloturePrevue { get; set; }[JsonIgnore]
        public string CauseCloture { get; set; }[JsonIgnore]
        public short Mobilite { get; set; }[JsonIgnore]
        public Guid NatureDemandeId { get; set; }[JsonIgnore]
        public Guid TypeContratId { get; set; }[JsonIgnore]
        public Guid? DispositifId { get; set; }[JsonIgnore]
        public Guid MetierPrincipalId { get; set; }[JsonIgnore]
        public bool Actuelle { get; set; }[JsonIgnore]
        public short Etat { get; set; }[JsonIgnore]
        public int Anciennete { get; set; }[JsonIgnore]
        public decimal? SalaireSouhaite { get; set; }[JsonIgnore]
        public Guid UserId { get; set; }[JsonIgnore]
        public DateTime? DateMiseEnInstancePrevue { get; set; }[JsonIgnore]
        public Guid? FonctionActuelleId { get; set; }[JsonIgnore]
        public bool IsSatisfaite { get; set; }[JsonIgnore]
        public bool? ByOnline { get; set; }

        
        public Demandeurs Demandeur { get; set; }
        [JsonIgnore]
        public Dispositifs Dispositif { get; set; }
        [JsonIgnore]
        public Appellations FonctionActuelle { get; set; }
        [JsonIgnore]
        public Appellations MetierPrincipal { get; set; }
        [JsonIgnore]
        public NaturesDemandes NatureDemande { get; set; }
        [JsonIgnore]
        public Structures Structure { get; set; }
        [JsonIgnore]
        public TypesContrats TypeContrat { get; set; }
        [JsonIgnore]
        public Intervenants User { get; set; }
        [JsonIgnore]
        public ICollection<Convocations> Convocations { get; set; }
        [JsonIgnore]
        public ICollection<ConvocationsEnLigne> ConvocationsEnLigne { get; set; }
        [JsonIgnore]
        public ICollection<DemandeAppellationAlternative> DemandeAppellationAlternative { get; set; }
        [JsonIgnore]
        public ICollection<EtatsDemandes> EtatsDemandes { get; set; }
        [JsonIgnore]
        public ICollection<Orientations> Orientations { get; set; }
        [JsonIgnore]
        public ICollection<Postulations> Postulations { get; set; }
        [JsonIgnore]
        public ICollection<Rapprochements> Rapprochements { get; set; }
    }
}
