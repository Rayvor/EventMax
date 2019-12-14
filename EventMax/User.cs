using System;
using System.Collections.Generic;
using System.Text;

namespace EventMax
{
    public class User
    {
        public event EventHandler<Message> OnRecive;
        public event EventHandler<Message> OnSend;
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
            OnSend += PrintSenderText;
            OnRecive += PrintRecieverText;
        }

        public void SendMessage(User sender, Message message)
        {
            if (this == sender)
            {
                Console.WriteLine("Нельзя отправить сообщение отправителю.");
                return;
            }

            message.Sender = sender;
            message.Reciver = this;
            message.SendTime = DateTime.Now;

            OnSend?.Invoke(this, message);
            OnRecive?.Invoke(this, message);
        }

        private void PrintRecieverText(object sender, Message message)
        {
            message.ReciveTime = DateTime.Now;

            Console.WriteLine("{0}\nот юзера{1}\nв {2}",
                message, message.Sender, message.ReciveTime);
        }

        public void PrintSenderText(object sender, Message message)
        {
            Console.WriteLine("Отправил {0}\nюзеру {1}\nв {2}",
                message, message.Reciver, message.SendTime);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
