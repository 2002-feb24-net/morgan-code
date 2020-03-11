using System;
using System.Collections.Generic;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix compute = new Matrix();

            //getting the size of the matrix (width x height)
            System.Console.WriteLine("Please enter a size for the FIRST matrix");
            System.Console.Write("Matrix 1 Width: ");
            int matrixWidth1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Matrix 1 Height: ");
            int matrixHeight1 = Convert.ToInt32(Console.ReadLine());
            //here in the Program class you can write code to test out your Matrix class

            System.Console.WriteLine("Write the values of your FIRST matrix from left to right, top to bottom, separated by a space. (Total values should be height x width)");
            string[] fullMatrix1 = System.Console.ReadLine().Split(" ");
            compute.CheckMatrix1();
            System.Console.WriteLine("Is this FIRST matrix correct? (y/n)");

            System.Console.WriteLine("Please enter a size for the SECOND matrix");
            System.Console.Write("Matrix 2 Width: ");
            int matrixWidth2 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Matrix 2 Height: ");
            int matrixHeight2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Write the values of your SECOND matrix from left to right, top to bottom, separated by a space");
            string[] fullMatrix2 = System.Console.ReadLine().Split(" ");
            compute.CheckMatrix2();
            System.Console.WriteLine("Is this SECOND matrix correct? (y/n)");

            System.Console.WriteLine("Choose a computation: (add, subtract, multiply, transpose)");
            string whichComputation = System.Console.ReadLine().ToLower();

            if(whichComputation == "add")
            {
                compute.AddMatrix();
            }
            else if(whichComputation == "subtract")
            {
                compute.SubtractMatrix();
            }
            else if(whichComputation == "multiply")
            {
                compute.MultiplyMatrix();
            }
            else if (whichComputation == "transpose")
            {
                compute.TransposeMatrix();
            }
        }
    }
}
