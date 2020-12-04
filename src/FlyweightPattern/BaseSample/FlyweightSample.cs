/**
 享元模式包含如下角色：
    Flyweight: 抽象享元类
    ConcreteFlyweight: 具体享元类
    FlyweightFactory: 享元工厂类
 * **/

using System;
using System.Collections;

namespace FlyweightPattern.BaseSample
{
    /// <summary>
    /// 享元工厂
    /// </summary>
    public class FlyweightFactory
    {
        public Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
        }

        public Flyweight GetFlyweight(string key)
        {
            if (flyweights.ContainsKey(key))
                return flyweights[key] as Flyweight;
            else return null;
        }
    }

    /// <summary>
    /// 抽象享元抽象类
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicsstate);
    }

    /// <summary>
    /// 具体享元类
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        /// <summary>
        /// 内部状态
        /// </summary>
        private string intrinsicstate;

        public ConcreteFlyweight(string intrinsicstate)
        {
            this.intrinsicstate = intrinsicstate;
        }

        public override void Operation(int extrinsicsstate)
        {
            Console.WriteLine($"内部状态:{intrinsicstate},外部状态:{extrinsicsstate}");
        }
    }
}
