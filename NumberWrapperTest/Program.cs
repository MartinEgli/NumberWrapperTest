using System;
using System.Collections;
using System.Collections.Generic;
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


            var b1 = true;
            var b2 = true;
            var b3 = true;

            var loops = 10000000;

            var booleanValues = new List<BitArray>(loops);
            for (var i = 0; i < loops; i++)
            {
                booleanValues.Add(new BitArray(new int[] { i }));
            }

            var booleanStructureValues = new List<List<StructBoolean>>(loops);
            foreach (var booleanValue in booleanValues)
            {
                booleanStructureValues.Add(new List<StructBoolean>(){new StructBoolean(booleanValue[0]), new StructBoolean(booleanValue[1]), new StructBoolean(booleanValue[2])});
            }

            Console.WriteLine("BitArray");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var booleanValue in booleanValues)
            {
                var x = booleanValue[0] & booleanValue[1] & booleanValue[2];
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();


            Console.WriteLine("StructBool Array");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var booleanValue in booleanStructureValues)
            {
                var x = booleanValue[0] & booleanValue[1] & booleanValue[2];
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();


            Console.WriteLine("Simple Bool");
             stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < loops; i++)
            {
                var x =true & true & true;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();


            Console.WriteLine("Struct Bool");
            stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < loops; i++)
            {
                var x = new StructBoolean(true) & new StructBoolean(true) & new StructBoolean(true);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();



            Console.WriteLine("Simple Double");
             stopwatch = new Stopwatch();
             a = 1.11;
             b = 1.22;
             c = 1.33;
            stopwatch.Start();
            for (var i = 0; i < loops; i++)
            {
                var x = a + b + c + i;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();


            Console.WriteLine("Simple Double Verschachtelung");
            stopwatch.Start();
           var layerloops = 500;

            for (var i = 0; i < layerloops; i++)
            {
                var di = (double)i;
                for (var j = 0; j < layerloops; j++)
                {
                    var dj = (double)j;

                    for (var k = 0; k < layerloops; k++)
                    {
                        var dk = (double)k;

                        var x = di + dj + dk;
                    }
                }
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



            Console.WriteLine("Struct Double Verschachtelung");
            stopwatch.Start();

            for (var i = 0; i < layerloops; i++)
            {
                var si = new StructDouble(i);
                for (var j = 0; j < layerloops; j++)
                {
                    var sj = new StructDouble(j);
                    for (var k = 0; k < layerloops; k++)
                    {
                        var sk = new StructDouble(k);
                        var x = si + sj + sk;
                    }
                }
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

            Console.WriteLine("Struct Double with values Verschachtelung");
            stopwatch.Start();

            for (var i = 0; i < layerloops; i++)
            {
                var si = new StructDouble(i);
                for (var j = 0; j < layerloops; j++)
                {
                    var sj = new StructDouble(j);
                    for (var k = 0; k < layerloops; k++)
                    {
                        var sk = new StructDouble(k);
                        var x = new StructDouble( si.Value + sj.Value + sk.Value);
                    }
                }
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