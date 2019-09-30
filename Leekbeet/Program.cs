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
    }
}

