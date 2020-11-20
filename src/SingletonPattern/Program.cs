using System;
using SingletonPattern.Sample;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetSingleton();
            Console.ReadKey();
        }
    }
}
