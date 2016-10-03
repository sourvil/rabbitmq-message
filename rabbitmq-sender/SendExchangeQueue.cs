using System;
using RabbitMQ.Client;
using System.Text;

namespace rabbitmq_sender
{
    class SendExchangeQueue
    {
        public void sendMessageToClient(string hostName,string exchangeName, string exchangeType, string queueName, string routingKey, string message)
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: exchangeName, type: exchangeType);
                
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: exchangeName, routingKey: "", basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }

}