using NumberWrapperTest;
using System;
using System.Diagnostics;

namespace MemoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            if (true)
            {
                var l = new StructDouble[1000000000];
                for (var i = 0; i < 1000000000; i++)
                {
                    l[i] = new StructDouble(i);
                }
            }
            else
            {
                var l = new double[1000000000];
                for (var i = 0; i < 1000000000; i++)
                {
                    l[i] = i;
                }
            }

            Console.WriteLine("End");
            Process proc = Process.GetCurrentProcess();
            Console.WriteLine(proc.PrivateMemorySize64);
            Console.ReadKey();
        }
    }
}
