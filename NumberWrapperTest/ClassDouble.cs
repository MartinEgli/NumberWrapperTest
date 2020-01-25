using System;

namespace NumberWrapperTest
{
    public class ClassDouble
    {
        public ClassDouble(double d)
        {
            Value = d;
        }

        public double Value { get; }

        public static ClassDouble operator +(ClassDouble a)
        {
            return a;
        }

        public static ClassDouble operator -(ClassDouble a)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            return new ClassDouble(-a.Value);
        }

        public static ClassDouble operator +(ClassDouble a, ClassDouble b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));
            return new ClassDouble(a.Value + b.Value);
        }

        public static ClassDouble operator -(ClassDouble a, ClassDouble b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));
            return new ClassDouble(a.Value - b.Value);
        }

        public static ClassDouble operator *(ClassDouble a, ClassDouble b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));
            return new ClassDouble(a.Value * b.Value);
        }

        public static ClassDouble operator /(ClassDouble a, ClassDouble b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));
            if (b.Value == 0) throw new DivideByZeroException();
            return new ClassDouble(a.Value / b.Value);
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}