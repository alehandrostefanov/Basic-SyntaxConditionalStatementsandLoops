using System;
using System.Globalization;

class CoffeeOrders
{
    static void Main()
    {
        int ordersCount = int.Parse(Console.ReadLine());
        decimal totalPrice = 0m;

        for (int i = 0; i < ordersCount; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            decimal orderPrice = days * capsulesCount * pricePerCapsule;
            totalPrice += orderPrice;

            Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
        }

        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}
