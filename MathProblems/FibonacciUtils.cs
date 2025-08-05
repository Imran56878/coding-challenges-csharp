using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.MathProblems
{
    public class FibonacciUtils
    {

        // Iterative method to print Fibonacci series up to n terms
        public static void PrintFibonacciIterative(int n)
        {
            int a = 0, b = 1;
            Console.Write("Iterative: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

       
        public static void PrintFibonacciRecursive(int n)
        {
            Console.Write("Recursive: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(GetFibonacciRecursive(i) + " ");
            }
            Console.WriteLine();
        }

        // Recursive method to get the nth Fibonacci number
        public static int GetFibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
        }

    }
}
