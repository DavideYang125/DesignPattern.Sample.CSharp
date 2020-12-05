using System;
using MementoPattern.BaseSample;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录模式
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
            Originator originator = new Originator();
            originator.State = "state1";
            Console.WriteLine($"originator的状态 {originator.State}");
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "state2";
            Console.WriteLine($"originator的状态 {originator.State}");
            Console.WriteLine("开始通过备忘录恢复");
            originator.RestoreMemento(caretaker.Memento);
            Console.WriteLine($"originator的状态 {originator.State}");

            Console.ReadKey();
        }
    }
}
