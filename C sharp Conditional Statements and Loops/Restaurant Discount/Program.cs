using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal pricePerPerson = 0;
            switch (package)
            {
                case "Normal":
                    {
                        if (groupSize <= 50)
                        {
                            Console.WriteLine($"We can offer you the Small Hall");
                            decimal totalPrice = 2500m + 500m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.05m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            Console.WriteLine($"We can offer you the Terrace");
                            decimal totalPrice = 5000m + 500m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.05m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else if (groupSize > 100 && groupSize <= 120)
                        {
                            Console.WriteLine($"We can offer you the Great Hall");
                            decimal totalPrice = 7500m + 500m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.05m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else
                        {
                            Console.WriteLine("We do not have an appropriate hall.");
                        }
                    }
                    break;

                case "Gold":
                    {
                        if (groupSize <= 50)
                        {
                            Console.WriteLine($"We can offer you the Small Hall"); ;
                            decimal totalPrice = 2500m + 750m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.10m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            Console.WriteLine($"We can offer you the Terrace");
                            decimal totalPrice = 5000m + 750m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.10m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else if (groupSize > 100 && groupSize <= 120)
                        {
                            Console.WriteLine($"We can offer you the Great Hall");
                            decimal totalPrice = 7500m + 750m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.10m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else
                        {
                            Console.WriteLine("We do not have an appropriate hall.");
                        }
                    }
                    break;

                case "Platinum":
                    {
                        if (groupSize <= 50)
                        {
                            Console.WriteLine($"We can offer you the Small Hall");
                            decimal totalPrice = 2500m + 1000m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.15m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");

                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            Console.WriteLine($"We can offer you the Terrace");
                            decimal totalPrice = 5000m + 1000m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.15m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");

                        }
                        else if (groupSize > 100 && groupSize <= 120)
                        {
                            Console.WriteLine($"We can offer you the Great Hall");
                            decimal totalPrice = 7500m + 1000m;
                            pricePerPerson = (totalPrice - (totalPrice * 0.15m)) / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                        }
                        else
                        {
                            Console.WriteLine("We do not have an appropriate hall.");
                        }
                    }

                    break;
                default:
                    break;


            }
        }
    }
}
    

