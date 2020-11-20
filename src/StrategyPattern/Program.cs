using System;
using StrategyPattern.BaseSample;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Context context = new Context(new ConcreteStrategyA());
            context.AlgorithmInvoke();


            NewContext newContext = new NewContext();
            newContext.AlgorithmInvoke(new ConcreteStrategyB());

            Console.ReadKey();

        }

        
    }
}
