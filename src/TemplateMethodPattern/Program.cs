using System;
using System.Threading;
using TemplateMethodPattern.BaseSample;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 模板方法模式
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
            AbstractClass a = new ConcreteClassA();
            a.TemplateMethod();
            Console.ReadKey();
        }
    }
}
