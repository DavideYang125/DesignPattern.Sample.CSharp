using System;
using MediatorPattern.BaseSample;
using MediatorPattern.MsgNotify;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region base sample

            //ColleagueA a = new ColleagueA();
            //ColleagueB b = new ColleagueB();
            //var mediator = new Mediator(a, b);
            //a.Send("你好", mediator);

            #endregion

            #region msg notify sample

            var mediator = new NotificationMediator();
            var admin = new Person(mediator, "Admin");
            var user = new Person(mediator, "User");

            admin.Send("Watch out!");
            user.Send("I have Received");

            #endregion

            Console.ReadKey();
        }
    }
}
