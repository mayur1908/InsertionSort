using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Program
    {
        static void InsertionSort(string[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                string key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key, to one position ahead of their current position
                while (j >= 0 && string.Compare(arr[j], key, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            // Read the list of words
            Console.WriteLine("Enter the words (separated by spaces):");
            string input = Console.ReadLine();

            // Split the input into an array of words
            string[] words = input.Split(' ');

            // Perform insertion sort
            InsertionSort(words);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
