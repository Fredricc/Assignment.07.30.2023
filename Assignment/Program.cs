namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            string? number = Console.ReadLine();

            int count = number.Length;

            Console.WriteLine($"Length of the number is {count}");
            int num = (Convert.ToInt32(number));
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }
    }
}