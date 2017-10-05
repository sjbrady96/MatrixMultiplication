using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Sean Brady
 * 9/22/2017
 * COSC 450 Programming Excercise 1
 * Matrix Multiplication: two 2D arrays of random integers
*/

namespace MatrixMultiplication
{
    public class MatrixMult
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //all of the 2D arrays in this program have a fixed size of 3 rows and 4 columns
            int[,] arrA = new int[3, 4]; 
            int[,] arrB = new int[3, 4]; 

            Console.WriteLine("this program performs matrix multiplication\npress ENTER to begin");
            Console.Read();

            Console.WriteLine("array A:");
            PrintArray(FillArray(arrA));

            Console.WriteLine("\narray B:");
            PrintArray(FillArray(arrB));

            Console.WriteLine("\nproduct of A and B:");
            PrintArray(MultiplyMatrix(arrA, arrB));

            Console.Write("\ntype any key to exit");
            Console.ReadKey();
        }

        //fill a 2D array with random integers
        static public int[,] FillArray(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 11);
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
            int[,] product = new int[3, 4];

            for (int i = 0; i < 3; i++) //array A rows
            {
                for(int j = 0; j < 4; j++) //array B columns
                {
                    product[i, j] = 0;
                    for(int k = 0; k < 3; k++) //array A columns and array B rows
                    {
                        product[i, j] += A[i, k] * B[k, j]; //fill product array
                    }
                }
            }
            return product;
        }
    }
}
