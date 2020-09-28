using System;

namespace NumberWrapperTest
{

    public readonly struct StructBoolean
    {
        public StructBoolean(bool b)
        {
            Value = b;
        }

        public static StructBoolean operator &(StructBoolean a, StructBoolean b)
        {
            return new StructBoolean(a.Value & b.Value);
        }
        public bool Value { get; }

    }

    public readonly struct ReadonlyStructDouble
    {
        public ReadonlyStructDouble(double d)
        {
            Value = d;
        }

        public static ReadonlyStructDouble operator +(ReadonlyStructDouble a)
        {
            return a;
        }

        public static ReadonlyStructDouble operator -(ReadonlyStructDouble a)
        {
            return new ReadonlyStructDouble(-a.Value);
        }

        public static ReadonlyStructDouble operator +(ReadonlyStructDouble a, ReadonlyStructDouble b)
        {
            return new ReadonlyStructDouble(a.Value + b.Value);
        }

        public static ReadonlyStructDouble operator -(ReadonlyStructDouble a, ReadonlyStructDouble b)
        {
            return a + -b;
        }

        public static ReadonlyStructDouble operator *(ReadonlyStructDouble a, ReadonlyStructDouble b)
        {
            return new ReadonlyStructDouble(a.Value * b.Value);
        }

        public static ReadonlyStructDouble operator /(ReadonlyStructDouble a, ReadonlyStructDouble b)
        {
            if (b.Value == 0) throw new DivideByZeroException();
            return new ReadonlyStructDouble(a.Value / b.Value);
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        public double Value { get; }
    }

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