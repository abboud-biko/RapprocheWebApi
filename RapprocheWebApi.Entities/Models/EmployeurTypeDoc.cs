using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class EmployeurTypeDoc
    {
        public EmployeurTypeDoc()
        {
            EmployeurDocuments = new HashSet<EmployeurDocuments>();
            EmployeurDocumentsAvalider = new HashSet<EmployeurDocumentsAvalider>();
        }

        public short DocumentId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }

        public ICollection<EmployeurDocuments> EmployeurDocuments { get; set; }
        public ICollection<EmployeurDocumentsAvalider> EmployeurDocumentsAvalider { get; set; }
    }
}
