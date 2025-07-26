using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.MathProblems
{
    public class Factorial
    {

        public static int NumberFactorial(int number)
        {

            if (number <= 1)
            {
                return 1;
            }
            return number * NumberFactorial(number - 1);

        }


    }
}
