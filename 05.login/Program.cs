namespace _05.login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentChar = username[i];
                password += username[i];
            }
            int count = 1;

            while (true)
            {
                string inputpassword = Console.ReadLine();
                if (inputpassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (count >=4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                count++;
            }

        }
    }
}
