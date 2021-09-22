using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixDrawer.Draw2x2Matrix(1.01f, 0.00f, 0.00f, 1);
            Console.ReadKey();
        }
    }
}
