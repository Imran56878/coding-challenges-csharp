using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.ArrayProblems
{
    public class DuplicateFinder
    {
        public static List<int> FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();
            foreach (int num in arr)
            {
                if (seen.Contains(num))
                {
                    if (!duplicates.Contains(num)) // To avoid adding the same duplicate multiple times
                    {
                        duplicates.Add(num);
                    }
                }
                else
                {
                    seen.Add(num);
                }
            }
            return duplicates;
        }
    }
}
