using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryEncrypt
{
    public class Alphabet
    {
        public static int GetAlphabetPosition(char c)
        {
            var englishAlphabet = new Dictionary<int,char>();
            var temp = 1;
            for (var i = 'a'; i <= 'z'; i++)
            {
                englishAlphabet.Add(temp, i);
                temp++;
            }

            var position = englishAlphabet.FirstOrDefault(x => x.Value == c).Key;
            return position;
        }
    }
}