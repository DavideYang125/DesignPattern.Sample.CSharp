

using System;
/**
代理模式包含如下角色：
Subject: 抽象主题角色
Proxy: 代理主题角色
RealSubject: 真实主题角色
* **/
namespace ProxyPattern.BaseSample
{
    /// <summary>
    /// 抽象主题
    /// </summary>
    public interface ISubject
    {
        void Request();
    }

    /// <summary>
    /// 具体真实主题
    /// </summary>
    public class RealSubject: ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject.Request");
        }
    }

    /// <summary>
    /// 代理主题
    /// </summary>
    public class Proxy : RealSubject
    {

    }
}
