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
            Console.WriteLine(Centred.CenterText("Välkommen till Spelet Hänga-Gubbe!"));
            Console.WriteLine(Centred.CenterText("tryck på någon av siffrora i menyn för att gå vidare."));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Centred.CenterText("*****************************************"));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Centred.CenterText("1. Spela"));
            Console.WriteLine(Centred.CenterText("2. Instruktioner"));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Centred.CenterText("3. Avsluta"));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(Centred.CenterText("Skriv här: "));
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
                            Console.WriteLine("Du valde att avsluta, ha en bra dag! Välkommen åter!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ogiltligt val,tyrck valfri tangent för att försöka igen");
                            Console.ReadKey();
                            Showmenu();
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Felaktig inmatning! Vänligen skriv en siffra.");
                Console.WriteLine("Tryck valfri tangent för att försöka igen.");
                Console.ReadKey();
                Showmenu();
            }
        }
    }
}

