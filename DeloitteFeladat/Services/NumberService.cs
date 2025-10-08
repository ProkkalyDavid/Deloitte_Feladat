using DeloitteFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeloitteFeladat.Services
{
    internal class NumberService
    {
        public bool TryParse(string input, out NumberInput number)
        {
            number = null;
            if (int.TryParse(input, out int value) && value >= 10 && value <= 9999)
            {
                number = new NumberInput(value);
                return true;
            }
            return false;
        }

        public void PrintProcessed(NumberInput input)
        {
            int value = input.Number;
            int result = (value % 2 == 0) ? value / 2 : value * 2;
            Console.Write($"{value} - {result}");
            if (IsPrime(value))
                Console.Write(" !prime number");
            Console.WriteLine();
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
                if (n % i == 0) return false;
            return true;
        }
    }
}
