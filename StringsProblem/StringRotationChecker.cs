using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    internal class StringRotationChecker
    {
        public static bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            return (s1 + s2).Contains(s2);
        }
    }
}
