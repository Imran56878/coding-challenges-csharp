// See https://aka.ms/new-console-template for more information
using CodePractice.ArrayProblems;
using CodePractice.MathProblems;
using CodePractice.StringsProblem;

Console.WriteLine("Select an option:");
Console.WriteLine("1. Reverse a String");
Console.WriteLine("2. Check if a Number is Prime");
Console.WriteLine("3. Calculate Factorial");
Console.WriteLine("4. Count Vowels and Consonants");
Console.WriteLine("5. Second Largest Element");
Console.WriteLine("6. Palindrome Number");
Console.Write("Enter your choice (1-6): ");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Enter a string to reverse:");
        string inputstring = Console.ReadLine();
        string reverseOutput = ReverseString.Reverse(inputstring);
        Console.WriteLine($"input for reveral is : {inputstring} and  reversed Output : {reverseOutput}");
        break;

    case "2":
        Console.WriteLine("Enter a number :");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            bool isPrime = PrimeNumbers.IsPrimeNumber(number);
            Console.WriteLine($"Given number is {number} and isPrime : {isPrime} ");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        break;

    case "3":
        Console.WriteLine("Enter a number :");
        if (int.TryParse(Console.ReadLine(), out int factNumber))
        {
            int factorial = Factorial.NumberFactorial(factNumber);
            Console.WriteLine($"Factorial of {factNumber} is: {factorial}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        break;

    case "4":
        Console.WriteLine("Enter a string");
        string vowelinput = Console.ReadLine();

        (int vowels, int consonants) = VowelConsonantAnalyzer.CountVowelsAndConsonants(vowelinput);
        Console.WriteLine($"Vowels: {vowels} and Consonants: {consonants}");
        break;

    case "5":
        Console.WriteLine("Enter numbers separated by space:");
        string input = Console.ReadLine();
         int [] numbers = input.Split(' ').Select(int.Parse).ToArray();
        if (numbers.Length > 2)
        {
          int secondLargestNumber =  SecondLargestElement.FindSecondLargest(numbers);
            Console.WriteLine($"Second largest element is : {secondLargestNumber}");
        }
        else 
            Console.WriteLine("Please enter at least two numbers.");

        break;

    case "6":
        Console.WriteLine("Enter a number to check if it is a palindrome:");
        string palindromeInput = Console.ReadLine();
        bool isPalindrome = PalindromeUtility.IsPalindrome(palindromeInput.ToLower());
        Console.WriteLine($"The number {palindromeInput} and IsPalindrome: {isPalindrome}");
        break;

    default:
        Console.WriteLine("Invalid choice. Please select between 1 and 4.");
        break;
}
