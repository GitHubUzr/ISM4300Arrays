/*
 * This C# Console application code is meant to
 * execute an array that is of the size 25 elements
 * and display each element number in a loop.
 * It displays the element numbers in a
 * two-dimensional array.
 */

using System;

namespace ISM4300Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] my_array = new int[25];
                int fill_array = 0;
                int show = 1;

                foreach (int i in my_array)
                {
                    my_array[i] = fill_array;
                    Console.WriteLine("Element Value = " + show);
                    show += 1;
                }

                Console.WriteLine("\nArrays can also be two-dimensional\n");

                int[,] two_dimension_array = new int[5, 5];
                int count = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        count += 1;
                        two_dimension_array[i, j] = count;
                        Console.Write(two_dimension_array[i, j] + " ");
                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }

            } //end of try
            catch
            {
                Console.WriteLine("Something went wrong");
            } //end of catch
         
        }
    }
}
