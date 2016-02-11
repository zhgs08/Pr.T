using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(); // считывание массива строк 
            foreach(string s in v)                  // пробег по всем строкам v 
            {
                int cnt=0;
                int jk = Convert.ToInt32(s);       // конвертирование строки в целое число 
                for(int i=1; i<=jk; i++)          // проверка на простоту числа 
                {
                    if (jk % i == 0)
                        cnt++;
                }
                if (cnt == 2)
                    Console.WriteLine(jk);
            }
            Console.ReadKey();
        }
    }
}
