using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    internal class NonRepeatingChar
    {
        public static char FirstNonRepeatingCharecter(string word)
        {


            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var item in word)
            {

                charCount[item]= charCount.ContainsKey(item) ? charCount[item] + 1 : 1;
            }
            foreach (var item in charCount)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return '\0';
        }
    }
}
