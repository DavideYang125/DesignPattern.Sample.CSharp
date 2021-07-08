using System;
using FactoryMethodPattern.BaseSample;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactoryClient.GetProduct();
            FactoryMethodClient.FactoryMethodDemo();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 简单工厂客户端
    /// </summary>
    public class SimpleFactoryClient
    {
        public static void GetProduct()
        {
            var product = SimpleFactory.CreateProduct(ProductTypeEnum.A);
        }
    }
}
