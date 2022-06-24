using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var test = new WordSmith();

            Console.WriteLine(test.IsAPalindrome("racecar"));
        }
    }
}
