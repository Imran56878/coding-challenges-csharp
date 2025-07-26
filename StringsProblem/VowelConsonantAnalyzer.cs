using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    public class VowelConsonantAnalyzer
    {

        public static (int VowelsCount, int ConsonantCount) CountVowelsAndConsonants(string words)
        {
            int VowelsCount = 0, ConsonantCount = 0;
            HashSet<char> vowels = new HashSet<char>()
            {
                'A','E','I','O','U'
            };
            foreach (char c in words.Replace(" ", "").ToUpper())
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                    {
                        VowelsCount++;
                    }
                    else
                    {
                        ConsonantCount++;
                    }
                }
            }
            return (VowelsCount, ConsonantCount);
        }

    }
}
