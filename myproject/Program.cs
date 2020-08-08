using System;
using MatrixType;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            int[,] array = new int[,]{ { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            Matrix matrix = new Matrix(array);
            matrix.printMatrix();

            Matrix rngMat = new Matrix(2,3);
            rngMat.printMatrix();
            
            Matrix productMat = matrix.dotProduct(rngMat);
            productMat.printMatrix();
        }   
    }
}
