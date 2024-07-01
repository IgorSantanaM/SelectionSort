using System;

public class SelectionSortTest
{
    public static void Main(string[] args)
    {
        SelectionSort sortArray = new SelectionSort(10);

        Console.WriteLine("Unsorted array:");
        Console.WriteLine(sortArray); // display unsorted array

        sortArray.Sort(); 

        Console.WriteLine("Sorted array:");
        Console.WriteLine(sortArray);
    }
} 
