using System;
using System.Linq;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", LeftTrimArray(new int[] { 1, 2, 3, 4, 5 }, 3)));
        }

        static T[] LeftTrimArray<T>(T[] arr, int size)
        {
            var temp = arr.ToList();
            temp.RemoveRange(0, size);
            return temp.ToArray();
        }
    }
}
