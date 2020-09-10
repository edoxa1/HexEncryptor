using System;

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
            Console.Write("Debug? (y/n) ");
            var isDebugging = Console.ReadLine() == "y";

            var encryptedWord =
                Encryptor.StringToHexEncryption(wordToEncrypt, letterSeparator, wordSeparator, isDebugging);
            Console.WriteLine($"Word: {wordToEncrypt}\nEncrypted word: {encryptedWord}");

            var decryptedWord = Encryptor.HexEncryptionToString(encryptedWord, letterSeparator, wordSeparator, true);
            Console.WriteLine(decryptedWord);
        }
    }
}

