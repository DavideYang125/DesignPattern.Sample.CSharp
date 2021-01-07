using System;
using BuilderPattern.BaseSample;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BaseSample();
        }

        public static void BaseSample()
        {
            Director director = new Director();
            director.Builder = new BigConcreteBuilder();
            director.Run();

            director.Builder = new SmallConcreteBuilder();
            director.Run();

            Console.ReadLine();
        }
    }
}
