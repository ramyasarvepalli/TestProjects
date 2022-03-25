using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace SingletonDemo
    {
        public sealed class SingletonEarly
        {
            private static int counter = 0;
            private SingletonEarly()
            {
                counter++;
                Console.WriteLine("Counter Value " + counter.ToString());
            }

            // this following line of code creates the Singleton instance at the time of application startup
            private static readonly SingletonEarly singleInstance = new SingletonEarly();  

            public static SingletonEarly GetInstance
            {
                get
                {
                    return singleInstance;
                }
            }
            public void PrintDetails(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
