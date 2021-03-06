﻿using System.Threading.Tasks;
using ReCom.Connectivity;
using ReCom.SystemMessages;

namespace ReCom.Handlers.BuiltIn
{
    public class BuiltInReceivedMessageHandler : IHandle<ReceivedMessage>
    {
        public Task Handle(ReceivedMessage message, Connection connection)
        {
            connection.MarkAsReceived(message.ReceivedMessageId);
            return Task.CompletedTask;
        }
    }
}
