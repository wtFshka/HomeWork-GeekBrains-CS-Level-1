using System;

namespace MyMethods
{
    public class WriterReader
    {
        public static void Main()
        {

        }
        public static string WriteRead(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
        public static void Pause(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}