using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 The below code implementation using lock solves the multithreading issue. But the problem is that it
 is slow down your application as only one thread can access the GetInstance property at any given 
 point of time. We can overcome the above problem by using the Double-checked locking mechanism.
 */

namespace SingletonDemo
{
    public sealed class SingletonThreadSafe
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private SingletonThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static SingletonThreadSafe instance = null;

        public static SingletonThreadSafe GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
