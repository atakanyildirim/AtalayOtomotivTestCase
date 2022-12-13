using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altay.Core.Maths
{
    public class PrimeNumber
    {
        public int GetClosestPrimeNumber(int[] numbers)
        {
            int closestLess = default(int);
            int closestMore = default(int);

            int max = numbers.Max();
            if (IsPrime(max))
                return max;
            for(int i = max-1; i< max;i--)
            {
                if(IsPrime(i))
                {
                    closestLess = i;
                    break;
                }
            }
            for (int i = max + 1; i > max; i++)
            {
                if (IsPrime(i))
                {
                    closestMore = i;
                    break;
                }
            }
            return Math.Abs(max - closestLess) < Math.Abs(max - closestMore) ? closestLess : closestMore;
        }

        public bool IsPrime(int number)
        {
            if (number == 1 || number == 0)
                return false;

            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
