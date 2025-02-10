
using System;

namespace SelectionSort
{
    internal class Program
    {
      static void selectionSort(int[] arr)
        {
            int n = arr.Length;

            for(int  i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for(int  j =i+1;j<n;j++)
                    if(arr[j] < arr[minIndex])
                        minIndex = j;

                if(i!=minIndex)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }

        }

        static void printArray(int[] arr)
        {
            foreach(int val in arr)
                Console.Write(val + " ");
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 12, 212, 11,11 };

            Console.Write("Original array: ");
            printArray(arr);

            selectionSort(arr);

            Console.Write("Sorted array: ");
            printArray(arr);
        }
    }
}
