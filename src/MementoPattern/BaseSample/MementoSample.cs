/**
备忘录模式中主要有三类角色：
发起人角色：记录当前时刻的内部状态，负责创建和恢复备忘录数据。
备忘录角色：负责存储发起人对象的内部状态，在进行恢复时提供给发起人需要的状态。
管理者角色：负责保存备忘录对象。
* **/
namespace MementoPattern.BaseSample
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class Memento
    {
        public string state { get; set; }

        public Memento(string state)
        {
            this.state = state;
        }
    }

    /// <summary>
    /// 发起人
    /// </summary>
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void RestoreMemento(Memento memento)
        {
            State = memento.state;
        }
    }

    public class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
