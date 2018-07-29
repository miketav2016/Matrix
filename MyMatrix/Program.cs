using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Inpu n m (size matrix)");
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n={n} m={m}");
            Matrix A = new Matrix(n, m);
            A.InputM();
            A.OutputM();
            Console.ReadKey();
        }
    }
}
