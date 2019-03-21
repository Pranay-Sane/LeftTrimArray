using System;
using System.Linq;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", LeftTrimArray(new int[] { 1, 2, 3, 4, 5 }, 3)));
        }

        static T[] LeftTrimArray<T>(T[] arr, int size)
        {
            return new ArraySegment<T>(arr, size, arr.Length - size).ToArray();
        }
    }
}
