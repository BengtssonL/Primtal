using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matteg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv m ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("skriv n ");
            int n = int.Parse(Console.ReadLine());

            List<int> perfectNumbers = new List<int>();
            for (int i = m; i <= n; i++)
            {
                if (IsPerfectNumber(i))
                {
                    perfectNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", perfectNumbers));
            Console.ReadLine();

        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    if (i != number / i)
                    {
                        sum += number / i;
                    }
                }
            }
            return sum == number && number > 1;
        }
    }
}
