using System;
using System.Linq;

namespace HexEncrypt
{
    public static class Encryptor
    {
        public static string StringToHexEncryption(string word, string letterSeparator, string wordSeparator, bool isDebugEnabled)
        {
            const char emptySpace = ' ';
            const int hexBase = 16;
            var result = "";
            word.ToList().ForEach(delegate(char letter)
            {
                if (letter != emptySpace)
                {
                    var charPosition = Alphabet.GetAlphabetPosition(letter);
                    var hexChar = Convert.ToString(charPosition, hexBase);
                    result += hexChar.PadLeft(4,'0') + letterSeparator;
                    if (!isDebugEnabled) return;
                    
                    Console.Write($"{letter} : {charPosition}".PadRight(7));
                    Console.Write($" | {hexChar.PadLeft(4,'0')}");
                    Console.WriteLine();
                }
                else result += wordSeparator;
            });
            
            return result;
        }

        public static string HexEncryptionToString(string encryptedWord, string letterSeparator, string wordSeparator, bool isDebugEnabled)
        {
            var result = "";
            var hexWords = encryptedWord.Split(wordSeparator.ToCharArray()).ToList();
            hexWords.ForEach(delegate(string word)
            {
                if (word == String.Empty) return;
                var hexLetters = word.Split(letterSeparator.ToCharArray()).ToList();
                hexLetters.ForEach(delegate(string hexLetter)
                {
                    if (hexLetter == String.Empty) return;
                    var letterPosition = Convert.ToInt32(hexLetter, 16);
                    var letter = Alphabet.GetAlphabetChar(letterPosition);
                    result += letter;
                    if (!isDebugEnabled) return;
                    Console.Write($"{hexLetter} : {letterPosition}".PadRight(10, ' '));
                    Console.Write($" | {letter}");
                    Console.WriteLine();
                });
                result += " ";
            });
            return result;
        }
    }
}