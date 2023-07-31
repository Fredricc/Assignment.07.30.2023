namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            int digit = 0;
            int sum = 0;


            while (num > 0)
            {
                digit = num % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                    Console.WriteLine($"{sum}");
                }
                num = (num - digit) / 10;
            }
            Console.ReadKey();
        }
    }
}