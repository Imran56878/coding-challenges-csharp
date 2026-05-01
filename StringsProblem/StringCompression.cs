using System.Text;

namespace CodePractice.StringsProblem
{
    internal class StringCompression
    {
        public static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            StringBuilder compressed = new StringBuilder();
            int count = 1;
            for (int i = 1; i <= input.Length; i++)
            {
                if (i < input.Length && input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    compressed.Append(input[i - 1]);
                    compressed.Append(count);
                    count = 1;
                }
            }
            return compressed.ToString();
        }
    }
}
