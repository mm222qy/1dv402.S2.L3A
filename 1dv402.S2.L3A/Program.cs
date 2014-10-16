using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice;

            do
            {
                //Rensa fönstret
                    Console.Clear();  
                //tar upp meny
                    ViewMenu();
                    Console.Write("Ange menyval (0-2): ");
                    
                //Avslutar om man läser in 0
                    if (int.TryParse(Console.ReadLine(), out Choice) && Choice == 0)
                    {
                        return;
                    }
                    else if (Choice == 1 || Choice == 2)
                    {
                        //Öppnar CreateShape och ger parametern värdet som Choice har
                        //Och öppnar sen ViewShapeDetail
                        
                        ViewShapeDetail(CreateShape((ShapeType)(Choice)));
                    }
                    else //Om det inte är 0-2 skickas felmeddelande ut
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Fel! ge ett nummer mellam 0 - 2.");
                        Console.ResetColor();
                    }
                //Klicka på valfri knapp för att komma vidare, Escape avslutar programmer
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tryck på tangent för att fortsätta (Escape avslutar)");
            Console.ResetColor();

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
        //metod som anropas efter CreateShape och som läser in en sträng och returnerar
        //value om det är ett flyttal och numret är större än 0, annars skriver den ut ett felmeddelande tills det blir true
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double value;

            Console.Write(prompt);

            while (true)
            {
                // Skriv in ett värde och kollar om det är en double samt värdet är högre än 0
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    return value;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Ange ett flyttal större än 0");
                Console.ResetColor();
            }

        }
        //privat metod Shape som först skriver ut en liten fin "header" med enumret som Shapen har
        // och 
        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║{0,25}             ║", shapeType);
            Console.WriteLine("╚══════════════════════════════════════╝\n");
            Console.ResetColor();

            // Anropar metoden ReadDoubleGreaterThanZero som
            double length = ReadDoubleGreaterThanZero("Ange längden: ");
            double width = ReadDoubleGreaterThanZero("Ange Bredden: ");

            Console.WriteLine();

            // Val av geometrisk figur, kastar ApplicationException om det inte är 1 eller 2 
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(length, width);
                case ShapeType.Rectangle:
                    return new Rectangle(length, width);
                default:
                    throw new ApplicationException();
            }

        }
       //Visar menyn och menyvalen
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("║          Geometriska figurer         ║");
            Console.WriteLine("║                                      ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine("\n0. Avsluta.\n\n1. Ellips\n\n2. Rektangel.\n");
            Console.WriteLine("══════════════════════════════════════ \n");


        }
        //Skriver ut detaljerna med ToString metoden som är satt i Shape klassen
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║                Detaljer              ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write(shape.ToString());
            Console.WriteLine();
            
        }
    }
}
