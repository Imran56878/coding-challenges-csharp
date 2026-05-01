// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;
using CodePractice.ArrayProblems;
using CodePractice.MathProblems;
using CodePractice.SortingAlgorithms;
using CodePractice.StringsProblem;

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

static bool TryReadInt(string message, out int value)
{
    value = 0;
    var s = Prompt(message);
    if (s is null) return false;
    if (int.TryParse(s, out value)) return true;
    Console.WriteLine($"'{s}' is not a valid integer.");
    return false;
}

static bool TryReadIntList(string message, out int[] values, int minCount = 1)
{
    values = Array.Empty<int>();
    var s = Prompt(message);
    if (s is null) return false;
    var tokens = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (tokens.Length < minCount)
    {
        Console.WriteLine($"Please enter at least {minCount} integer(s) separated by space.");
        return false;
    }
    var list = new List<int>(tokens.Length);
    foreach (var t in tokens)
    {
        if (!int.TryParse(t, out int v))
        {
            Console.WriteLine($"Could not parse '{t}' as an integer. Please provide only integers separated by space.");
            return false;
        }
        list.Add(v);
    }
    values = list.ToArray();
    return true;
}

static bool TryReadTwoInts(string message, out int a, out int b)
{
    a = b = 0;
    if (!TryReadIntList(message, out var arr, minCount: 2)) return false;
    if (arr.Length != 2)
    {
        Console.WriteLine("Please enter exactly two integers separated by space.");
        return false;
    }
    a = arr[0];
    b = arr[1];
    return true;
}

// Use centralized prompt for the menu choice
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
            if (!TryReadInt("Enter a number: ", out int number)) break;
            bool isPrime = PrimeNumbers.IsPrimeNumber(number);
            Console.WriteLine($"Given number is {number} and isPrime : {isPrime}");
            break;
        }

    case "3":
        {
            if (!TryReadInt("Enter a number: ", out int factNumber)) break;
            int factorial = Factorial.NumberFactorial(factNumber);
            Console.WriteLine($"Factorial of {factNumber} is: {factorial}");
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
            if (!TryReadIntList("Enter numbers separated by space: ", out int[] numbers, minCount: 2)) break;
            int secondLargestNumber = SecondLargestElement.FindSecondLargest(numbers);
            Console.WriteLine($"Second largest element is : {secondLargestNumber}");
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
            if (!TryReadInt("Enter the number of terms for Fibonacci series: ", out int n)) break;
            FibonacciUtils.PrintFibonacciIterative(n);
            FibonacciUtils.PrintFibonacciRecursive(n);
            break;
        }

    case "8":
        {
            if (!TryReadIntList("Enter numbers separated by space to Sort using Bubble: ", out int[] arraysort, minCount: 1)) break;
            BubbleSort.Sort(arraysort);
            break;
        }

    case "9":
        {
            if (!TryReadIntList("Enter numbers separated by space to find duplicates: ", out int[] duplicateArray, minCount: 1)) break;
            var response = DuplicateFinder.FindDuplicates(duplicateArray);
            foreach (var item in response)
            {
                Console.WriteLine($"Duplicate number: {item}");
            }
            break;
        }

    case "10":
        {
            if (!TryReadTwoInts("Enter two numbers to get the GCD (separated by space): ", out int a, out int b)) break;
            int gcd = GCDCalculator.CalculateGCD(a, b);
            Console.WriteLine($"GCD of {a} and {b} is: {gcd}");
            break;
        }

    case "11":
        {
            if (!TryReadTwoInts("Enter two numbers to Number Swap (separated by space): ", out int firstValue, out int secondValue)) break;
            SwapNumbers.SwapWithoutTemp(firstValue, secondValue);
            Console.WriteLine("Exiting the program.");
            break;
        }

    default:
        Console.WriteLine("Invalid choice. Please select between 1 and 11.");
        break;
}