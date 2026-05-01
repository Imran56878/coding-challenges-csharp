// See https://aka.ms/new-console-template for more information
using CodePractice.ArrayProblems;
using CodePractice.MathProblems;
using CodePractice.SortingAlgorithms;
using CodePractice.StringsProblem;

// Generic prompt helpers to centralize null/empty checks and parsing
static string? Prompt(string message)
{
    Console.Write(message);
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("No input provided. Operation cancelled.");
        return null;
    }
    return input;
}
Console.WriteLine("Select an option:");
Console.WriteLine("1. Reverse a String");
Console.WriteLine("2. Check if a Number is Prime");
Console.WriteLine("3. Calculate Factorial");
Console.WriteLine("4. Count Vowels and Consonants");
Console.WriteLine("5. Second Largest Element");
Console.WriteLine("6. Palindrome Number");
Console.WriteLine("7. Fibonacci Number");
Console.WriteLine("8. Bubble Sort");
Console.WriteLine("9. Duplicate Element in array");
Console.WriteLine("10. GCD of Two numbers");
Console.WriteLine("11.Two number swapping without using third one");

var choice = Prompt("Enter your choice (1-11): ");
if (choice is null) return;


switch (choice)
{
        case "1":
        {
            var s = Prompt("Enter a string to reverse: ");
            if (s is null) break;
            var reverseOutput = ReverseString.Reverse(s);
            Console.WriteLine($"input for reversal is : {s} and  reversed Output : {reverseOutput}");
            break;
        }

        case "2":
        {
            var s = Prompt("Enter a number: ");
            if (s is null) break;
            if (int.TryParse(s, out int number))
            {
                bool isPrime = PrimeNumbers.IsPrimeNumber(number);
                Console.WriteLine($"Given number is {number} and isPrime : {isPrime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            break;
        }

        case "3":
        {


            Console.WriteLine("Enter a number :");
            var s = Prompt("Enter a number: ");
            if (s is null) break;
            if (int.TryParse(s, out int factNumber))
            {
                int factorial = Factorial.NumberFactorial(factNumber);
                Console.WriteLine($"Factorial of {factNumber} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            break;
        }

        case "4":
        {
            var s = Prompt("Enter a string: ");
            if (s is null) break;
            (int vowels, int consonants) = VowelConsonantAnalyzer.CountVowelsAndConsonants(s);
            Console.WriteLine($"Vowels: {vowels} and Consonants: {consonants}");
            break;
        }

        case "5":
        {
            var s = Prompt("Enter numbers separated by space: ");
            if (s is null) break;
            int[] numbers = s.Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length > 2)
            {
                int secondLargestNumber = SecondLargestElement.FindSecondLargest(numbers);
                Console.WriteLine($"Second largest element is : {secondLargestNumber}");
            }
            else
                Console.WriteLine("Please enter at least two numbers.");
            break;
        }

        case "6":
        {
            var s = Prompt("Enter a number to check if it is a palindrome: ");
            if (s is null) break;
            bool isPalindrome = PalindromeUtility.IsPalindrome(s.ToLower());
            Console.WriteLine($"The number {s} and IsPalindrome: {isPalindrome}");
            break;
        }


        case "7":
        {
            var s = Prompt("Enter the number of terms for Fibonacci series: ");
            if (s is null) break;
            if (int.TryParse(s, out int n))
            {
                FibonacciUtils.PrintFibonacciIterative(n);
                FibonacciUtils.PrintFibonacciRecursive(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            break;
        }

        case "8":
        {
            var s = Prompt("Enter numbers separated by space to Sort using Bubble: ");
            if (s is null) break;
            int[] arraysort = Array.ConvertAll(s.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            BubbleSort.Sort(arraysort);
            break;
        }

        case "9":
        {
            var s = Prompt("Enter numbers separated by space to find duplicates: ");
            if (s is null) break;
            int[] duplicateArray = Array.ConvertAll(s.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            var response = DuplicateFinder.FindDuplicates(duplicateArray);
            foreach (var item in response)
            {
                Console.WriteLine($"Duplicate number: {item}");
            }
            break;
        }

        case "10":
        {
            var s = Prompt("Enter two numbers to get the GCD (separated by space): ");
            if (s is null) break;
            string[] inputs = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (inputs.Length == 2 &&
                int.TryParse(inputs[0], out int a) &&
                int.TryParse(inputs[1], out int b))
            {
                int gcd = GCDCalculator.CalculateGCD(a, b);
                Console.WriteLine($"GCD of {a} and {b} is: {gcd}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter two valid integers separated by space.");
            }
            break;
        }

        case "11":
        {
            var s = Prompt("Enter two numbers to Number Swap (separated by space):");
            if (s is null) break;
            string[] swapArr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (swapArr.Length == 2 &&
                int.TryParse(swapArr[0], out int firstValue) &&
                int.TryParse(swapArr[1], out int secondValue))
            {
                SwapNumbers.SwapWithoutTemp(firstValue, secondValue);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter two valid integers separated by space.");
            }
            Console.WriteLine("Exiting the program.");
            break;
        }

        default:
            Console.WriteLine("Invalid choice. Please select between 1 and 11.");
            break;
}
