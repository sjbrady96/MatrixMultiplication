using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Matrix Multiplication: two 2D arrays of random size made up of random integers
 * COSC 450 Programming Excercise 1
 * 
 * @author Sean Brady
 * @version 1.1 10/07/2017
 **/

namespace MatrixMultiplication
{
    public class MatrixMult
    {
        static Random rnd = new Random();
        static int iteration = 1;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("PROGRAM ITERATION #" + iteration + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            int rowsA = rnd.Next(1, 11);
            int colsA = rnd.Next(1, 11);

            int rowsB = colsA;
            int colsB = rowsA;

            //inital array sizes
            int[,] arrA = new int[rowsA, colsA]; 
            int[,] arrB = new int[rowsB, colsB]; 

            Console.WriteLine("press ENTER to begin");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("array A (" + rowsA + ", " + colsA + "):");
            PrintArray(FillArray(arrA));

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\narray B (" + rowsB + ", " + colsB + "):");
            PrintArray(FillArray(arrB));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\narray product (" + rowsA + ", " + colsB + "):");
            PrintArray(MultiplyMatrix(arrA, arrB));

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\ntype 'continue' then press ENTER to run the program again\n");
            Console.Read();

            if (Console.ReadLine() == "continue")
            {
                iteration++;
                Console.WriteLine();
                Main(args);
            }
        }

        //fill a 2D array with random integers
        static public int[,] FillArray(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 11);
                }
            }
            return arr;
        }

        //print a 2D array
        static public void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //multiply two 2D arrays together
        static public int[,] MultiplyMatrix(int[,] A, int[,] B)
        {
            int[,] product = new int[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++) //array A rows
            {
                for(int j = 0; j < B.GetLength(1); j++) //array B columns
                {
                    product[i, j] = 0;
                    for(int k = 0; k < A.GetLength(1); k++) //array A columns and array B rows
                    {
                        product[i, j] += A[i, k] * B[k, j]; //fill product array
                    }
                }
            }
            return product;
        }
    }
}