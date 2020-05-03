using Experimental.System.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QuantityMeasurementBackend.MSMQ
{
    /// <summary>
    /// CLass Messaging
    /// </summary>
    public class Messaging
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="value">The value.</param>
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

        /// <summary>
        /// Receives the message.
        /// </summary>
        public void ReceiveMessage()
        {
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
                        File.WriteAllText(@"C:\Users\Saad Shamim\source\repos\Quantity Measurement FullStack\backend\QuantityMeasurementBackend\Result.txt", result);
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
            finally 
            {
                messageQueue.Dispose();
            }
        }
    }
}