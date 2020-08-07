using System;

namespace MatrixType
{
    class Matrix
    {
    
         public int columns
        { get; set; }

        public int rows 
        { get; set; }
        
        public int[,] mat
        { get; set; }

        public Matrix(int[,] matrix)
        {
            this.rows = matrix.GetLength(0);
            this.columns = matrix.GetLength(1);
            this.mat = matrix;
        }

    
        public void printMatrix()
        {
            for(int i = 0; i < this.mat.GetLength(0); i++)
            {
                for(int j = 0; j < this.mat.GetLength(1); j++)
                {
                    Console.Write("["+mat[i,j]+"]");
                }
                Console.WriteLine("");
            }
        }
    }
}