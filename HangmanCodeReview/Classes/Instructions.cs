using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    public class Instructions
    {
        public void Mission()
        {
            bool run = true;
            while (run)
            {
                Console.Clear();                
                Centred.CenterText("Här är intsruktioner för spelet.");
                Centred.CenterText("Skriv in '2' om du vill gå tillbaka till huvudmenyn!");
                Centred.Separator();
                Centred.CenterText("Hänga gubbe går ut på att gissa till sig ett ord en bokstav i taget innan gubben hängs!");
                Centred.CenterText("För varje gång du gissar fel ritas en del av gubben ut och du tappar ett liv.");
                Centred.CenterText("Du har totalt 6 gissningar innan spelet är över,gissar du rätt så klarar den stackars gubben sig");
                Centred.Separator();
                Centred.WriteCenteredInline("Skriv här: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int menu2input))
                {
                    if (menu2input == 2)
                    {
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.Showmenu();
                        run = false;
                    }
                    else
                    {
                        Centred.CenterText("Ogiltigt val, tryck valfri tangent för att försöka igen!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Centred.CenterText("Ogiltig inmatning! Vänligen skriv en siffra. Tryck valfri tangent för att försöka igen.");
                    Console.ReadKey();
                }
            }

        }

    }
}
