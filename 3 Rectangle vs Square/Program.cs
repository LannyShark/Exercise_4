using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Rectangle_vs_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа А, В и С");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int x, y, z;
            x = y = z = 0;
            while (a > 0)
            {
                a -= c;
                x++;
            }
            while (b > 0)
            {
                b -= c;
                y++;
            }
            for (int i = 0; i < y; i++)
            {
                z += x;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
