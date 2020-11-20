/**
适配器模式包含如下角色：
Target：目标抽象类
Adapter：适配器类
Adaptee：适配者类
Client：客户类
* **/

using System;
namespace AdapterPattern.BaseSample
{
    /// <summary>
    /// 目标接口，也可以是抽象类，类
    /// </summary>
    public interface ITarget
    {
        void Request();
    }

    /// <summary>
    /// 适配者
    /// </summary>
    public class Adaptee
    {
        public virtual void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest");
        }
    }

    /// <summary>
    /// 适配器类
    /// </summary>
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}
