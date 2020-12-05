/**
 模式结构：
    抽象访问者角色（Vistor）:声明一个或者多个访问操作，使得所有具体访问者必须实现的接口。
    具体访问者角色（ConcreteVistor）：实现抽象访问者角色中所有声明的接口。
    抽象元素角色（Element）：声明一个接受操作，接受一个访问者对象作为参数。
    具体元素角色（ConcreteElement）：实现抽象元素所规定的接受操作。
    结构对象角色（ObjectStructure）：元素的容器，可以包含多个不同类或接口的容器。
 * **/

using System;
using System.Collections.Generic;

namespace VistorPattern.BaseSample
{
    /// <summary>
    /// 抽象元素角色
    /// </summary>
    public abstract class Elememt
    {
        public abstract void Accept(IVistor vistor);
    }

    /// <summary>
    /// 具体元素角色
    /// </summary>
    public class ElementA : Elememt
    {
        public override void Accept(IVistor vistor)
        {
            vistor.AcceptElementA();
        }
    }

    /// <summary>
    /// 具体元素角色
    /// </summary>
    public class ElementB : Elememt
    {
        public override void Accept(IVistor vistor)
        {
            vistor.AcceptElementB();
        }
    }

    /// <summary>
    /// 抽象访问角色
    /// </summary>
    public interface IVistor
    {
        public void AcceptElementA();

        public void AcceptElementB();
    }

    /// <summary>
    /// 具体访问者
    /// </summary>
    public class VisitorFirst : IVistor
    {
        public void AcceptElementA()
        {
            Console.WriteLine($"{this.GetType().Name} 访问了ElementA");
        }

        public void AcceptElementB()
        {
            Console.WriteLine($"{this.GetType().Name} 访问了ElementB");
        }
    }

    /// <summary>
    /// 具体访问者
    /// </summary>
    public class VisitorSecond : IVistor
    {
        public void AcceptElementA()
        {
            Console.WriteLine($"{this.GetType().Name} 访问了ElementA");
        }

        public void AcceptElementB()
        {
            Console.WriteLine($"{this.GetType().Name} 访问了ElementB");
        }
    }

    /// <summary>
    /// 结构对象角色
    /// </summary>
    public class ElementContainer
    {
        public List<Elememt> elements = new List<Elememt>();

        public void Attach(Elememt element)
        {
            elements.Add(element);
        }

        public void Detach(Elememt element)
        {
            elements.Remove(element);
        }

        public void Accept(IVistor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }

    }
}
