using System;


namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
            Console.WriteLine(sum);

        }
    }
}
