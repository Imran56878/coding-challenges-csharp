using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    internal class LongestCommonPrefix
    {
        public static string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            return prefix;

        }
    }
}
