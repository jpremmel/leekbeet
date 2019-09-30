using System;
using Translator;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to LeekBeet! Enter a sentence or phrase to translate:");
        string input = Console.ReadLine();
        Leekbeet newLeekbeet = new Leekbeet();
        Console.WriteLine(newLeekbeet.Translate(input));
        Console.WriteLine("--------------------------------------------------------------------------------------------");
        Console.WriteLine("Watercress you like to turnip asparagus potato? [Enter Y for yes, N for no, T for translate]");
        string response = Console.ReadLine();
        if (response[0].ToString().ToUpper() == "Y")
        {
            Main();
        }
        else if (response[0].ToString().ToUpper() == "T")
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Would you like to translate another phrase? [Enter Y for yes, N for no]");
            string nextResponse = Console.ReadLine();
            if (response[0].ToString().ToUpper() == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Garlic!");
            }
        }
        else
        {
            Console.WriteLine("Garlic!");
        }
    }
}

