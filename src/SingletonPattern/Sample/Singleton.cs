namespace SingletonPattern.Sample
{
    public class Singleton
    {
        /// <summary>
        /// 类的实例
        /// </summary>
        private static Singleton _singleton;
        private static readonly object _locker = new object();

        /// <summary>
        /// 确保构造函数不被外界访问
        /// </summary>
        private Singleton()
        {
        }

        /// <summary>
        /// 向外界提供全局的访问点
        /// </summary>
        /// <returns></returns>
        public Singleton GetSingleton()
        {
            lock (_locker)
            {
                //确保在多线程的情况下，只有一个线程创建实例
                if (_singleton is null)
                {
                    _singleton = new Singleton();
                }
            }
            return _singleton;
        }
    }
}
