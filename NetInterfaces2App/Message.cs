using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetInterfaces2App
{
    interface IMessage
    {
        string Text { set; get; }
    }

    interface ISending
    {
        void SendMessage();
    }

    class Message : IMessage, ISending
    {
        public string Text { get; set; }

        public Message(string text)
        {
            Text = text;
        }

        public void SendMessage()
        {
            Console.WriteLine($"Send message: {Text}");
        }
    }

    class Messanger<T> where T : ISending, IMessage
    {
        public void Send(T message)
        {
            message.SendMessage();
        }
    }
}
