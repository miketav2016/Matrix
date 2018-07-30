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
            Matrix A = new Matrix(3, 3);
            Matrix B = new Matrix(3, 3);
            A.OutputM();
            B.OutputM();
            A = A + B;
            A.OutputM();

            Console.ReadKey();
        }
    }
}
