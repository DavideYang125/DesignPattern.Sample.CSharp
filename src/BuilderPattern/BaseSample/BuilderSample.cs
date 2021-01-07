/*
建造者模式包含如下角色：
Builder：抽象建造者
ConcreteBuilder：具体建造者
Director：指挥者
Product：产品角色
 * **/

using System;

namespace BuilderPattern.BaseSample
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public interface Builder
    {
        public abstract string BuildA();

        public abstract string BuildB();

        public abstract string BuildC();

        public virtual Product GetResult()
        {
            return new Product
            {
                PartA = BuildA(),
                PartB = BuildB(),
                PartC = BuildC()
            };
        }
    }

    /// <summary>
    /// 具体建造者
    /// </summary>
    public class BigConcreteBuilder : Builder
    {
        public string BuildA()
        {
            return "BigPartA";
        }

        public string BuildB()
        {
            return "BigPartB";
        }

        public string BuildC()
        {
            return "BigPartC";
        }
    }

    /// <summary>
    /// 具体建造者
    /// </summary>
    public class SmallConcreteBuilder : Builder
    {
        public string BuildA()
        {
            return "SmallPartA";
        }

        public string BuildB()
        {
            return "SmallPartB";
        }

        public string BuildC()
        {
            return "SmallPartC";
        }
    }

    /// <summary>
    /// 指挥者角色
    /// </summary>
    public class Director
    {
        public Builder Builder { get; set; }

        public void Run()
        {
            Console.WriteLine(Builder.GetResult().ToString());
        }
    }

    /// <summary>
    /// 产品角色
    /// </summary>
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }

        public override string ToString()
        {
            var newLine = System.Environment.NewLine;
            return $"partA:{PartA}{newLine}partB:{PartB}{newLine}partC:{PartC}{newLine}";
        }
    }
}
