/**
 策略模式包含如下角色：
    Context: 环境类
    Strategy: 抽象策略类
    ConcreteStrategy: 具体策略类
 * **/
using System;

namespace StrategyPattern.BaseSample
{
    /// <summary>
    /// 抽象策略类、接口
    /// </summary>
    public interface IStrategy
    {
        string Algorithm();
    }

    /// <summary>
    /// 具体策略类A
    /// </summary>
    public class ConcreteStrategyA : IStrategy
    {
        public string Algorithm()
        {
            return "ConcreteStrategyA";
        }
    }

    /// <summary>
    /// 具体策略类B
    /// </summary>
    public class ConcreteStrategyB : IStrategy
    {
        public string Algorithm()
        {
            return "ConcreteStrategyB";
        }
    }

    /// <summary>
    /// 环境类
    /// </summary>
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void AlgorithmInvoke()
        {
            if (_strategy is null) throw new ArgumentNullException("strategy is null");
            Console.WriteLine(_strategy.Algorithm());
        }
    }

    /// <summary>
    /// 结合泛型 另一种用法
    /// </summary>
    public class NewContext
    {
        public void AlgorithmInvoke<T>(T t) where T : IStrategy
        {
            Console.WriteLine(t.Algorithm());
        }
    }
}
