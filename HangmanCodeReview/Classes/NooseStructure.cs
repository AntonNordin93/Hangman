using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    internal class NooseStructure
    {
        public void TheStructure()
        {
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            int startX = windowWidth / 2 - 4;
            int startY = windowHeight / 2 - 7;
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine("  +----+");
            Console.SetCursorPosition(startX, startY + 1);
            Console.WriteLine("  |    |");
            Console.SetCursorPosition(startX, startY + 2);
            Console.WriteLine("       |");
            Console.SetCursorPosition(startX, startY + 3);
            Console.WriteLine("       |");
            Console.SetCursorPosition(startX, startY + 4);
            Console.WriteLine("       |");
            Console.SetCursorPosition(startX, startY + 5);
            Console.WriteLine("       |");
            Console.SetCursorPosition(startX, startY + 6);
            Console.WriteLine("       |");
            Console.SetCursorPosition(startX, startY + 7);
            Console.WriteLine("=========");
        }


    }
}
