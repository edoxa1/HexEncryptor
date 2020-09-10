using System;
using System.Linq;

namespace HexEncrypt
{
    internal class Program
    {
        public static void Main()
        {
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
                Console.Write($"Original Word: {wordToEncrypt}  \n");
                Console.WriteLine($"Encrypted word: {encryptedWord}");

                var decryptedWord = 
                    Encryptor.HexEncryptionToString(encryptedWord, letterSeparator, wordSeparator, isDebugging);
                Console.WriteLine($"Decrypted hex: {decryptedWord}");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Separators have same letters. Please, enter correct separators");
                Main();
            }
            Console.ReadKey();
        }

        private static Boolean CheckSeparators(string letterSeparator, string wordSeparator)
        {
            // Check if both separators have similar letters.
            
            var result = false;
            letterSeparator.ToList().ForEach(c =>
            {
                if (!wordSeparator.Contains(c)) return;
                result = true;
            });
            
            return result;
        }
    }
}

