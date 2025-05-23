using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 10.46;
                }
                totalPrice *= peopleCount;

                if (peopleCount >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 16.00;

                }
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }

                totalPrice *= peopleCount;

            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = 15.00;
                }
                else if (day == "Saturday")
                {
                    totalPrice = 20.00;
                }
                else if (day == "Sunday")
                {
                    totalPrice = 22.50;
                }
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
               

            

            }
            Console.WriteLine($"Total price:  {totalPrice:f2}");
        }
    }
}
