using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && key < arr[j])
            {
                arr[j + 1] = arr[j];
                //arr[j] = key;
                j--;
            }
            arr[j + 1] = key;

        }
    }
    static void printArray(int[] arr)
    {
        foreach (int num  in arr)
            Console.Write(num +" ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 12, 4, 7, 45 };

        Console.WriteLine("Original array: ");
        printArray(arr);
        Console.WriteLine("Sorted array: ");
        InsertionSort(arr);
        printArray(arr);
    }
    }