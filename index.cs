using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Digit your message: ");
      string input = Console.ReadLine();

      char[] secretMessage = input.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for(int i = 0; i < secretMessage.Length; i++) {
        char character = secretMessage[i];
        int alphabetPositision = (Array.IndexOf(alphabet, character) + 3) % 26;
        char letter = alphabet[alphabetPositision];
        encryptedMessage[i] = letter;
      }

      string msgEncrypted = String.Join("", encryptedMessage);

      Console.WriteLine(msgEncrypted);  
    }
  }
}