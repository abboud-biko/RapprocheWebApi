using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Notifications
    {
        public Guid NotificationId { get; set; }
        public string Titre { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public short Severite { get; set; }
        public short Duree { get; set; }
        public Guid? StructureId { get; set; }
        public bool Lue { get; set; }
        public Guid? UserId { get; set; }

        public Structures Structure { get; set; }
        public Intervenants User { get; set; }
    }
}
