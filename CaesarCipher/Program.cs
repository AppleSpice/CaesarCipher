using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };

            Console.WriteLine("Enter your secret word!");
            string input = Console.ReadLine();
            char[] secretMessage = input.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, letter);
                int newLetterPosition = (letterPosition * 3) % 26;
                char letterEncoded = alphabet[newLetterPosition];
                encryptedMessage[i] = letterEncoded;
            }

            string encodedString = string.Join("", encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}");
        }
    }
}
