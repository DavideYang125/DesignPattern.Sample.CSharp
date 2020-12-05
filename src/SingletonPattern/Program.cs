using System;
using SingletonPattern.Sample;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetSingleton();
            Console.ReadKey();
        }
    }
}
