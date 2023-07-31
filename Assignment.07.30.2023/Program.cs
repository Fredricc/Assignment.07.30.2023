using System.ComponentModel.DataAnnotations;

namespace Assignment._07._30._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string input = Console.ReadLine();


            int count = 0;

            for(int i = 0; i < input.Length; i++)
            {
                count++;
            }
            Console.WriteLine($"Length of the number you entered is {count}");
            Console.ReadKey();
        }
    }
}