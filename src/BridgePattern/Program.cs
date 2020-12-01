using System;
using BridgePattern.BaseSapmle;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BaseSample();
        }

        /// <summary>
        /// 基础例子
        /// </summary>
        public static void BaseSample()
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();
            Console.ReadKey();
        }
    }
}
