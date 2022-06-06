using System;
using AbstractFactory.Example;
using AbstractFactory.Example.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "to use in forest levels"
            var forestCampFactory = new WolfCampFactory();
            // "to use in volcano levels"
            var volcanoCampFactory = new DragonCampFactory();
            
            bool retry = true;
            int loop = 0;

            while (retry)
            {
                Console.WriteLine($"\nLOOP NUMBER {loop++}");
                Console.WriteLine("\n1. Create WolfCamp\n" 
                                  + "2. to create DragonCamp\n"
                                  + "0. to exit\n");

                Console.Write("Your input: ");
                var input = Console.ReadKey().Key;
                Console.Clear();
                
                switch (input)
                {
                    case ConsoleKey.D1:
                        CreateCamp(forestCampFactory);
                        break;
                    case ConsoleKey.D2:
                        CreateCamp(volcanoCampFactory);
                        break;
                    case ConsoleKey.D0:
                        retry = false;
                        break;
                    default:
                        Console.WriteLine("Invalid key, try again\n"); 
                        break;
                }
            }

        }

        static void CreateCamp(AbstractCampFactory abstractCampFactory)
        {
            var enemyCamp = new EnemyCamp(abstractCampFactory);
            Console.WriteLine($"\nRESULTS:");
            Console.WriteLine($"\n{enemyCamp.ToString()}");
        }
    }
}