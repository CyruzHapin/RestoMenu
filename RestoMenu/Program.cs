using System;
using MealandPrice;

namespace RestoMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cyruz's Restaurant");
            Console.WriteLine("In our Menu, we have: ");
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Drinks");
            Console.WriteLine("3. Desert");
            Console.WriteLine("Pick a number to see the meal and price: ");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    Menu.DisplayFood();
                    break;

                case "2":
                    Menu.DisplayDrinks();
                    break;

                case "3":
                    Menu.DisplayDesert();
                    break;

                default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
            }

        }
    }
}
