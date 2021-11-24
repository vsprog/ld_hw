using System;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat1 = CreateMatrix(2, 3);
            var mat2 = CreateMatrix(3, 2);
            double[,] result = null;

            Print(mat1, "First");
            Print(mat2, "Second");

            try
            {
                result = MultiplyMatrices(mat2, mat1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                        
            Print(result, "Result");

            Console.ReadLine();
        }

        private static double[,] MultiplyMatrices(double[,] matrixA, double[,] matrixB)
        {
            var aRows = matrixA.GetLength(0);
            var aCols = matrixA.GetLength(1);
            var bRows = matrixB.GetLength(0);
            var bCols = matrixB.GetLength(1);

            if (aCols != bRows)
            {
                throw new Exception("The number of columns in the first matrix must be equal to the number of rows in the second matrix");
            }

            double[,] result = new double[aRows, bCols];

            Parallel.For(0, aRows, i =>
            {
                for (var j = 0; j < bCols; j++)
                {
                    for (var k = 0; k < aCols; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            });

            return result;
        }

        private static double[,] CreateMatrix(int rows, int cols)
        {
            var matrix = new double[rows, cols];

            var r = new Random();
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    matrix[i, j] = r.Next(100);
                }
            }

            return matrix;
        }

        private static void Print(double[,] matrix, string name)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            if (rows == 0 && cols == 0) return;

            Console.WriteLine($"{name} matrix: \n");
            
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]:00.##} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
