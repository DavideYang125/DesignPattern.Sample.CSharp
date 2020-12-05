using System;
using ChainOfRepository.BaseSample;

namespace ChainOfRepository
{
    /// <summary>
    /// 责任链模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BaseSample();
        }

        public static void BaseSample()
        {
            Handler handlerA = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Handler handlerC = new ConcreteHandlerC();

            handlerA.SetNextHandler(handlerB);
            handlerB.SetNextHandler(handlerC);

            handlerA.HandleRequest(5);
            Console.WriteLine();
            handlerA.HandleRequest(15);
            Console.WriteLine();
            handlerA.HandleRequest(25);
            Console.ReadKey();
        }
    }
}
