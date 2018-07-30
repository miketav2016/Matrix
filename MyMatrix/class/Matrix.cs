using System;
namespace MyMatrix
{
    public class Matrix
    {
        public readonly int n;
        public readonly int m;
        public double[,] Mat;
        Random rand = new Random((int)DateTime.Now.Ticks);// take not equal queue
        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            this.Mat = new double[n, m];
          
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    this.Mat[i, j] = Convert.ToDouble(rand.Next(10000)) / 100;
                }
        }
        public void OutputM()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Mat[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
        /*
         public static возвращаемый_тип operator оператор(параметры)
            {  }
        */
        public static Matrix operator +(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.m; j++)
                {
                    a.Mat[i, j] += b.Mat[i, j];
                }
            }
            return a;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.m; j++)
                {
                    a.Mat[i, j] -= b.Mat[i, j];
                }
            }
            return a;
        }
    }
}