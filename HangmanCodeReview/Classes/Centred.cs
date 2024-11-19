using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{

    public class Centred
    {
        public static void CenterText(string text,ConsoleColor color=ConsoleColor.Gray)
        {
            int windowWidth = Console.WindowWidth;
            int centeredPosition = (windowWidth - text.Length) / 2;
            Console.ForegroundColor = color;
            Console.WriteLine(new string(' ',Math.Max(0,centeredPosition))+text);
            Console.ForegroundColor= ConsoleColor.Gray;
        }
        public static void Separator(ConsoleColor color=ConsoleColor.Green)
        {
            string textseparator = new string('*',Console.WindowWidth -10);
            CenterText(textseparator, color);    
        }
        public static void WriteCenteredInline(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            int windowWidth = Console.WindowWidth;
            int centeredPosition = (windowWidth - text.Length) / 2;
            Console.ForegroundColor = color;
            Console.Write(new string(' ', Math.Max(0, centeredPosition)) + text); 
            Console.ForegroundColor = ConsoleColor.Gray; 
        }
    }
}
