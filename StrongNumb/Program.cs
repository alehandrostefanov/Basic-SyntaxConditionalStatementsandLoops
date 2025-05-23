using System;

namespace StrongNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int initialNumber = number;
            int sum = 0;


            while (number > 0)
            {

                int factorial = 1;
                int lastdigit = number % 10;
                number /= 10;

                for (int i = 1; i <= lastdigit; i++)
                {
                    factorial *= i;

                }

                sum += factorial;


            }
            if (sum == initialNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
