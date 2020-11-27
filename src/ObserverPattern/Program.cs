using System;
using ObserverPattern.BaseSample;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region base sample

            BaseSample();

            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// 基础示例
        /// </summary>
        public static void BaseSample()
        {
            ConcreteSubject subject = new ConcreteSubject();
            Observer observerA = new ConcreteObserver("A");
            Observer observerB = new ConcreteObserver("B");
            subject.Attach(observerA);
            subject.Attach(observerB);
            subject.SetState(StateEnum.Stop);
        }
    }
}
