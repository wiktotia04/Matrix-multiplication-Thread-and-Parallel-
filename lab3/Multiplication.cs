using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Multiplication
    {

        private double[,] matrixA;
        private double[,] matrixB;

        public Multiplication(double[,] matrixA, double[,] matrixB)
        {
            this.matrixA = matrixA;
            this.matrixB = matrixB;
        }

        public void Multiply(double[,] matrixC, int n)
        {
            for (int i = 0; i < n; i++)
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
