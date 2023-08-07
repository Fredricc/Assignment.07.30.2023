// C# Program to find maximum in arr[]
using System;

class ArraySum
{

    static int[] arr = { 10, 10324, 45, 90, 9808 };

    // Method to find maximum in arr[]
    static int largest()
    {
        int i;

        // Initialize maximum element
        int max = arr[0];

        // Traverse array elements from second and
        // compare every element with current max
        for (i = 1; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];

        return max;
    }

    // Driver code
    public static void Main()
    {
        Console.WriteLine("Largest in given "
                          + "array is " + largest());
    }
}
