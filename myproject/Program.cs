using System;
using MatrixType;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random random = new Random();
            int rng = random.Next(-10, 10);

            int[,] array = new int[,]{ { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            Matrix matrix = new Matrix(array);
            Console.WriteLine("Matrix A");
            matrix.printMatrix();

            Matrix rngMat = new Matrix(2,4);
            Console.WriteLine("Matrix B");
            rngMat.printMatrix();
            
            Matrix rngMat2 = new Matrix(4,2);
            Console.WriteLine("Matrix C");
            rngMat.printMatrix();

            Matrix productMat = matrix.dotProduct(rngMat);
            Console.WriteLine("Matrix A x Matrix B");
            productMat.printMatrix();

            Matrix sumMat = matrix.matSum(rngMat2);
            Console.WriteLine("Matrix A + Matrix B");
            sumMat.printMatrix();

            Matrix minusMat = matrix.matSubtract(rngMat2);
            Console.WriteLine("Matrix A - Matrix B");
            minusMat.printMatrix();

            Matrix scaleMat = matrix.matScale(rng);
            Console.WriteLine("Matrix A * "+rng);
            scaleMat.printMatrix();
        }   
    }
}
