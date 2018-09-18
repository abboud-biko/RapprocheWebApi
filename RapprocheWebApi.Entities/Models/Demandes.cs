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

        public Guid DemandeId { get; set; }
        public Guid DemandeurId { get; set; }
        public DateTime Date { get; set; }
        public string Numero { get; set; }
        public Guid StructureId { get; set; }
        public short PorteeCompensation { get; set; }
        public DateTime? DateAnnulationPrevue { get; set; }
        public DateTime? DateCloture { get; set; }
        public bool ClotureeParSysteme { get; set; }
        public DateTime? DateCloturePrevue { get; set; }
        public string CauseCloture { get; set; }
        public short Mobilite { get; set; }
        public Guid NatureDemandeId { get; set; }
        public Guid TypeContratId { get; set; }
        public Guid? DispositifId { get; set; }
        public Guid MetierPrincipalId { get; set; }
        public bool Actuelle { get; set; }
        public short Etat { get; set; }
        public int Anciennete { get; set; }
        public decimal? SalaireSouhaite { get; set; }
        public Guid UserId { get; set; }
        public DateTime? DateMiseEnInstancePrevue { get; set; }
        public Guid? FonctionActuelleId { get; set; }
        public bool IsSatisfaite { get; set; }
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
