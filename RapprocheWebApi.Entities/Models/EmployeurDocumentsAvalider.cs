using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class EmployeurDocumentsAvalider
    {
        public short DocumentId { get; set; }
        public Guid EmployeurId { get; set; }
        public string Numero { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public bool Actuelle { get; set; }
        public Guid EmployeurDocId { get; set; }
        public bool? ByOnline { get; set; }

        public EmployeurTypeDoc Document { get; set; }
        public EmployeursAvalider Employeur { get; set; }
    }
}
