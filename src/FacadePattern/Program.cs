using System;
using FacadePattern.BaseSample;

/// <summary>
/// 外观模式
/// </summary>
namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            Console.ReadKey();
        }
    }
}
