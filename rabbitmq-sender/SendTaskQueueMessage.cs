using System;
using RabbitMQ.Client;
using System.Text;

namespace rabbitmq_sender
{
    class SendTaskQueueMessage
    {
        public void sendTaskMessageToClient(string hostName, string queueName, string routingKey, string message)
        {
            var factory = new ConnectionFactory() { HostName = hostName };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                var properties = channel.CreateBasicProperties();
                //properties.SetPersistent(true);
                properties.Persistent = true;

                channel.BasicPublish(exchange: "",
                                     routingKey: routingKey,
                                     basicProperties: properties,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}