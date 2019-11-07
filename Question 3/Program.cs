using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random numbers
            Random rand = new Random();


            int[,] matrixA = new int[3, 3];

            //Auto populated numbers
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                { matrixA[i, j] = rand.Next(-10, 10); }
            }
            Console.WriteLine("MatrixA: ");
            Display(matrixA);
            Console.WriteLine();
            int[,] matrixB = new int[3, 3];
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                { matrixB[i, j] = rand.Next(-10, 10); }
            }
            Console.WriteLine("MatrixB: ");
            Display(matrixB);
            Console.WriteLine();

            int[,] matrixC = new int[3, 3];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                { matrixC[i, j] = matrixA[i, j] + matrixB[i, j]; }
            }
            Console.WriteLine("MatrixC = MatrixA + MatrixB");


            Display(matrixC);
            Console.ReadLine();


        }
        static void Display(int[,] arr)
        //for loop using the GetLength method.
        {
            for (int i = 0; i < arr.GetLength(0); i++)//Row
            {
                for (int j = 0; j < arr.GetLength(1); j++)//Column
                {

                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();

            }
        }
    }
}
