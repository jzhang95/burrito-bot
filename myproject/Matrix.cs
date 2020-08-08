using System;

namespace MatrixType
{
    class Matrix
    {
        Random rng = new Random();
        
        public int[,] mat
        { get; set; }


        public Matrix(int rows, int columns)
        {
            this.mat = new int[rows, columns];

            for(int i = 0; i < this.mat.GetLength(0); i++)
            {
                for(int j = 0 ; j < this.mat.GetLength(1); j++)
                {
                    this.mat[i,j] = rng.Next(1,10);

                }
            }
        }

        public Matrix(int[,] matrix)
        {
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

        public Matrix dotProduct(Matrix mat2)
        {
            int[,] result = new int[this.mat.GetLength(0), mat2.mat.GetLength(1)];
            int[] curRow;
            int[] curCol;

            for(int i = 0; i < this.mat.GetLength(0); i++)
            {
                curRow = dpGetRows(i);
                for(int j = 0; j < mat2.mat.GetLength(1); j++)
                {
                    curCol = dpGetCols(j, mat2);
                    result[i,j] = calcProduct(curRow, curCol);
                }
            }
            
            return new Matrix(result);
        }

        public int calcProduct(int[] row, int[] col)
        {
            int result = 0;

            for(int i = 0; i < row.Length; i++)
            {
                result += row[i] * col[i];
            }

            return result;
        }

        public int[] dpGetRows(int rowNum)
        {
            int[] result = new int[this.mat.GetLength(1)];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = this.mat[rowNum, i];
            }
            return result;
        }

        public int[] dpGetCols(int colNum, Matrix mat2)
        {
            int[] result = new int[mat2.mat.GetLength(0)];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = mat2.mat[i, colNum];
            }
            return result;
        }
    }
}