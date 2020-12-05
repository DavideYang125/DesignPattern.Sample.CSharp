using System;
using FlyweightPattern.BaseSample;

namespace FlyweightPattern
{
    /// <summary>
    /// 享元模式
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
            FlyweightFactory factory = new FlyweightFactory();
            var fa = factory.GetFlyweight("A");
            if (fa != null) fa.Operation(1);
            var fb = factory.GetFlyweight("B");
            if (fb != null) fb.Operation(2);
            else
            {
                factory.flyweights.Add("B", new ConcreteFlyweight("B"));
                fb = factory.GetFlyweight("B");
            }
            
            fb.Operation(2);
            Console.ReadKey();
        }
    }
}
