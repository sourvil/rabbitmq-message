using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace rabbitmq_sender
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Message Send
            //SendMessage sm = new rabbitmq_sender.SendMessage();
            //while (true)
            //{
            //    string consoleMessage = Console.ReadLine();
            //    if (consoleMessage.Equals("q") || consoleMessage.Equals("Q"))
            //        break;
            //    else
            //    {
            //        sm.sendMessageToClient("localhost", "queue", "queue", consoleMessage);
            //    }
            //}

            // Single Task Message Send to Multiple Consumers
            //SendTaskQueueMessage taskMessage = new SendTaskQueueMessage();
            //while (true)
            //{
            //    string consoleMessage = Console.ReadLine();
            //    if (consoleMessage.Equals("q") || consoleMessage.Equals("Q"))
            //        break;
            //    else
            //    {
            //        taskMessage.sendTaskMessageToClient("localhost", "task_queue", "task_queue", consoleMessage);
            //    }
            //}

            // Exchange Queue Message Send
            SendExchangeQueue exchangeSendMessage = new SendExchangeQueue();
            while (true)
            {
                string consoleMessage = Console.ReadLine();
                if (consoleMessage.Equals("q") || consoleMessage.Equals("Q"))
                    break;
                else
                {
                    exchangeSendMessage.sendMessageToClient("localhost","logs","fanout","task_queue", "task_queue", consoleMessage);
                }
            }

        }
    }
}
