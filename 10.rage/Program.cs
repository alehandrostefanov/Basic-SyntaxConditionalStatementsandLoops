using System;

class RageExpensesCalculator
{
    static void Main()
    {
        // Input
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        // Counters
        int trashedHeadsets = 0;
        int trashedMice = 0;
        int trashedKeyboards = 0;
        int trashedDisplays = 0;

        int keyboardTrashCount = 0;

        for (int i = 1; i <= lostGames; i++)
        {
            bool trashedHeadset = false;
            bool trashedMouse = false;

            if (i % 2 == 0)
            {
                trashedHeadsets++;
                trashedHeadset = true;
            }

            if (i % 3 == 0)
            {
                trashedMice++;
                trashedMouse = true;
            }

            if (trashedHeadset && trashedMouse)
            {
                trashedKeyboards++;
                keyboardTrashCount++;

                if (keyboardTrashCount % 2 == 0)
                {
                    trashedDisplays++;
                }
            }
        }

        double totalExpenses =
            trashedHeadsets * headsetPrice +
            trashedMice * mousePrice +
            trashedKeyboards * keyboardPrice +
            trashedDisplays * displayPrice;

        // Output
        Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
    }
}
