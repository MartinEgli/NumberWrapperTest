using System;
using System.Diagnostics;

namespace NumberWrapperTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = 1.1;
            var b = 1.2;
            var c = 1.3;

            var loops = 10000000;

            Console.WriteLine("Simple Double");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var x = a + b + c + i;
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.WriteLine("Only create Struct");
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var sx = new StructDouble(1.1);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.WriteLine("Struct Double");
            var sa = new StructDouble(a);
            var sb = new StructDouble(b);
            var sc = new StructDouble(c);
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var sx = sa + sb + sc + new StructDouble(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.WriteLine("Struct Double calc with values");
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var sx = new StructDouble(sa.Value + sb.Value + sc.Value + i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.WriteLine("Only create Class");
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var cx = new ClassDouble(1.1);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.WriteLine("Class Double");
            var ca = new ClassDouble(a);
            var cb = new ClassDouble(b);
            var cc = new ClassDouble(c);
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var cx = ca + cb + cc + new ClassDouble(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.WriteLine("Class Double calc with values");
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var cx = new ClassDouble(ca.Value + cb.Value + cc.Value + i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            Console.ReadKey();
        }
    }
}