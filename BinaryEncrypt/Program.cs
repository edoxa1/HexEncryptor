using System;

namespace BinaryEncrypt
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
                Encryptor.ToBinaryEncryption(wordToEncrypt, letterSeparator, wordSeparator, isDebugging);
            Console.WriteLine($"Word: {wordToEncrypt}\nEncrypted word: {encryptedWord}");
        }
    }
}

