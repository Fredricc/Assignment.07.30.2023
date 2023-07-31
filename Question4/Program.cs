namespace Question4
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
            int[] a = new int[0] { };

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                count++;
                Console.WriteLine(a[count]);
            }

            while (num > 0)
            {
                digit = num % 10;
                Console.WriteLine( digit);
                num = (num - digit) / 10;
                
            }

            Console.WriteLine( a);
            Console.ReadKey();
        }
    }
}