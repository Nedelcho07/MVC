using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVC
{
    class Program
    {
        static void Main(string[] args)
        {
           int MagicNumber= int.Parse(Console.ReadLine());

            int proizv = 1;
            for (int i = 100000; i <= 999999; i++)
            {
                int n = i;
                do
                {
                    proizv = proizv * (n % 10);
                    n = n / 10;
                }
                while (n > 0);
                if (proizv == MagicNumber)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}
