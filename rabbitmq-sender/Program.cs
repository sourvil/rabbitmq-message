using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbitmq_sender
{
    class Program
    {
        static void Main(string[] args)
        {
            sendMessage sm = new rabbitmq_sender.sendMessage();
            while (true)
            {
                string consoleMessage = Console.ReadLine();
                if (consoleMessage.Equals("q") || consoleMessage.Equals("Q"))
                    break;
                else
                {
                    //sm.sendMessageToClient("localhost", "queue", "route1", consoleMessage);
                    Console.WriteLine(consoleMessage + " is sent to clients");
                }
            }
            
        }
    }
}
