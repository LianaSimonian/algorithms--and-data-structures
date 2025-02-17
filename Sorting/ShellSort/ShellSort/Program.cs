using System;

namespace ShellSort
{
    internal class Program
    {
        static void ShellSort(int[]arr)
        {
            int n = arr.Length;
            for(int gap = n/2;gap>0;gap/=2)
            {
                for(int i = gap;i<n;i++)
                {
                    int key = arr[i];
                    int j = i;
                    while (j-gap>=0 && arr[j-gap]>key)
                    {
                        arr[j] = arr[j - gap];
                       // arr[j - gap] = key;
                        j -= gap;
                    }
                    arr[j] = key;
                }

            }

        }

        static void PrintArray(int[] arr)
        {
            foreach(var num in arr)
                Console.Write(num + " " );
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 54, 2, 3, 11, 25 };

            Console.WriteLine("Original Array:");
            PrintArray(arr);
            ShellSort(arr);
            Console.WriteLine("Sorted Array:");
            PrintArray(arr);
        }
    }
}
