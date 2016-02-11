using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Complex
    {
        public int a, b;
        public Complex()
        {
            a = 0;
            b = 1;
        }
        public Complex(int first,int second)
        {
            a = first;
            b = second;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex g = new Complex();
            Complex v = new Complex(7, 8);
            Console.WriteLine(v.a+" "+v.b);
            Console.ReadKey();
        }
    }

}
