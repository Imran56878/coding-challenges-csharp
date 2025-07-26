using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.StringsProblem
{
    public class ReverseString
    {


        public static string Reverse(string name)
        {

            var charArray= name.ToCharArray();
            string reverseString = "";
            int  end = name.Length-1;
            while (end >= 0)
            {

                reverseString += charArray[end--];
            }

            return reverseString;
        }
    }
}
