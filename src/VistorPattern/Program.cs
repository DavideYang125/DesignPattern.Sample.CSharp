using System;
using VistorPattern.BaseSample;

namespace VistorPattern
{
    /// <summary>
    /// 访问者模式
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
            ElementContainer container = new ElementContainer();
            container.Attach(new ElementA());
            container.Attach(new ElementB());
            container.Accept(new VisitorFirst());
            container.Accept(new VisitorSecond());

            Console.ReadKey();
        }
    }

  
}
