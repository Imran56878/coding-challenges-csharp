using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.MathProblems
{
    public class PrimeNumbers
    {


        public static bool IsPrimeNumber(int Number)
        {

            if (Number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt( Number); i++)
            {
                if (Number % i == 0)
                {
                    return  false;
                }
            }

            return true;

        }

        public static List<int> CheckAllPrime(int[] Numbers)
        {
            List<int> primeNumbers   = new List<int>();

            foreach (int number in Numbers)
            {

               bool IsPrime = IsPrimeNumber(number);
                if (IsPrime)
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }
    }
}
