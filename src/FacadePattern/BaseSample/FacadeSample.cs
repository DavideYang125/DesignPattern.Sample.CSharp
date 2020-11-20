
/**
 外观模式包含如下角色：
    Facade: 外观角色
    SubSystem:子系统角色
 **/

using System;

namespace FacadePattern.BaseSample
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class Facade
    {
        private SubSystemA _subSystemA = new SubSystemA();
        private SubSystemB _subSystemB = new SubSystemB();
        public void MethodA()
        {
            _subSystemA.MethodA();
        }

        public void MethodB()
        {
            _subSystemB.MethodB();
        }
    }

    /// <summary>
    /// 子系统A
    /// </summary>
    public class SubSystemA
    {
        public void MethodA()
        {
            Console.WriteLine("SubSystemA.MethodA");
        }
    }

    /// <summary>
    /// 子系统B
    /// </summary>
    public class SubSystemB
    {
        public void MethodB()
        {
            Console.WriteLine("SubSystemB.MethodB");
        }
    }
}
