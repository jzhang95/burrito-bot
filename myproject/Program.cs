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
        }
    }
}
