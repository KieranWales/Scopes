using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What language do you want to be greeted with, english, german, french, spanish?");
            string chosenLanguage = Console.ReadLine();
            SayHello(chosenLanguage);
            Console.ReadLine();
        }

        private static void SayHello(string language)
        {
            switch (language.ToLower())
            {
                case "english":
                    Console.WriteLine("Hello");
                    break;

                case "german":
                    Console.WriteLine("Hallo");
                    break;

                case "french":
                    Console.WriteLine("Bonjour");
                    break;

                case "spanish":
                    Console.WriteLine("Hola");
                    break;

                case "":
                    Console.WriteLine("You didn't type anything");
                    break;

                default:
                    break;
            }
        }
    }
}
