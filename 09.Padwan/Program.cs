using System;

namespace _09.Padwan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            // Винаги купуваме 10% повече мечове (закръглено нагоре)
            int sabersCount = (int)Math.Ceiling(students * 1.10);
            double totalSabersPrice = sabersCount * lightsaberPrice;

            // Робите – по една на студент
            double totalRobesPrice = students * robePrice;

            // Всеки шести колан е безплатен
            int freeBelts = students / 6;
            int paidBelts = students - freeBelts;
            double totalBeltsPrice = paidBelts * beltPrice;

            // Обща сума
            double totalPrice = totalSabersPrice + totalRobesPrice + totalBeltsPrice;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - money;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
        }
    }
}
