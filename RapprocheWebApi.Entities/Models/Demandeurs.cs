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

        public Guid DemandeurId { get; set; }
        public string Numero { get; set; }
        public string NomAr { get; set; }
        public string NomFr { get; set; }
        public string PrenomAr { get; set; }
        public string PrenomFr { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AdresseAr { get; set; }
        public string AdresseFr { get; set; }
        public Guid TypePieceIdentiteId { get; set; }
        public string NumeroPieceIdentite { get; set; }
        public bool Gendre { get; set; }
        public short SituationFamiliale { get; set; }
        public Guid SituationServiceMilitaireId { get; set; }
        public short NombreEnfants { get; set; }
        public string Nss { get; set; }
        public bool? Handicap { get; set; }
        public DateTime DateInscription { get; set; }
        public Guid CommuneNaissanceId { get; set; }
        public Guid WilayaNaissanceId { get; set; }
        public Guid PaysNaissanceId { get; set; }
        public short Civilite { get; set; }
        public DateTime PieceIdentitieDelivreeLe { get; set; }
        public string PieceIdentitieDelivreePar { get; set; }
        public string NumeroActeNaissance { get; set; }
        public string PrenomPere { get; set; }
        public string NomMere { get; set; }
        public byte NombrePersonnesAcharge { get; set; }
        public Guid? EnregistrementCadreAutreDispositifId { get; set; }
        public bool IsAnonyme { get; set; }
        public string PrenomMere { get; set; }
        public Guid QuartierId { get; set; }
        public Guid IntervenantUserId { get; set; }
        public bool? ByOnline { get; set; }
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
