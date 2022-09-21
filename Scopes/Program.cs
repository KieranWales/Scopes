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

            ShowOff();

            Console.ReadLine();
        }

        private static void SayHello(string language)
        {
            switch (language.ToLower())
            {
                case "english":
                    Console.WriteLine($"You can say hello in {language} with hello");
                    break;

                case "german":
                    Console.WriteLine($"You can say hello in {language} with hallo");
                    break;

                case "french":
                    Console.WriteLine($"You can say hello in {language} with bonjour");
                    break;

                case "spanish":
                    Console.WriteLine($"You can say hello in {language} with hola");
                    break;

                case "":
                    Console.WriteLine("You didn't type anything");
                    break;

                default:
                    break;
            }
        }

        static void ShowOff()
        {
            string[] languages = { "english", "german", "french", "spanish" };
            foreach (string language in languages)
            {
                SayHello(language);
            }
        }
    }
}
