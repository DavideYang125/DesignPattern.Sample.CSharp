/**
 模式结构
    客户角色：发出一个具体的命令并确定其接受者。
    命令角色：声明了一个给所有具体命令类实现的抽象接口
    具体命令角色：定义了一个接受者和行为的弱耦合，负责调用接受者的相应方法。
    请求者角色：负责调用命令对象执行命令。
    接受者角色：负责具体行为的执行。
 * **/
using System;

namespace CommandPattern.BaseSample
{
    /// <summary>
    /// 抽象命令类
    /// </summary>
    public abstract class Command
    {
        protected Receiver _receiver;

        protected Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Action();
    }

    /// <summary>
    /// 具体命令类
    /// </summary>
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Action()
        {
            _receiver.Run();
        }
    }

    /// <summary>
    /// 命令接收者
    /// </summary>
    public class Receiver
    {
        public void Run()
        {
            Console.WriteLine($"{this.GetType().Name} run");
        }
    }

    /// <summary>
    /// 请求者
    /// </summary>
    public class Invoke
    {
        public Command _command;

        public Invoke(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Action();
        }
    }
}
