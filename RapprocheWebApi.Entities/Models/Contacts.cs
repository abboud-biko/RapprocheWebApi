using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Contacts
    {
        public Guid ContactId { get; set; }
        public string Interlocuteur { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public Guid? EmployeurId { get; set; }
        public string FonctionInterlocuteur { get; set; }

        public Employeurs Employeur { get; set; }
    }
}
