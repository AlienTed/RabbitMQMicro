using RabbitMQMicro.Domain.Core.Events;
using System;

namespace RabbitMQMicro.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
