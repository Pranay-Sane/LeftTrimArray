using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", LeftTrimArray(new int[] { 1, 2, 3, 4, 5 }, 3)));
        }

        static T[] LeftTrimArray<T>(T[] arr, int size)
        {
            T[] result = new T[arr.Length - size];
            for (int i = size, j = 0; i < arr.Length; i++, j++)
            {
                result[j] = arr[i];
            }
            return result;
        }
    }
}
