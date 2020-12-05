using System;
using ProxyPattern.BaseSample;

namespace ProxyPattern
{
    /// <summary>
    /// 代理模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Proxy proxy = new Proxy(new RealSubject());
            proxy.Request();
        }
    }
}
