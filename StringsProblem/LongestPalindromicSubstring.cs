using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    internal class LongestPalindromicSubstring
    {
        public static string PalindromSubstring(string s)
        {

            int start = 0, maxLen = 1;

            for (int i = 0; i < s.Length; i++)
            {
                Expand(s, i, i); // odd
                Expand(s, i, i + 1); // even

            }
            void Expand(string s, int left, int right)
            {
                while (left >= 0 && right <=s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > maxLen)
                    {
                        start = left;
                        maxLen = right - left + 1;
                    }
                    left--;
                    right++;
                }
            }

            return s.Substring(start,maxLen);
        }
    }
}
