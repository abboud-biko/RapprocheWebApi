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

        public Communes CommuneNaissance { get; set; }
        public OrganismesAutresDispositifs EnregistrementCadreAutreDispositif { get; set; }
        public Intervenants IntervenantUser { get; set; }
        public Pays PaysNaissance { get; set; }
        public Quartiers Quartier { get; set; }
        public SituationsServiceMilitaires SituationServiceMilitaire { get; set; }
        public TypesPiecesIdentites TypePieceIdentite { get; set; }
        public Wilayas WilayaNaissance { get; set; }
        public Profils Profils { get; set; }
        public ICollection<Demandes> Demandes { get; set; }
        public ICollection<DemandeursStructures> DemandeursStructures { get; set; }
        public ICollection<Handicaps> Handicaps { get; set; }
    }
}
