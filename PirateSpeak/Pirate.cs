using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateSpeak
{
   public class Pirate
    {
        public List<string> GetPossibleWords(string nonsense, List<string> possibleWords)
        {
            List<string> matchingWords = new List<string>();
            var nonsenseArray = nonsense.ToCharArray();
            var alphabeticalNonsense = nonsenseArray.OrderBy(c => c);

            foreach (string word in possibleWords)
            {
                var wordArray = word.ToCharArray();
                var alphabeticalWord = wordArray.OrderBy(c => c);

                if (alphabeticalWord.SequenceEqual(alphabeticalNonsense))
                {
                    matchingWords.Add(word);
                }
            }

            return matchingWords;
        }
    }
}
