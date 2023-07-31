using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] topics = { "Variables", "Data types", "Functions", "Operators", "Classes" };
            ////topics.Length =5
            ////reversing the array
            //for (int i = 4; i >= 0; i--)
            //{

            //    Console.WriteLine(topics[i]);
            //}
            //Console.WriteLine("...............................................................................");
            //foreach (string topic in topics)
            //{
            //    Console.WriteLine(topic);
            //}

            string[] topics = new string[5];

            Console.WriteLine("Enter the topics");

            for (int i = 0; i < topics.Length; i++)

            {

                topics[i] = Console.ReadLine();

            }

            Console.WriteLine();

            Console.WriteLine("Printing the topics array");

            for (int i = 0; i < topics.Length; i++)

            {

                Console.WriteLine(topics[i]);

            }

            Console.ReadLine();
          
        }
    }
}