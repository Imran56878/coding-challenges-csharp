// See https://aka.ms/new-console-template for more information
using CodePractice;
using CodePractice.StringsProblem;

/*Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter the string data to get a reversal Output");
string inputstring = Console.ReadLine();
string reverseOutput = ReverseString.Reverse(inputstring);
Console.WriteLine($"input for reveral is : {inputstring} and  reversed Output : {reverseOutput}");
*/
/*Console.WriteLine("Enter a number :");
if (int.TryParse(Console.ReadLine(), out int number))
{
    bool isPrime = PrimeNumbers.IsPrimeNumber(number);
    Console.WriteLine($"Given number is {number} and isPrime : {isPrime} ");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}*/

/*Console.WriteLine("Enter a number :");
if (int.TryParse(Console.ReadLine(), out int number))
{
    int factorial = Factorial.NumberFactorial(number);
    Console.WriteLine($"Given number is {number} and factorial : {factorial} ");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}*/


Console.WriteLine("Enter a string");
string input = Console.ReadLine();

(int vowels, int consonants) = VowelConsonantAnalyzer.CountVowelsAndConsonants(input);
Console.WriteLine($"Vowels: {vowels} and Consonants: {consonants}");
