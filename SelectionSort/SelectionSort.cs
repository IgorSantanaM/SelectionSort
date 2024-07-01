using System;

public class SelectionSort
{
    private int[] data; // array of values
    private static Random generator = new Random();

    // create array of given size and fill with random integers
    public SelectionSort(int size)
    {
        data = new int[size]; // create space for array

        // fill array with random ints in range 10-99
        for (int i = 0; i < size; ++i)
            data[i] = generator.Next(10, 100);
    } // end SelectionSort constructor

    // sort array using selection sort
    public void Sort()
    {
        int smallest; // index of smallest element

        // loop over data.Length - 1 elements
        for (int i = 0; i < data.Length - 1; ++i)
        {
            smallest = i; // first index of remaining array

            // loop to find index of smallest element
            for (int index = i + 1; index < data.Length; ++index)
            {
                if (data[index] < data[smallest])
                    smallest = index;
            }

            Swap(i, smallest); // swap smallest element into position
            PrintPass(i + 1, smallest); // output pass of algorithm
        }
    } // end method Sort

    private void Swap(int first, int second)
    {
        int temporary = data[first]; // store first in temporary
        data[first] = data[second]; // replace first with second
        data[second] = temporary; // put temporary in second
    } // end method Swap

    // display a pass of the algorithm
    private void PrintPass(int pass, int index)
    {
        Console.Write($"after pass {pass}: ");

        // output elements through the selected item
        for (int i = 0; i < index; ++i)
            Console.Write($"{data[i]} ");

        Console.Write($"{data[index]}* "); // indicate swap

        // finish outputting array
        for (int i = index + 1; i < data.Length; ++i)
            Console.Write($"{data[i]} ");

        Console.Write("\n "); // for alignment

        // indicate amount of array that is sorted
        for (int j = 0; j < pass; ++j)
            Console.Write("-- ");
        Console.WriteLine("\n"); // skip a line in output
    } // end method PrintPass
    public override string ToString()
    {
        string temporary = string.Empty;

        foreach (var value in data)
            temporary += $"{value} ";

        return temporary.Trim();
    } // end method ToString
}
