using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class EnvironnementsTravails
    {
        public Guid EnvironnementTravailId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid FicheNameId { get; set; }
    }
}
