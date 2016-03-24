using System;
using System.Diagnostics;

class Assertions
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array is null.");
        Debug.Assert(arr.Length != 0, "The array is empty.");
        Debug.Assert(arr.Length>1,"The array have only with 1 element.");
        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array is null.");
        Debug.Assert(arr.Length != 0, "The array is empty.");
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length,
            "Invalid start index.");
        Debug.Assert(endIndex >= 0 && endIndex < arr.Length,
            "Invalid end index.");
        Debug.Assert(endIndex > startIndex && startIndex != endIndex,
            "End index cannot be smaller or equal to the start index.");
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "The array is null.");
        Debug.Assert(arr.Length != 0, "The array is empty.");
        Debug.Assert(value != null, "Value is null.");
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(startIndex >= 0 && startIndex < arr.Length,
            "Invalid start index.");
        Debug.Assert(endIndex >= 0 && endIndex < arr.Length,
            "Invalid end index.");
        Debug.Assert(endIndex > startIndex && startIndex != endIndex,
            "End index cannot be smaller or equal to the start index.");
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Console.WriteLine("The value was found.");
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        Console.WriteLine("The value wasn't found.");
        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        //int[] nullArr = null;
        //SelectionSort(nullArr); // Test sorting null array
        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null, "X is null.");
        Debug.Assert(y != null, "Y is null.");
        T oldX = x;
        x = y;
        y = oldX;
    }
}
