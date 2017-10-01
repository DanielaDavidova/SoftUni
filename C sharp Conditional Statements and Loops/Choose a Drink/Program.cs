using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantities = int.Parse(Console.ReadLine());
            decimal price = 0;
            switch (profession)
            {
                case "Athlete": price=quantities*0.7m;break;
                case "Businessman":
                case "Businesswoman":
                price = quantities *1.00m; break;
                case "SoftUni Student": price = quantities * 1.70m; break;
                
                default: price = quantities * 1.20m; break;


            }
            Console.WriteLine($"The {profession} has to pay {price:F2}.");

        }
    }
}
