using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.MathProblems
{
    public class SwapNumbers
    {
        public static void SwapWithoutTemp(int a, int b)
        {
            // suppose given  a = 10; b = 20; expected a =20; b = 10;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            a = a + b; // a becomes 30
            b = a - b; // b becomes 10 (30 - 20)
            a = a - b; // a becomes 20 (30 - 10)
            Console.WriteLine($"After Swap: a = {a}, b = {b}");


        }
    }
}
