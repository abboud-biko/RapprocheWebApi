using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Parametres
    {
        public Guid ParametreId { get; set; }
        public string Nom { get; set; }
        public string Valeur { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Description { get; set; }
        public byte Categorie { get; set; }
    }
}
