/*
    Many businesses need to convert data from one format to another.  In this case, data
    is streamed in sequence, but the data needs to be represented as a two-dimensional
    array.  The idea is to convert the sequential data (vector) into a table (matrix),
    along the lines of a spreadsheet.

    Assume that a previous programmer wrote this code, but before debugging and delivering
    it, was transferred to a new department.  Your task to finish the work.  The code is
    almost correct, but compilation (syntax), coding (specification), or output (semantic)
    bugs exist.

    Carefully study the code, determine the problem, and fix the bug or bugs so that the
    output is as expected.  Change as little code as possible to correct the problem.
    Place a comment on or before the fixed lines explaining what is wrong and how the fix
    resolves the issue--no comment(s), no points.

namespace FFTB05
{
    class driver
    {
        // create a matrix with row size of 'width' from the data in 'vector'
        // pad any empty (uninitialized) elements with -1
        static int[,] Transform(int width, int[] vector)
        {
            int rows = Math.Ceiling(vector.Length / width);
            int[,] matrix = new int[rows, width];
            int row = 0;
            int col = 0;
            foreach (int n in vector)
            {
                matrix[row, col] = n;
                if (++col == width)
                {
                    ++row;
                    col = 0;
                }
            }
            int pad = rows * width - vector.Length;
            for (int i = 0; i < pad; ++i)
                matrix[row, col + i] = -1;
            return matrix;
        }

        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[,] table = Transform(3, data);
            Console.WriteLine("the new data in the table should be: ");
            Console.WriteLine("1 2 3\n4 5 6\n7 8 9\n10 -1 -1\n");
            Console.WriteLine("the new data in a table is:");
            for (int r = 0; r < table.GetLength(0); ++r)
            {
                for (int c = 0; c < table.GetLength(1); ++c)
                    Console.Write(table[c, r] + " ");
                Console.WriteLine();
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//added for personal prefrence.

namespace DeBuggin
{
    public class DataConvert//making class public
    {
        // create a matrix with row size of 'width' from the data in 'vector'
        // pad any empty (uninitialized) elements with -1
        static int[,] Transform(int width, int[] vector)
        {
            /* Math.Ceiling() accepts double data type
             First convert vector.length and width to double 
             to store the result in (int rows) then convert the result from double to int 
            */


            //int rows = Math.Ceiling(vector.Length / width);
            int rows = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(vector.Length) 
                        / Convert.ToDouble(width)));
            int[,] matrix = new int[rows, width];
            int row = 0;
            int col = 0;
            foreach (int n in vector)
            {
                matrix[row, col] = n;
                if (++col == width)
                {
                    ++row;
                    col = 0;
                }
            }
            int pad = rows * width - vector.Length;
            for (int i = 0; i < pad; ++i)
                matrix[row, col + i] = -1;
            return matrix;
        }

       public static void Main(string[] args)//making the void Main Public
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[,] table = Transform(3, data);
            WriteLine("the new data in the table should be: ");
            WriteLine("1 2 3\n4 5 6\n7 8 9\n10 -1 -1\n");
            WriteLine("the new data in a table is:");
            for (int r = 0; r < table.GetLength(0); ++r)
            {
                for (int c = 0; c < table.GetLength(1); ++c)
                    //should be table[r,c]
                    Write(table[r, c] + " ");
                WriteLine();
            }
        }
    }
}
