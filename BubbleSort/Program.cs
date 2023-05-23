using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        // Method to perform Bubble Sort on an array of integers
        static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compare adjacent elements and swap if the order is incorrect
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements: ");
            int count = int.Parse(Console.ReadLine());

            int[] arr = new int[count];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Sort(arr);  // Call the Sort method to sort the array

            Console.WriteLine("Sorted List:");

            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
