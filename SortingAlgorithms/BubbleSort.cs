using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.SortingAlgorithms
{
    public class BubbleSort
    {

        public static void Sort(int [] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Nothing to sort (array is null or empty).");
                return;
            }
            for (int i = 0; i<arr.Length;i++)
            {

                bool swapped = false;
                // j < arr.Length-i-1 i => aready sorted elements and -1 for camparing next values

                for (int j=0;j<arr.Length-i-1;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                    
                }

                // If no two elements were swapped by inner loop, then break
                if (!swapped)
                {
                    break;
                }
            }
            // Print sorted array so callers (like Program.cs) show result
            Console.WriteLine("Sorted array (Bubble Sort): " + string.Join(' ', arr));
        }
    }
}
