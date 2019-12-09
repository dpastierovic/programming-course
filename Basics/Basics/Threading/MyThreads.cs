using System;
using System.Threading.Tasks;

namespace Basics.Threading
{
    static class MyThreads
    {
        static object lockObj = new object();
        static object lockObj2 = new object();

        static int counter = 0;

        static bool thread1Running = true;
        static bool thread2Running = true;
        static bool thread3Running = true;

        public static void StartThreading()
        {
            while(true)
            {
                Task.Run(() => Count1());
                Task.Run(() => Count2());
                Task.Run(() => Count3());
                while (thread1Running || thread2Running || thread3Running) ;
                Console.WriteLine(counter);
                thread1Running = true;
                thread2Running = true;
                thread3Running = true;
                counter = 0;
            }
        }

        public static void Count1()
        {
            for(var i = 0; i < 10000000; i++)
            {
                lock (lockObj)
                {
                    counter++;
                }
            }
            thread1Running = false;
        }

        public static void Count2()
        {
            for (var i = 0; i < 10000000; i++)
            {
                lock (lockObj)
                {
                    counter++;
                }
            }
            thread2Running = false;
        }

        public static void Count3()
        {
            for (var i = 0; i < 10000000; i++)
            {
                lock (lockObj2)
                {
                    counter++;
                }
            }
            thread3Running = false;
        }
    }
}
