using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    internal class DrawHangman
    {
        public void DrawTheHangman(double lives)
        {
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            int startX = windowWidth / 2 - 4;
            int startY = windowHeight / 2 - 7;
            NooseStructure nooseStructure = new NooseStructure();
            nooseStructure.TheStructure();
            int hangmanX = startX + 1; 
            int hangmanY = startY + 2;
            Console.ForegroundColor = ConsoleColor.Red;
            switch (lives)
            {
                case 5:
                    Console.SetCursorPosition(hangmanX, hangmanY);
                    Console.WriteLine(" O");
                    break;
                case 4:
                    Console.SetCursorPosition(hangmanX, hangmanY);
                    Console.WriteLine(" O");
                    Console.SetCursorPosition(hangmanX, hangmanY + 1);
                    Console.WriteLine(" |");
                    break;
                case 3:
                    Console.SetCursorPosition(hangmanX, hangmanY);
                    Console.WriteLine(" O");
                    Console.SetCursorPosition(hangmanX, hangmanY + 1);
                    Console.WriteLine("/|");
                    break;
                case 2:
                    Console.SetCursorPosition(hangmanX, hangmanY);
                    Console.WriteLine(" O");
                    Console.SetCursorPosition(hangmanX, hangmanY + 1);
                    Console.WriteLine("/|\\");
                    break;
                case 1:
                    Console.SetCursorPosition(hangmanX, hangmanY);
                    Console.WriteLine(" O");
                    Console.SetCursorPosition(hangmanX, hangmanY + 1);
                    Console.WriteLine("/|\\");
                    Console.SetCursorPosition(hangmanX, hangmanY + 2);
                    Console.WriteLine("/");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 0:
                    Console.SetCursorPosition(hangmanX, hangmanY);
                    Console.WriteLine(" O");
                    Console.SetCursorPosition(hangmanX, hangmanY + 1);
                    Console.WriteLine("/|\\");
                    Console.SetCursorPosition(hangmanX, hangmanY + 2);
                    Console.WriteLine("/ \\");
                    Console.SetCursorPosition(startX, startY + 8);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
        }
    }
}
