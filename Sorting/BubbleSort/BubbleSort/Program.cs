using System;

namespace BubbleSort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped ;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                    if (swapped == false)
                        return;
                }
            }

        static void PrintArray(int[] arr)
        {
            foreach(int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 1, 0, 12, 4, 9 };
            Console.WriteLine("Unsorted array");

            PrintArray(arr);
            BubbleSort(arr);

            Console.WriteLine("Sorted array");
            PrintArray(arr);

        }
    }
}

