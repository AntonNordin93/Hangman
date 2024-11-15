using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Classes
{
    public class WordGenerator : IGetoword
    {
        private string[] words = { "programmering", "utveckling", "lärande", "teknik", "dator", "bajskorv","csharp","anton" };
        private Random random = new Random();
        public string GetWord()
        {
            return words[random.Next(words.Length)];
        }
    }
}
