using System;

class AnagramDetection
{
    static bool AreAnagrams(string str1, string str2)
    {
        // Convert the input strings to char arrays
        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();

        // Sort the char arrays in ascending order
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        // Convert the sorted char arrays back to strings
        string sortedStr1 = new string(charArray1);
        string sortedStr2 = new string(charArray2);

        // Compare the sorted strings to check if they are equal
        return sortedStr1.Equals(sortedStr2);
    }

   public static void Main()
    {
        // Get input strings from the user
        Console.WriteLine("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string: ");
        string str2 = Console.ReadLine();

        // Check if the strings are anagrams
        bool areAnagrams = AreAnagrams(str1, str2);

        // Display the result
        if (areAnagrams)
        {
            Console.WriteLine("The two strings are anagrams.");
        }
        else
        {
            Console.WriteLine("The two strings are not anagrams.");
        }
    }
}
