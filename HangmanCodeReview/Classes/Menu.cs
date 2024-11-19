using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    public class Menu
    {
        public void Showmenu()
        {
            Console.Clear();
            Ascii ascii = new Ascii();
            ascii.Art();
            Centred.CenterText("Välkommen till Spelet Hänga-Gubbe!");
            Centred.CenterText("tryck på någon av siffrora i menyn för att gå vidare.");
            Centred.Separator();
            Centred.CenterText("1. Spela");
            Centred.CenterText("2. Instruktioner");
            Centred.CenterText("3. Avsluta",ConsoleColor.Red);
            Centred.WriteCenteredInline("Skriv här: ");
            int input;
            bool isValidInput = int.TryParse(Console.ReadLine(), out input);
            if (isValidInput)
            {
                switch (input)
                {
                    case 1:
                        {
                            Console.Clear();
                            IGetoword getword = new WordGenerator();
                            Play play = new Play(getword);
                            play.Playgame();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Instructions instructions = new Instructions();
                            instructions.Mission();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Centred.CenterText("Du valde att avsluta, ha en bra dag! Välkommen åter!");
                            break;
                        }
                    default:
                        {
                            Centred.CenterText("Ogiltligt val,tyrck valfri tangent för att försöka igen");
                            Console.ReadKey();
                            Showmenu();
                            break;
                        }
                }
            }
            else
            {
                Centred.CenterText("Felaktig inmatning! Vänligen skriv en siffra.");
                Centred.CenterText("Tryck valfri tangent för att försöka igen.");
                Console.ReadKey();
                Showmenu();
            }
        }
    }
}

