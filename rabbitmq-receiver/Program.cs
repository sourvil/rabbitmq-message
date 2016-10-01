using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbitmq_receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            receiveMessage receiver = new rabbitmq_receiver.receiveMessage();
            receiver.receiveMessageFromServer("localhost", "queue");            
        }
    }
}
