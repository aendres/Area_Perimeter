using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            do
            {
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");

                string width;
                string length;

                Console.WriteLine("Enter Length: ");
                length = Console.ReadLine();
                float Length = float.Parse(length);

                Console.WriteLine("Enter Width: ");
                width = Console.ReadLine();
                float Width = float.Parse(width);

                float area = Length * Width;
                Console.WriteLine("Area:" + area);

                float perimeter = ((2 * Length) + (2 * Width));
                Console.WriteLine("Perimeter:" + perimeter);

                Console.WriteLine("Continue? (yes/no):");
                result = Console.ReadLine();
            }
            while (result == "yes");
            {
                Console.WriteLine("Have a good day!");
            }
        }
    }
}
