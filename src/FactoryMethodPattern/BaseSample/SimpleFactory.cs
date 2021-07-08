/*
 简单工厂模式包含如下角色：

Factory：工厂角色
工厂角色负责实现创建所有实例的内部逻辑
Product：抽象产品角色
抽象产品角色是所创建的所有对象的父类，负责描述所有实例所共有的公共接口
ConcreteProduct：具体产品角色
具体产品角色是创建目标，所有创建的对象都充当这个角色的某个具体类的实例。

 */
using System;

namespace FactoryMethodPattern.BaseSample
{
    public class SimpleFactory
    {
        public static IProduct CreateProduct(ProductTypeEnum productType)
        {
            switch (productType)
            {
                case ProductTypeEnum.A:
                    return new ProductA();
                case ProductTypeEnum.B:
                    return new ProductB();
                default:
                    throw new Exception("传输类型不存在");
            }
        }
    }

    public interface IProduct
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    public class ProductA : IProduct
    {
        internal ProductA()
        {
            Console.WriteLine("ProductA Created");
        }
        public string Name { get; set; } = "A";

        public double Price { get; set; } = 50;
    }

    public class ProductB : IProduct
    {
        internal ProductB()
        {
            Console.WriteLine("ProductB Created");
        }
        public string Name { get; set; } = "B";

        public double Price { get; set; } = 100;
    }

    public enum ProductTypeEnum
    {
        A = 1,
        B = 2
    }
}
