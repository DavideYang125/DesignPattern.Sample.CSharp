/*
    模式结构
    抽象构件（Component）
    树叶构件（Leaf）
    树枝构件（Composite）
 */

using System;
using System.Collections.Generic;

namespace CompositePattern.BaseSample
{
    /// <summary>
    /// 抽象构件
    /// </summary>
    public abstract class Component
    {
        public virtual string Name { get; set; }

        public abstract void Add(Component child);

        public abstract void Remove(Component child);

        public abstract void Display(int depth = 0);
    }

    /// <summary>
    /// 树叶构件
    /// </summary>
    public class Leaf : Component
    {
        public override void Add(Component child)
        {
            throw new System.NotImplementedException();
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine(new String('-', depth * 2) + Name);
        }

        public override void Remove(Component child)
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// 树枝构件
    /// </summary>
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public override void Add(Component child)
        {
            if (child != null) children.Add(child);
        }

        public override void Display(int depth = 0)
        {
            Console.WriteLine(new String('-', depth * 2) + Name);
            children.ForEach(x =>
            {
                x.Display(depth + 1);
            });
        }

        public override void Remove(Component child)
        {
            if (children != null) children.Remove(child);
        }
    }
}
