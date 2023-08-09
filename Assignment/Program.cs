namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine( "Enter a number");
            number = Convert.ToInt32(Console.ReadLine() );

            Console.WriteLine("Factors of {0} ", number );
            for(int divisor = 1; divisor <= number; divisor++) 
            {
                if( number % divisor == 0 )
                {
                    Console.Write("{0}, " , divisor );
                }
            }
        }
    }
}