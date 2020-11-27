using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.MsgNotify
{
    public interface IPerson
    {
        void Send(string message);

        void Receive(string message, string sender);
    }

    public delegate void NotificationEventHandler(string message, string sender);

    public class NotificationMediator
    {
        public event NotificationEventHandler NotificationReceived;

        public void Send(string message, string sender)
        {
            if (NotificationReceived != null)
            {
                NotificationReceived(message, sender);
            }
        }
    }

    public class Person : IPerson
    {
        private NotificationMediator _mediator;

        public string Role { get; set; }

        public Person(NotificationMediator mediator, string role)
        {
            _mediator = mediator;
            Role = role;
            _mediator.NotificationReceived += new NotificationEventHandler(Receive);
        }

        public void Receive(string message, string role)
        {
            if (role != Role)
            {
                Console.WriteLine($"{Role} received '{message}' from {role}");
            }
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Role} sends:  {message}");
            _mediator.Send(message, Role);
        }
    }
}
