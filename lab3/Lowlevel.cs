using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Lowlevel
    {
        public void Multiply(double[,] matrixA, double[,] matrixB, double[,] matrixC, int n, int w)
        {

            Thread[] threads = new Thread[w];
            int rowsPerThread = n / w;

            // Create and start threads
            for (int i = 0; i < w; i++)
            {
                int startRow = i * rowsPerThread;
                int endRow = (i == w - 1) ? n : (i + 1) * rowsPerThread; // Handle the last thread to ensure all rows are covered
                threads[i] = new Thread(() => MultiplyRows(matrixA, matrixB, matrixC, n, startRow, endRow));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }
        private void MultiplyRows(double[,] matrixA, double[,] matrixB, double[,] matrixC, int n, int startRow, int endRow)
        {
            for (int i = startRow; i < endRow; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixC[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
        }
    }
}
