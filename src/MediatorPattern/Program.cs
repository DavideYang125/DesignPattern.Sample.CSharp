using System;
using MediatorPattern.BaseSample;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ColleagueA a = new ColleagueA();
            ColleagueB b = new ColleagueB();
            var mediator = new Mediator(a, b);
            a.Send("你好", mediator);

        }
    }
}
