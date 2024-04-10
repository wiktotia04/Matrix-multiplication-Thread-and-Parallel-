using System;
using System.Collections.Concurrent;
using System.Threading;

namespace lab3
{
    internal class HighLevel
    {

        public void Multiply(double[,] matrixA, double[,] matrixB, double[,] matrixC, int n, int w)
        {
            ParallelOptions options = new ParallelOptions
            {
                MaxDegreeOfParallelism = w
            };

            Parallel.ForEach(Partitioner.Create(0, n), options, range =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
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
            });
        }


    }
}

