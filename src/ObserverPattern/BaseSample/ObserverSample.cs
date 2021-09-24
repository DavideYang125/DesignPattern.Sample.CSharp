/**
    观察者模式包含如下角色：
    Subject: 目标
    ConcreteSubject: 具体目标
    Observer: 观察者
    ConcreteObserver: 具体观察者
 * **/

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ObserverPattern.BaseSample
{
    /// <summary>
    /// 抽象目标
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> _observer = new List<Observer>();

        public void Attach(Observer observe)
        {
            _observer.Add(observe);
        }

        public void Detach(Observer observe)
        {
            _observer.Remove(observe);
        }

        public void Notify(string msg)
        {
            _observer.ForEach(x => { x.Update(msg); });
        }
    }

    /// <summary>
    /// 具体目标 ，即被观察者
    /// </summary>
    public class ConcreteSubject : Subject
    {
        private StateEnum _state = StateEnum.Normal;

        public StateEnum GetState()
        {
            return _state;
        }

        public void SetState(StateEnum state)
        {
            if (_state != state)
            {
                var msg = $"状态由{(int)_state}修改为{(int)state}";
                Console.WriteLine(msg);
                Notify(msg);
                _state = state;
            }
        }
    }

    /// <summary>
    /// 抽象观察者
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update(string msg);
    }

    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver : Observer
    {
        public ConcreteObserver(string role)
        {
            Role = role;
        }

        public string Role { get; set; }

        public override void Update(string msg)
        {
            Console.WriteLine($"{Role}收到消息 {msg},并进行处理");
        }
    }

    /// <summary>
    /// 状态
    /// </summary>
    public enum StateEnum
    {
        [Description("正常")] Normal = 1,
        [Description("暂停")] Stop = 2,
        [Description("结束")] Over = 1
    }
}
