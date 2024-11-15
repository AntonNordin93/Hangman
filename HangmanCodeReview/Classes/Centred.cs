using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    public class Centred
    {
        public static string CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int centeredPosition = (windowWidth - text.Length) / 2;
            return new string(' ', Math.Max(0, centeredPosition)) + text;
        }
    }
}
