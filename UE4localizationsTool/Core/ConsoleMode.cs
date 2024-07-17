using System;

namespace AssetParser
{
    public static class ConsoleMode
    {
        public enum ConsoleModeType
        {
            Normal,
            Error
        }
        public static bool Show = false;
        public static bool StopInError = false;
        public static void Print(string Str, ConsoleColor color = ConsoleColor.White, ConsoleModeType type = ConsoleModeType.Normal)
        {
            if (Show)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(Str);
                Console.ForegroundColor = ConsoleColor.White;
                if (type == ConsoleModeType.Error && StopInError) 
                {
                    Print("按 \"Enter\" 继续...", ConsoleColor.White);
                    Console.ReadLine(); 
                }
            }
        }
    }
}
