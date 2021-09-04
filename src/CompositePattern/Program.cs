using System;
using CompositePattern.BaseSample;

namespace CompositePattern
{
    /// <summary>
    /// /组合模式
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
            Component root = new Composite();
            root.Add(new Leaf { Name = "Leaf 1" });
            root.Add(new Leaf { Name = "Leaf 2" });

            var com = new Composite();
            root.Add(new Leaf { Name = "Leaf 10" });
            root.Add(new Leaf { Name = "Leaf 11" });

            var newCom = new Composite();
            newCom.Add(new Leaf { Name = "Leaf101" });
            newCom.Add(new Leaf { Name = "Leaf102" });

            com.Add(newCom);

            root.Add(com);
            var leafA = new Leaf { Name = "Leaf A" };
            root.Add(leafA);

            root.Add(new Leaf { Name = "Leaf D" });

            root.Display();

            Console.WriteLine("再次展示");

            root.Remove(leafA);
            root.Display();
            Console.ReadLine();
        }
    }
}
