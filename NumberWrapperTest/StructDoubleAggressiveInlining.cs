using System;
using System.Runtime.CompilerServices;

namespace NumberWrapperTest
{

    public readonly struct StructBooleanAggressiveInlining
    {
        public StructBooleanAggressiveInlining(bool b)
        {
            Value = b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructBooleanAggressiveInlining operator &(StructBooleanAggressiveInlining a, StructBooleanAggressiveInlining b)
        {
            return new StructBooleanAggressiveInlining(a.Value & b.Value);
        }
        public bool Value { get; }

    }

    public readonly struct ReadonlyStructDoubleAggressiveInlining
    {
        public ReadonlyStructDoubleAggressiveInlining(double d)
        {
            Value = d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyStructDoubleAggressiveInlining operator +(ReadonlyStructDoubleAggressiveInlining a)
        {
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyStructDoubleAggressiveInlining operator -(ReadonlyStructDoubleAggressiveInlining a)
        {
            return new ReadonlyStructDoubleAggressiveInlining(-a.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyStructDoubleAggressiveInlining operator +(ReadonlyStructDoubleAggressiveInlining a, ReadonlyStructDoubleAggressiveInlining b)
        {
            return new ReadonlyStructDoubleAggressiveInlining(a.Value + b.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyStructDoubleAggressiveInlining operator -(ReadonlyStructDoubleAggressiveInlining a, ReadonlyStructDoubleAggressiveInlining b)
        {
            return a + -b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyStructDoubleAggressiveInlining operator *(ReadonlyStructDoubleAggressiveInlining a, ReadonlyStructDoubleAggressiveInlining b)
        {
            return new ReadonlyStructDoubleAggressiveInlining(a.Value * b.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReadonlyStructDoubleAggressiveInlining operator /(ReadonlyStructDoubleAggressiveInlining a, ReadonlyStructDoubleAggressiveInlining b)
        {
            if (b.Value == 0) throw new DivideByZeroException();
            return new ReadonlyStructDoubleAggressiveInlining(a.Value / b.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return $"{Value}";
        }

        public double Value { get; }
    }

    public readonly struct StructDoubleAggressiveInlining
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StructDoubleAggressiveInlining(double d)
        {
            Value = d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double(StructDoubleAggressiveInlining input)
        {
            return input.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructDoubleAggressiveInlining operator +(StructDoubleAggressiveInlining a)
        {
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructDoubleAggressiveInlining operator -(StructDoubleAggressiveInlining a)
        {
            return new StructDoubleAggressiveInlining(-a.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructDoubleAggressiveInlining operator +(StructDoubleAggressiveInlining a, StructDoubleAggressiveInlining b)
        {
            return new StructDoubleAggressiveInlining(a.Value + b.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructDoubleAggressiveInlining operator -(StructDoubleAggressiveInlining a, StructDoubleAggressiveInlining b)
        {
            return a + -b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructDoubleAggressiveInlining operator *(StructDoubleAggressiveInlining a, StructDoubleAggressiveInlining b)
        {
            return new StructDoubleAggressiveInlining(a.Value * b.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StructDoubleAggressiveInlining operator /(StructDoubleAggressiveInlining a, StructDoubleAggressiveInlining b)
        {
            if (b.Value == 0) throw new DivideByZeroException();
            return new StructDoubleAggressiveInlining(a.Value / b.Value);
        }

        public override string ToString()
        {
            return $"{Value}";
        }

        public double Value { get; }
    }
}