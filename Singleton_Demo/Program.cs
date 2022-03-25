using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }

        // for testing different Singleton scenarios, replace the class name below with SingletonEarly,SingletonThreadSafe,SingletonDoubleChkLockThreadSafe
        private static void PrintTeacherDetails()
        {
            SingletonLazy fromTeacher = SingletonLazy.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            SingletonLazy fromStudent = SingletonLazy.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}