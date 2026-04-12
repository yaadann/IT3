using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class MathOperations
    {
        public static int FindMod(int x, int y)
        {
            return x % y;
        }

        public static bool CheckPrime(int num)
        {
            if (num < 2)
                return false;

            if (num == 2 || num == 3)
                return true;

            if (num % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(num);
            for (int i = 3; i <= limit; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static int ModPow(int a, int b, int mod)
        {
            long result = 1;
            a %= mod;
            
            while (b > 0)
            {
                if ((b & 1) == 1)
                    result = (result * a) % mod;
                a = (a * a) % mod;
                b >>= 1;
            }
            return (int)result;
        }

        public static void ExtendedEuclid(int a, int b, out int x, out int y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return;
            }

            ExtendedEuclid(b, a % b, out int x1, out int y1);
            x = y1;
            y = x1 - (a / b) * y1;
        }
    }
}
