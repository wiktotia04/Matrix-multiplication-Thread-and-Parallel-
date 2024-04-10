using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Matrix
    {
        int rows = 5;
        int cols = 5;

        internal double[,] GenereateMatix(int rows, int cols)
        {
            Random random = new Random();
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = random.Next(0, 10);
            return matrix;
        }

        
    }
}
