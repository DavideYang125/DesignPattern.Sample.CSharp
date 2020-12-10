using System;
using CommandPattern.BaseSample;

namespace CommandPattern
{
    /// <summary>
    /// 命令模式
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
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoke = new Invoke(command);
            invoke.ExecuteCommand();
            Console.ReadKey();
        }
    }
}
