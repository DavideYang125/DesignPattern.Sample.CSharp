using System;
using AdapterPattern.BaseSample;

namespace AdapterPattern
{
    class Program
    {
        /// <summary>
        /// 客户端
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ITarget adapter = new Adapter();
            adapter.Request();
            Console.ReadKey();
        }
    }
}
