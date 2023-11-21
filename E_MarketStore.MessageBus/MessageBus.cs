using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_MarketStore.MessageBus
{
    public class MessageBus : IMessageBus
    {
        private string connectionString = 

        public async Task PublishMessage(object message, string topic_queue_Name)
        {
            await using var client = new ServiceBusClient()
        }
    }
}
