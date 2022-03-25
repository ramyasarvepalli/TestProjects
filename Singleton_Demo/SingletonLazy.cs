using System;

namespace SingletonDemo
{
    public sealed class SingletonLazy
    {
        private static int counter = 0;
        private SingletonLazy()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Lazy<SingletonLazy> Instancelock =
                    new Lazy<SingletonLazy>(() => new SingletonLazy());
        public static SingletonLazy GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}