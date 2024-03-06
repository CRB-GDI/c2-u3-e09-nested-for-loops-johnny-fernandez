using System.ComponentModel;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your row width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter how many rows: ");
            int height = int.Parse(Console.ReadLine());

            //print rows
            Console.WriteLine();
            for (int a =1; a <= height; a++)
            {
                //print content of the row to the right
                for (int b =1; b <= width; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Problem 2
            Console.WriteLine("Enter the MAX number of asterisk in a row: ");
            int maxAster = Int32.Parse(Console.ReadLine());

            //print the asterisk
            Console.WriteLine();
            for (int i = 1; i <= maxAster; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}