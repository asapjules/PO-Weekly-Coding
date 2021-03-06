using System;

namespace SmoothieProgram
{
    class Program
    {   
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new string[] { "Banana" });
            Console.WriteLine(s1.GetCost());
            Console.WriteLine(s1.GetPrice());
            Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.Ingredients);

            Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            Console.WriteLine(s2.Ingredients);
            Console.WriteLine(s2.GetCost());
            Console.WriteLine(s2.GetPrice());
            Console.WriteLine(s2.GetName());
        }
    }
}

