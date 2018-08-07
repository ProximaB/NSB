using System;
using MediatR;

namespace NSB.Domain.Core.Models
{
    public class Message : INotification
    {
        public Guid Id { get; }
        public DateTime DateCreated { get; }

        public Message()
        {
            Id = new Guid();
            DateCreated = DateTime.Now;
        }
    }
}