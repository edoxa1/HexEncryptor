using System.Collections.Generic;
using System.Linq;

namespace HexEncrypt
{
    public static class Alphabet
    {
        private static Dictionary<int,char> EnglishAlphabet
        {
            get
            {
                var alphabet = new Dictionary<int, char>();
                var temp = 1;
                for (var i = 'a'; i <= 'z'; i++)
                {
                    alphabet.Add(temp, i);
                    temp++;
                }

                return alphabet;
            }
        }

        public static System.Int32 GetAlphabetPosition(char c)
        {
            var position = EnglishAlphabet.First(x => x.Value == c).Key;
            return position;
        }
        public static System.Char GetAlphabetChar(int position)
        {
            var alphabetChar = EnglishAlphabet.First(x => x.Key == position).Value;
            return alphabetChar;
        }
    }
}