using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Display
    {
        // Display matrix in DataGridView
        public void DisplayMatrix(double[,] matrix, System.Windows.Forms.DataGridView dataGridView)
        {
            dataGridView.ColumnCount = matrix.GetLength(1);
            dataGridView.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }


        
    }
}
