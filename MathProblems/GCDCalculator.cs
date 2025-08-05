using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.MathProblems
{
    public class GCDCalculator
    {

        public static int CalculateGCD(int a, int b)
        {             // Using Euclidean algorithm to find GCD
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
