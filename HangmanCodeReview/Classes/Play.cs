using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    public class Play
    {
        public string _wordToGuess;
        public char[] _guessedWord;
        public List<char> _guessedLetters;
        public int _lives;
        public Play(IGetoword wordProvider)
        {
            _wordToGuess = wordProvider.GetWord();
            _guessedWord = new string('_', _wordToGuess.Length).ToCharArray();
            _guessedLetters = new List<char>();
            _lives = 6;
        }
        public void Playgame()
        {
            Console.SetCursorPosition(0, 1);
            Console.Write("Ordet: " + new string(_guessedWord));
            Console.SetCursorPosition(0, 2);
            Console.Write("Gissade bokstäver: ");
            Console.SetCursorPosition(0, 3);
            Console.Write($"Liv kvar: {_lives}");
            NooseStructure nooseStructure = new NooseStructure();
            nooseStructure.TheStructure();
            while (_lives > 0 && new string(_guessedWord) != _wordToGuess)
            {
                Console.SetCursorPosition(0, 5);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, 6);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(7, 1); 
                Console.Write(new string(_guessedWord));
                Console.SetCursorPosition(18, 2); 
                Console.Write(string.Join(", ", _guessedLetters) + "        ");
                Console.SetCursorPosition(10, 3);
                Console.Write("    ");
                Console.SetCursorPosition(10, 3);
                Console.Write(_lives);
                Console.SetCursorPosition(0, 4);
                Console.Write("Gissa en bokstav: ");
                Console.SetCursorPosition(17, 4);
                Console.Write(new string(' ', 20));
                Console.SetCursorPosition(17, 4);
                char guess = Console.ReadLine().ToLower()[0];
                if (_guessedLetters.Contains(guess))
                {
                    Console.SetCursorPosition(0, 5);
                    Console.Write("Du har redan gissat den bokstaven. tryck valfri tangent för att försöka igen.");
                    Console.ReadKey();
                    continue;
                }
                _guessedLetters.Add(guess);
                if (_wordToGuess.Contains(guess))
                {
                    for (int i = 0; i < _wordToGuess.Length; i++)
                    {
                        if (_wordToGuess[i] == guess)
                        {
                            _guessedWord[i] = guess;
                        }
                    }
                    Console.SetCursorPosition(0, 5);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Rätt gissat!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Tryck valfri tangent för att fortsätta.");
                    Console.ReadKey();
                }
                else
                {
                    _lives--;
                    DrawHangman drawHangman = new DrawHangman();
                    drawHangman.DrawTheHangman(_lives);
                    Console.SetCursorPosition(0, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Fel gissat!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Du förlorade ett liv.");
                    Console.Write("Tryck valfri tangent för att försöka igen.");
                    Console.ReadKey();
                }
            }
            Console.SetCursorPosition(0, 5);
            if (new string(_guessedWord) == _wordToGuess)
            {
                Console.Clear();
                Console.WriteLine($"\nGrattis! Du gissade ordet: {_wordToGuess}");
                Console.Write($"Ordet var: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{_wordToGuess}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Tryck valfri tangent för att återgå till huvudmenyn");
                Console.ReadKey();
                Console.Clear();
                Menu menu = new Menu();
                menu.Showmenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nTyvärr, du har inga liv kvar.");
                Console.Write($"Ordet var: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{_wordToGuess}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Tryck valfri tangent för att återgå till huvudmenyn");
                DrawHangman drawHangman = new DrawHangman();
                drawHangman.DrawTheHangman(0);
                Console.ReadKey();
                Console.Clear();
                Menu menu = new Menu();
                menu.Showmenu();
            }
        }
    }
}
