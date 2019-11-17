using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"The values for {typeof(byte).Name} are {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The values for {typeof(sbyte).Name} are {sbyte.MinValue} and {sbyte.MaxValue}");
            Console.WriteLine($"The values for {typeof(short).Name} are {short.MinValue} and {short.MaxValue}");
            Console.WriteLine($"The values for {typeof(ushort).Name} are {ushort.MinValue} and {ushort.MaxValue}");
            Console.WriteLine($"The values for {typeof(int).Name} are {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The values for {typeof(uint).Name} are {uint.MinValue} and {uint.MaxValue}");
            Console.WriteLine($"The values for {typeof(long).Name} are {long.MinValue} and {long.MaxValue}");
            Console.WriteLine($"The values for {typeof(ulong).Name} are {ulong.MinValue} and {ulong.MaxValue}");
            Console.WriteLine($"The values for {typeof(float).Name} are {float.MinValue} and {float.MaxValue}. Epsilon is {float.Epsilon} Size is {sizeof(float)}");
            Console.WriteLine($"The values for {typeof(double).Name} are {double.MinValue} and {double.MaxValue}. Epsilon is {double.Epsilon} Size is { sizeof(double)}");
            Console.WriteLine($"The values for {typeof(decimal).Name} are {decimal.MinValue} and {decimal.MaxValue} Size is {sizeof(decimal)}");

            Console.ReadLine();

        }
    }
}
