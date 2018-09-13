using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Quartiers
    {
        public Quartiers()
        {
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
        }

        public Guid QuartierId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid SecteurUrbainId { get; set; }
        public Guid StructureId { get; set; }

        public SecteursUrbains SecteurUrbain { get; set; }
        public Structures Structure { get; set; }
        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
    }
}
