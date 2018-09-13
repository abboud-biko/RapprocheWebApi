using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProspectionIntervenant
    {
        public Guid ProspectionsProspectionId { get; set; }
        public Guid IntervenantsUserId { get; set; }

        public Intervenants IntervenantsUser { get; set; }
        public Prospections ProspectionsProspection { get; set; }
    }
}
