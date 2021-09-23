using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine("addition, multiplikation, rotationsmatris eller rotationsmatris med multiplikation?");
            string val = Console.ReadLine();
            if (val == "addition")
            {
                Console.Clear();
                Console.WriteLine("a?");
                String a00z = Console.ReadLine();
                String a01z = Console.ReadLine();
                String a10z = Console.ReadLine();
                String a11z = Console.ReadLine();
                Console.WriteLine("b?");
                String b00z = Console.ReadLine();
                String b01z = Console.ReadLine();
                String b10z = Console.ReadLine();
                String b11z = Console.ReadLine();
                int a00 = int.Parse(a00z);
                int a01 = int.Parse(a01z);
                int a10 = int.Parse(a10z);
                int a11 = int.Parse(a11z);
                int b00 = int.Parse(b00z);
                int b01 = int.Parse(b01z);
                int b10 = int.Parse(b10z);
                int b11 = int.Parse(b11z);
                Console.WriteLine(a00 + b00);
                Console.WriteLine(a01 + b01);
                Console.WriteLine(a10 + b10);
                Console.WriteLine(a11 + b11);
                Console.ReadKey();
                goto start;
            }
            else if (val == "multiplikation")
            {
                Console.Clear();
                Console.WriteLine("a?");
                String a00q = Console.ReadLine();
                String a01q = Console.ReadLine();
                String a10q = Console.ReadLine();
                String a11q = Console.ReadLine();
                Console.WriteLine("b?");
                String b00q = Console.ReadLine();
                String b01q = Console.ReadLine();
                String b10q = Console.ReadLine();
                String b11q = Console.ReadLine();
                float a00 = int.Parse(a00q);
                float a01 = int.Parse(a01q);
                float a10 = int.Parse(a10q);
                float a11 = int.Parse(a11q);
                float b00 = int.Parse(b00q);
                float b01 = int.Parse(b01q);
                float b10 = int.Parse(b10q);
                float b11 = int.Parse(b11q);
                Console.WriteLine(a00 * b00 + (a01 * b10));
                Console.WriteLine(a00 * b01 + (a01 * b11));
                Console.WriteLine(a10 * b00 + (a11 * b10));
                Console.WriteLine(a10 * b01 + (a11 * b11));
                Console.ReadKey();
                goto start;
            }
            else if (val == "rotationsmatris")
            {
                Console.Clear();
                Console.WriteLine("a?");
                String a00q = Console.ReadLine();
                String a01q = Console.ReadLine();
                String a10q = Console.ReadLine();
                String a11q = Console.ReadLine();
                float a00 = int.Parse(a00q);
                float a01 = int.Parse(a00q);
                float a10 = int.Parse(a00q);
                float a11 = int.Parse(a00q);
                Console.WriteLine(Math.Cos(a00));
                Console.WriteLine(Math.Sin(a01));
                Console.WriteLine(Math.Sin(-a10));
                Console.WriteLine(Math.Cos(a11));
                Console.ReadKey();
                goto start;
            }
            else if (val == "rotationsmatris med multiplikation")
            {
                Console.Clear();
                Console.WriteLine("a?");
                String a00q = Console.ReadLine();
                String a01q = Console.ReadLine();
                String a10q = Console.ReadLine();
                String a11q = Console.ReadLine();
                Console.WriteLine("b?");
                String b00q = Console.ReadLine();
                String b01q = Console.ReadLine();
                String b10q = Console.ReadLine();
                String b11q = Console.ReadLine();
                float a00 = float.Parse(a00q);
                float a01 = float.Parse(a00q);
                float a10 = float.Parse(a00q);
                float a11 = float.Parse(a00q);
                float b00 = float.Parse(a00q);
                float b01 = float.Parse(a00q);
                float b10 = float.Parse(a00q);
                float b11 = float.Parse(a00q);
                float q00 = (float)Math.Cos(a00);
                float q01 = (float)Math.Sin(a01);
                float q10 = (float)Math.Sin(a10);
                float q11 = (float)Math.Cos(a11);
                float p00 = (float)Math.Cos(b00);
                float p01 = (float)Math.Sin(b01);
                float p10 = (float)Math.Sin(b10);
                float p11 = (float)Math.Cos(b11);
                Console.WriteLine(q00 * p00 + (q01 * p10));
                Console.WriteLine(q00 * p01 + (q01 * p11));
                Console.WriteLine(-q10 * -p00 + (q11 * p10));
                Console.WriteLine(q11 * p01 + (q11 * p11));
                Console.ReadKey();
                goto start;
            }
            Console.ReadKey();
        }
    }
}
