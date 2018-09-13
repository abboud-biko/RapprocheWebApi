using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OnlineNotifications
    {
        public Guid OnlineNotificationId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public short Type { get; set; }
        public string LongMessage { get; set; }
        public string DetailsUrl { get; set; }
        public string UrlParameters { get; set; }
        public short Severite { get; set; }
        public short Duration { get; set; }
        public bool IsViewed { get; set; }
        public Guid UserId { get; set; }
    }
}
