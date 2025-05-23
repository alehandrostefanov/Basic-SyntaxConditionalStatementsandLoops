namespace _08.triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(i+ " ");
                    
                }
                Console.WriteLine();
            }
            

        }
    }
}
