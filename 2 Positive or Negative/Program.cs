using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Positive_or_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа");
            int n, pos = 0, neg = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    pos++;
                else
                    neg++;
            } while (n != 0);
            neg--;
            if (pos>neg)
                Console.WriteLine("Положительных больше их {0}",pos);
            else
                Console.WriteLine("Отрицательны больше их {0}", neg);
            Console.ReadKey();
        }
    }
}
