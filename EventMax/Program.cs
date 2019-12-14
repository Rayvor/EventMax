using System;

namespace EventMax
{
    class Program
    {
        static void Main(string[] args)
        {
            User userMax = new User("Max");
            User userIgor = new User("Igor");

            Message message = new Message("Hi", "Hello");

            userMax.SendMessage(userIgor, message);
        }
    }
}
