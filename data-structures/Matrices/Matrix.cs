using System;
using System.Collections.Generic;

namespace Matrices
{
    class Matrix
    {
        //field(s)
        //how will we store the data of this matrix
        int[,] _matrix;
        int _matrixHeight;
        int _matrixWidth;


        // methods
        // 1. some way to fill in the data
        // 2. some common matrix operations (addition, subtraction, multiplication, transpose) 

        public void CreateMatrix1(int a, int b, string[] c){
            int _matrixHeight = a;
            int _matrixWidth = b;
            string[] _matrix = c;

            // take the width, count that many values, set those values as the first level of the array of array
            // you do this for every each height

            for (int i = 0; i < _matrixHeight; i++)
            {
                
            }

            for (int i = 0; i < _matrixWidth; i++)
            {
                
            }

            string[,] fullMatrix1 = new string[_matrixHeight, _matrixWidth];

            for (int i = 0; i < _matrixHeight; i++)
            {
                for (int j = 0; j < _matrixWidth; j++)
                {
                    //_matrix[]
                }
            }

        }
        public void CheckMatrix1()
        {

        }
        public void UseMatrix1()
        {

        }
        public void CreateMatrix2(int a, int b, string[] c){
            int _matrixHeight = a;
            int _matrixWidth = b;
            string[] _matrix = c;
            //string[][] fullMatrix2 = new string[a,b];
            
        }
        public void CheckMatrix2()
        {

        }
        public void UseMatrix2()
        {

        }

        public void CheckMatrixSizes()
        {

        }

        public void AddMatrix(){

        }

        public void SubtractMatrix(){

        }

        public void MultiplyMatrix(){

        }
        public void TransposeMatrix(){

        }
        public void ReturnFinalAnswer(string[][] a, string[][] b){

        }
    }
}