﻿using System;
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
            SendMessage sm = new rabbitmq_sender.SendMessage();
            while (true)
            {
                string consoleMessage = Console.ReadLine();
                if (consoleMessage.Equals("q") || consoleMessage.Equals("Q"))
                    break;
                else
                {
                    sm.sendMessageToClient("localhost", "queue", "queue", consoleMessage);
                }
            }



        }
    }
}
