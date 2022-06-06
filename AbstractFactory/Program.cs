using System;
using AbstractFactory.Example;
using AbstractFactory.Example.Factories;
using AbstractFactory.Example.Items;
using AbstractFactory.Example.Mobs;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleRegularInstantiation();
            ExampleSimpleFactory();
            ExampleAbstractFactory();
        }
        
        static void LogCampInfo(EnemyCamp camp)
        {
            Console.WriteLine($"\nRESULTS:");
            Console.WriteLine($"\n{camp.ToString()}");
        }

        #region RegularInstantiation

        static void ExampleRegularInstantiation()
        {
            Console.Clear();
            Console.WriteLine($"RegularInstantiation");

            string area = "volcano";
            
            EnemyCamp camp = null;
            
            switch (area)
            {
                case "volcano":
                    camp = new EnemyCamp(new Dragon(), new DragonScales(5));
                    break;
                case "forest":
                    if (new Random().Next(2) == 0)
                    {
                        camp = new EnemyCamp(new Wolf(), new WolfSkin());
                    }
                    else
                    {
                        camp = new EnemyCamp(new Wolf(), new WolfFangs(2));
                    }
                    break;
                default:
                    Console.WriteLine($"Unknown area: {area}\n"); 
                    break;
            }

            LogCampInfo(camp);
            
            Console.WriteLine($"Press anything to continue"); 
            Console.ReadKey();
        }

        #endregion

        #region SimpleFactory

        static void ExampleSimpleFactory()
        {
            Console.Clear();
            Console.WriteLine($"SimpleFactory");
            
            string area = "volcano";

            var camp = SimpleCampFactory.CreateEnemyCamp(area);
            LogCampInfo(camp);
            
            Console.WriteLine($"Press anything to continue"); 
            Console.ReadKey();
        }

        #endregion

        #region AbstractFactory

        static void ExampleAbstractFactory()
        {
            Console.Clear();
            Console.WriteLine($"AbstractFactory");

            
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
                        var enemyCamp = new EnemyCamp(forestCampFactory);
                        LogCampInfo(enemyCamp);
                        break;
                    case ConsoleKey.D2:
                        enemyCamp = new EnemyCamp(forestCampFactory);
                        LogCampInfo(enemyCamp);
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

        #endregion
        
    }
}