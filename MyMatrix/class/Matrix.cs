using System;
namespace MyMatrix
{
    public class Matrix
    {
        public readonly int n;
        public readonly int m;
        public double[,] Mat;
        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
        public void InputM()
        {
            Mat = new double[n,m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Mat[i, j] = rand.Next(1, 1000);
                }
        }
        public void OutputM()
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(Mat[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
        }

    }
}