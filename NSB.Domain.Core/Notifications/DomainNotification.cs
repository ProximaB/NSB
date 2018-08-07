using NSB.Domain.Core.Models;
using System;

namespace NSB.Domain.Core.Notification
{
    public class DomainNotification : Message
    {
        public string Body { get; set; }
        public string Title { get; set; }
        public DateTime? DateRead { get; private set; }

        public DomainNotification (string title, string body)
        {
            Title = title;
            Body = body;
        }

        public void MarkAsRead ()
        {
            DateRead = DateTime.Now;
        }
    }
}