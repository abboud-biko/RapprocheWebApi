using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Demandeurs
    {
        public Demandeurs()
        {
            Demandes = new HashSet<Demandes>();
            DemandeursStructures = new HashSet<DemandeursStructures>();
            Handicaps = new HashSet<Handicaps>();
        }

        public Guid DemandeurId { get; set; }[JsonIgnore]
        public string Numero { get; set; }
        public string NomAr { get; set; }
        public string NomFr { get; set; }
        public string PrenomAr { get; set; }
        public string PrenomFr { get; set; }[JsonIgnore]
        public DateTime DateNaissance { get; set; }[JsonIgnore]
        public string Telephone { get; set; }[JsonIgnore]
        public string Mobile { get; set; }[JsonIgnore]
        public string Fax { get; set; }
        public string Email { get; set; }[JsonIgnore]
        public string AdresseAr { get; set; }[JsonIgnore]
        public string AdresseFr { get; set; }[JsonIgnore]
        public Guid TypePieceIdentiteId { get; set; }[JsonIgnore]
        public string NumeroPieceIdentite { get; set; }[JsonIgnore]
        public bool Gendre { get; set; }[JsonIgnore]
        public short SituationFamiliale { get; set; }[JsonIgnore]
        public Guid SituationServiceMilitaireId { get; set; }[JsonIgnore]
        public short NombreEnfants { get; set; }[JsonIgnore]
        public string Nss { get; set; }[JsonIgnore]
        public bool? Handicap { get; set; }[JsonIgnore]
        public DateTime DateInscription { get; set; }[JsonIgnore]
        public Guid CommuneNaissanceId { get; set; }[JsonIgnore]
        public Guid WilayaNaissanceId { get; set; }[JsonIgnore]
        public Guid PaysNaissanceId { get; set; }[JsonIgnore]
        public short Civilite { get; set; }[JsonIgnore]
        public DateTime PieceIdentitieDelivreeLe { get; set; }[JsonIgnore]
        public string PieceIdentitieDelivreePar { get; set; }[JsonIgnore]
        public string NumeroActeNaissance { get; set; }[JsonIgnore]
        public string PrenomPere { get; set; }[JsonIgnore]
        public string NomMere { get; set; }[JsonIgnore]
        public byte NombrePersonnesAcharge { get; set; }[JsonIgnore]
        public Guid? EnregistrementCadreAutreDispositifId { get; set; }[JsonIgnore]
        public bool IsAnonyme { get; set; }[JsonIgnore]
        public string PrenomMere { get; set; }[JsonIgnore]
        public Guid QuartierId { get; set; }[JsonIgnore]
        public Guid IntervenantUserId { get; set; }[JsonIgnore]
        public bool? ByOnline { get; set; }[JsonIgnore]
        public DateTime? DateEnregistrement { get; set; }

        [JsonIgnore]
        public Communes CommuneNaissance { get; set; }
        [JsonIgnore]
        public OrganismesAutresDispositifs EnregistrementCadreAutreDispositif { get; set; }
        [JsonIgnore]
        public Intervenants IntervenantUser { get; set; }
        [JsonIgnore]
        public Pays PaysNaissance { get; set; }
        [JsonIgnore]
        public Quartiers Quartier { get; set; }
        [JsonIgnore]
        public SituationsServiceMilitaires SituationServiceMilitaire { get; set; }
        [JsonIgnore]
        public TypesPiecesIdentites TypePieceIdentite { get; set; }
        [JsonIgnore]
        public Wilayas WilayaNaissance { get; set; }
        [JsonIgnore]
        public Profils Profils { get; set; }
        [JsonIgnore]
        public ICollection<Demandes> Demandes { get; set; }
        [JsonIgnore]
        public ICollection<DemandeursStructures> DemandeursStructures { get; set; }
        [JsonIgnore]
        public ICollection<Handicaps> Handicaps { get; set; }
    }
}
