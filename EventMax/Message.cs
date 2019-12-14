using System;
using System.Reflection;

namespace EventMax
{
    public class Message
    {
        public Message(string subject, string text)
        {
            Subject = subject;
            Text = text;
        }

        public string Subject { get; private set; }

        public string Text { get; private set; }

        public DateTime SendTime { get; set; }

        public DateTime ReciveTime { get; set; }

        public User Sender { get; set; }

        public User Reciver { get; set; }

        public override string ToString()
        {
            return string.Format("Тема: {0}\nСообщение: {1}", Subject, Text);
        }
    }
}
