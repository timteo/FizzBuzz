using System;
using System.Text;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                sb.AppendLine(print(i));
            }

            Console.WriteLine(sb.ToString());
        }

        public static string print(int number)
        {
            if (number%15 == 0)
            {
                return "FizzBuzz";
            }
            if (number%3 == 0)
            {
                return "Fizz";
            }
            if (number%5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}