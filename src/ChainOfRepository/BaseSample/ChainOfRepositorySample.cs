/**
 角色：
    抽象处理者角色（Handler）：定义出一个处理请求的接口。这个接口通常由接口或抽象类来实现。
    具体处理者角色（ConcreteHandler）：具体处理者接受到请求后，可以选择将该请求处理掉，或者将请求传给下一个处理者。因此，每个具体处理者需要保存下一个处理者的引用，以便把请求传递下去。
 * **/

using System;

namespace ChainOfRepository.BaseSample
{
    /// <summary>
    /// 抽象处理角色
    /// </summary>
    public abstract class Handler
    {
        protected Handler _nextHandler;

        public void SetNextHandler(Handler handler)
        {
            _nextHandler = handler;
        }

        public abstract void HandleRequest(int i);
    }

    /// <summary>
    /// 具体处理者角色
    /// </summary>
    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int i)
        {
            if (i < 10)
            {
                Console.WriteLine($"{this.GetType().Name}  处理了请求");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine($"{this.GetType().Name}  无法处理并向{_nextHandler.GetType().Name}转出了请求");
                _nextHandler.HandleRequest(i);

            }
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int i)
        {
            if (i < 20)
            {
                Console.WriteLine($"{this.GetType().Name}  处理了请求");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine($"{this.GetType().Name}  无法处理并向{_nextHandler.GetType().Name}转出了请求");
                _nextHandler.HandleRequest(i);

            }
        }
    }

    public class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(int i)
        {
            if (i < 30)
            {
                Console.WriteLine($"{this.GetType().Name}  处理了请求");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine($"{this.GetType().Name}  无法处理并向{_nextHandler.GetType().Name}转出了请求");
                _nextHandler.HandleRequest(i);

            }
        }
    }
}
