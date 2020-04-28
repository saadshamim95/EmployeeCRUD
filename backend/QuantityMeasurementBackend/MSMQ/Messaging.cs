using Experimental.System.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantityMeasurementBackend.MSMQ
{
    public class Messaging
    {
        public void SendMessage(string message, decimal value)
        {
            MessageQueue messageQueue = null;
            string description = message;
            string myQueue = @".\Private$\myQueue";

            try
            {
                if (MessageQueue.Exists(myQueue))
                {
                    messageQueue = new MessageQueue(myQueue);
                }
                else
                {
                    MessageQueue.Create(myQueue);
                    messageQueue = new MessageQueue(myQueue);
                }
                string result = message + value;
                messageQueue.Send(result, description);
            }
            catch
            {
                throw;
            }
        }

        public void ReceiveMessage()
        {
            Messaging messaging = new Messaging();
            MessageQueue messageQueue = null;
            string myQueue = @".\Private$\myQueue";
            try
            {
                messageQueue = new MessageQueue(myQueue);
                Message[] message = messageQueue.GetAllMessages();
                if (message.Length > 0)
                {
                    foreach (Message msg in message)
                    {
                        msg.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                        string result = msg.Body.ToString();
                        Console.WriteLine(result);
                        messageQueue.Receive();
                    }
                }
                else
                {
                    Console.WriteLine("No Message");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}