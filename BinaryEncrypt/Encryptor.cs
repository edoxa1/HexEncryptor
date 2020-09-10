using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace BinaryEncrypt
{
    public class Encryptor
    {
        public static string ToBinaryEncryption(string word, char charSeparator, char wordSeparator)
        {
            var result = "";
            //Console.WriteLine(Convert.ToString(Alphabet.GetAlphabetPosition(key), 2));
            word.ToList().ForEach(c =>
            {
                if (c != ' ')
                {
                    var binaryCode = Convert.ToString(Alphabet.GetAlphabetPosition(c), 16);
                    result += binaryCode.PadLeft(4,'0') + charSeparator;
                    
                    Console.Write($"{c} : {Alphabet.GetAlphabetPosition(c)}");
                    Console.Write($"   | {result}");
                    Console.WriteLine();
                }
                else result += wordSeparator;
            });
            
            return "";
        }
            
    }
}