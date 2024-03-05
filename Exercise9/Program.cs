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

        }
    }
}