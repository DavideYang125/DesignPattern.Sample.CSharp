using System;
using StrategyPattern.BaseSample;

namespace StrategyPattern
{
    /// <summary>
    /// 策略模式
    /// </summary>
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
