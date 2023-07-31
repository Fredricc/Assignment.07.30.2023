namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            int remainder, digit = 0;


           while (num > 0)
            {
                digit = num % 10;
                if (digit % 2 == 0)
                {
                    Console.WriteLine($"{digit}");
                }
                num = (num - digit)/10;
            }
            Console.ReadKey();
        }
    }
}