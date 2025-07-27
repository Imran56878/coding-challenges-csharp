using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    public class PalindromeUtility
    {
        public static bool IsPalindrome(string input)
        {
            int left = 0,right= input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
