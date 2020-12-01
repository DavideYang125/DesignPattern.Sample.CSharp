/**
  桥接模式包含的角色：
    Abstraction：抽象类
    RefinedAbstraction：扩充抽象类
    Implementor：实现类接口
    ConcreteImplementor：具体实现类
 * **/

using System;

namespace BridgePattern.BaseSapmle
{
    public abstract class Abstraction
    {
        private Implementor _implementor { get; set; }

        public virtual void SetImplementor(Implementor implementor)
        {
            _implementor = implementor;
        }

        public virtual void Operation()
        {
            _implementor.OperationImp();
        }
    }

    /// <summary>
    /// 扩展抽象类
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            base.Operation();
        }
    }

    /// <summary>
    /// 实现类接口
    /// </summary>
    public interface Implementor
    {
        public void OperationImp();
    }

    /// <summary>
    /// 具体实现类
    /// </summary>
    public class ConcreteImplementorA : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine(this.GetType().Name + " Operation");
        }
    }
    /// <summary>
    /// 具体实现类
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine(this.GetType().Name + " Operation");
        }
    }
}
