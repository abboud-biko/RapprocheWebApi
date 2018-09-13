using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Structures
    {
        public Structures()
        {
            Demandes = new HashSet<Demandes>();
            DemandeursStructures = new HashSet<DemandeursStructures>();
            IntervenantsStructures = new HashSet<IntervenantsStructures>();
            InverseStructureParent = new HashSet<Structures>();
            Notifications = new HashSet<Notifications>();
            OffreStructureCompensation = new HashSet<OffreStructureCompensation>();
            Offres = new HashSet<Offres>();
            PropositionsReferentiel = new HashSet<PropositionsReferentiel>();
            Prospections = new HashSet<Prospections>();
            Quartiers = new HashSet<Quartiers>();
            Traces = new HashSet<Traces>();
        }

        public Guid StructureId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public short Niveau { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AdresseAr { get; set; }
        public string AdresseFr { get; set; }
        public Guid? StructureParentId { get; set; }
        public Guid WilayaId { get; set; }
        public bool? CanOutsidePlacement { get; set; }
        public string Responsable { get; set; }
        public string Mobile { get; set; }
        public string PageFbNom { get; set; }

        public Structures StructureParent { get; set; }
        public Wilayas Wilaya { get; set; }
        public ICollection<Demandes> Demandes { get; set; }
        public ICollection<DemandeursStructures> DemandeursStructures { get; set; }
        public ICollection<IntervenantsStructures> IntervenantsStructures { get; set; }
        public ICollection<Structures> InverseStructureParent { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<OffreStructureCompensation> OffreStructureCompensation { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<PropositionsReferentiel> PropositionsReferentiel { get; set; }
        public ICollection<Prospections> Prospections { get; set; }
        public ICollection<Quartiers> Quartiers { get; set; }
        public ICollection<Traces> Traces { get; set; }
    }
}
