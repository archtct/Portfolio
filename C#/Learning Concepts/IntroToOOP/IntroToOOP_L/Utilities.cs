using System;
namespace IntroToOOP_L
{
    static class Utilities
    {
        public static void ColorfulWriteline(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
