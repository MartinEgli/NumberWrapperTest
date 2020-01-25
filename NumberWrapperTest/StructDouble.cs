using System;

namespace NumberWrapperTest
{
    public readonly struct StructDouble
    {
        public StructDouble(double d)
        {
            Value = d;
        }

        public static StructDouble operator +(StructDouble a)
        {
            return a;
        }

        public static StructDouble operator -(StructDouble a)
        {
            return new StructDouble(-a.Value);
        }

        public static StructDouble operator +(StructDouble a, StructDouble b)
        {
            return new StructDouble(a.Value + b.Value);
        }

        public static StructDouble operator -(StructDouble a, StructDouble b)
        {
            return a + -b;
        }

        public static StructDouble operator *(StructDouble a, StructDouble b)
        {
            return new StructDouble(a.Value * b.Value);
        }

        public static StructDouble operator /(StructDouble a, StructDouble b)
        {
            if (b.Value == 0) throw new DivideByZeroException();
            return new StructDouble(a.Value / b.Value);
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        public double Value { get; }
    }
}