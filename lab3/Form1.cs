using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 1000;
            int w = 6;
            Matrix matrix = new Matrix();
            Lowlevel lowlevel = new Lowlevel();
            double[,] matrixA = matrix.GenereateMatix(n, n);
            double[,] matrixB = matrix.GenereateMatix(n, n);
            double[,] matrixC = new double[n, n];

            Multiplication multiplication = new Multiplication(matrixA, matrixB);

            HighLevel highLevel = new HighLevel();
           
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

           // multiplication.Multiply(matrixC, n);
            //lowlevel.Multiply(matrixA, matrixB, matrixC, n, w);
            highLevel.Multiply(matrixA, matrixB, matrixC, n, w);


            watch.Stop();
            textBox1.Text = watch.ElapsedMilliseconds.ToString();

           /* Display display = new Display();
            display.DisplayMatrix(matrixA, matrixa);
            display.DisplayMatrix(matrixB, matrixb);
            display.DisplayMatrix(matrixC, matrixc);*/

        }

       

    }
}
