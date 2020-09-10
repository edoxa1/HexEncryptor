using System;
using System.Linq;

namespace HexEncrypt
{
    internal class Program
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Word you want to encrypt: ");
            var wordToEncrypt = Console.ReadLine();
            Console.Write("Letter separator: ");
            var letterSeparator = Console.ReadLine();
            Console.Write("Word separator: ");
            var wordSeparator = Console.ReadLine();
            
            var isSeparatorsSimilar = CheckSeparators(letterSeparator, wordSeparator);
            
            if (!isSeparatorsSimilar)
            {
                Console.Write("Debug? (y/n) ");
                var isDebugging = Console.ReadLine() == "y";
                var encryptedWord =
                    Encryptor.StringToHexEncryption(wordToEncrypt, letterSeparator, wordSeparator, isDebugging);
                Console.WriteLine($"Word: {wordToEncrypt}\nEncrypted word: {encryptedWord}");

                var decryptedWord = Encryptor.HexEncryptionToString(encryptedWord, letterSeparator, wordSeparator, true);
                Console.WriteLine(decryptedWord);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Separators have same letters. Please, enter correct separators");
                Main();
            }
        }

        public static Boolean CheckSeparators(string letterSeparartor, string wordSeparator)
        {
            // Check if both separators have similar letters.
            
            var result = false;
            letterSeparartor.ToList().ForEach(c =>
            {
                if (!wordSeparator.Contains(c)) return;
                result = true;
            });
            
            return result;
        }
    }
}

