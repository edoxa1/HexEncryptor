using System;
using System.Linq;

namespace BinaryEncrypt
{
    public class Encryptor
    {
        public static string ToBinaryEncryption(string word, string letterSeparator, string wordSeparator, bool isDebugEnabled)
        {
            const char emptySpace = ' ';
            var result = "";
            word.ToList().ForEach(c =>
            {
                if (c != emptySpace)
                {
                    var charPosition = Alphabet.GetAlphabetPosition(c);
                    var hexChar = Convert.ToString(charPosition, 16);
                    result += hexChar.PadLeft(4,'0') + letterSeparator;
                    if (!isDebugEnabled) return;
                    
                    Console.Write($"{c} : {charPosition}".PadRight(7, ' '));
                    Console.Write($" | {hexChar.PadLeft(4,'0')}");
                    Console.WriteLine();
                }
                else result += wordSeparator;
            });
            
            return result;
        }
            
    }
}