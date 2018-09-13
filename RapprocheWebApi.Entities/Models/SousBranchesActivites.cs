using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SousBranchesActivites
    {
        public Guid SousBrancheActiviteId { get; set; }
        public Guid? BrancheActiviteId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }

        public BranchesActivites BrancheActivite { get; set; }
    }
}
