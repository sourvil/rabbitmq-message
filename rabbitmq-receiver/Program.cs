using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace rabbitmq_receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Message
            //ReceiveMessage receiver = new ReceiveMessage();
            //receiver.receiveMessageFromServer("localhost", "queue");

            // Work Queue
            Worker worker = new Worker();
            worker.receiveMessageFromServerWorkQueue("localhost", "task_queue");
        }
    }
}
