using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.ArrayProblems
{
    public class SecondLargestElement
    {

        public static int FindSecondLargest(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }
            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach (int num in arr)
            {
                if (num > firstLargest)
                {
                    secondLargest = firstLargest;
                    firstLargest = num;
                }
                else if (num > secondLargest && num < firstLargest)
                {
                    secondLargest = num;
                }
            }
            if (secondLargest == int.MinValue)
            {
                throw new InvalidOperationException("There is no second largest element.");
            }
            return secondLargest;
        }
    }
}
