using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    public class Ascii
    {
        public void Art()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string ascii = (@"

 .+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+. 
(           __       __             __            )
 )    |  | |  | | | |        |\ /| |  | | |      ( 
(     |><| |><| |\| | >> -<- | < | |><| |\|       )
 )    |  | |  | | | '__|     |   | |  | | |      ( 
(                                                 )
 ""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""+.+""  ");
            string[] lines = ascii.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                Console.WriteLine(Centred.CenterText(line));
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
