using System;

namespace LesBouclesExo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Afficher 10 fois le message suivant dans la console:
            « Bonjour, je suis le message n°1. », « Bonjour, je suis le message n°2. », ..*/

            int counter = 0;
            while (counter < 10)

            {    
                counter++;
                Console.WriteLine($"Bonjour, je suis le message numéro n° {counter}");                
            }
        }
    }
}
