using System;
using TemplateMethodPattern.BaseSample;

namespace TemplateMethodPattern
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
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();
            Console.ReadKey();
        }
    }
}
