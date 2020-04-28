using Experimental.System.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantityMeasurementBackend.MSMQ
{
    public class MSMQ
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


    }
}