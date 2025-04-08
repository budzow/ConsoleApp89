using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetUser();
            int sum = AddNumbers(5, 10);
            Console.WriteLine($"Sum: {sum}");
            int product = MultiplyNumbers(5, 10);
            Console.WriteLine($"Product: {product}");
            string reversed = ReverseString("Hello");
            Console.WriteLine($"Reversed: {reversed}");
            bool isPalindrome = IsPalindrome("madam");
            Console.WriteLine($"Is Palindrome: {isPalindrome}");
            int factorial = CalculateFactorial(5);
            Console.WriteLine($"Factorial: {factorial}");
        }

        static void GreetUser()
        {
            Console.WriteLine("Hello, User!");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static bool IsPalindrome(string input)
        {
            string reversed = ReverseString(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        static int CalculateFactorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * CalculateFactorial(number - 1);
        }
    }
}
