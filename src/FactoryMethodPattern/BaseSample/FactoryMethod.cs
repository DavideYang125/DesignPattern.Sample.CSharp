using System;

namespace FactoryMethodPattern.BaseSample
{
    public class FactoryMethodClient
    {
        public static void FactoryMethodDemo()
        {
            var factoryC = new FactoryC();
            var productC = factoryC.CreateProduct();
        }
    }

    public interface IFactory
    {
        IProduct CreateProduct();
    }

    public class FactoryC : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductC();
        }
    }

    public class ProductC : IProduct
    {
        internal ProductC()
        {
            Console.WriteLine("ProductC Created");
        }
        public string Name { get; set; } = "C";

        public double Price { get; set; } = 50;
    }
}
