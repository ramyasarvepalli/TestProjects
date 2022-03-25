using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* In the Double-checked locking mechanism, first, we will check whether the instance is created
 or not. If not then only we will synchronize the method as shown below. This is faster than Single lock chk.*/


namespace SingletonDemo
{
    public sealed class SingletonDoubleChkLockThreadSafe
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private SingletonDoubleChkLockThreadSafe()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static SingletonDoubleChkLockThreadSafe instance = null;

        public static SingletonDoubleChkLockThreadSafe GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDoubleChkLockThreadSafe();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
