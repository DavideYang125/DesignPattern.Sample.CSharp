/**
    Mediator: 抽象中介者
    ConcreteMediator: 具体中介者
    Colleague: 抽象同事类
    ConcreteColleague: 具体同事类
 * **/

using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.BaseSample
{
    class MediatorSample
    {
    }

    public abstract class AbstractMediator
    {
        public abstract void Send(string message, AbstractColleague colleague);
    }

    public class Mediator : AbstractMediator
    {
        public Mediator(ColleagueA colleagueA, ColleagueB colleagueB)
        {
            this.colleagueA = colleagueA;
            this.colleagueB = colleagueB;
        }

        private ColleagueA colleagueA { get; set; }
        private ColleagueB colleagueB { get; set; }


        public override void Send(string message, AbstractColleague colleague)
        {
            if (colleague.GetType() == typeof(ColleagueA))
            {
                colleagueB.Receive(message);
            }
            else
            {
                colleagueA.Receive(message);
            }
        }
    }

    public abstract class AbstractColleague
    {
        public abstract void Send(string message, AbstractMediator mediator);
        public abstract void Receive(string message);
    }

    public class ColleagueA : AbstractColleague
    {
        //private AbstractMediator mediator;

        public override void Receive(string message)
        {
            Console.WriteLine($"A 收到消息 {message}");
        }

        public override void Send(string message, AbstractMediator mediator)
        {
            mediator.Send(message, this);
        }
    }

    public class ColleagueB : AbstractColleague
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"B 收到消息 {message}");
        }

        public override void Send(string message, AbstractMediator mediator)
        {
            mediator.Send(message, this);
        }
    }

}
