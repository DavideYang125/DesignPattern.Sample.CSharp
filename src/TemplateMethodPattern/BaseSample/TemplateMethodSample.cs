/**
 模板方法模式中涉及了两个角色：
    抽象模板角色（Vegetable扮演这个角色）：定义了一个或多个抽象操作，以便让子类实现，这些抽象操作称为基本操作。
    具体模板角色（ChineseCabbage和Spinach扮演这个角色）：实现父类所定义的一个或多个抽象方法。
 * **/

using System;

namespace TemplateMethodPattern.BaseSample
{
    /// <summary>
    /// 抽象模板
    /// </summary>
    public abstract class AbstractClass
    {
        public virtual void TemplateMethod()
        {
            Method1();
            Method2();
        }

        public abstract void Method1();

        public abstract void Method2(); 
    }

    /// <summary>
    /// 具体模板
    /// </summary>
    public class ConcreteClassA : AbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine(this.GetType().Name + " Method1");
        }

        public override void Method2()
        {
            Console.WriteLine(this.GetType().Name + " Method2");
        }
    }

    /// <summary>
    /// 具体模板
    /// </summary>
    public class ConcreteClassB : AbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine(this.GetType().Name + " Method1");
        }

        public override void Method2()
        {
            Console.WriteLine(this.GetType().Name + " Method2");
        }
    }
}
