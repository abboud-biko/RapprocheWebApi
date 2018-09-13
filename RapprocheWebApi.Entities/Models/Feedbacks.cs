using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Feedbacks
    {
        public Guid FeedbackId { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Feed { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Identity { get; set; }
    }
}
