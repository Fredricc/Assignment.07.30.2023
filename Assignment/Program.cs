namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all even numbers from 1 to 100");
            int sum = 0;
            for(int i = 0; i <= 100;  i++)
            {
                if(i%2 == 0)
                {
                    Console.Write($" {i}");
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sum is of the above even numbers is {sum}");
        }
    }
}