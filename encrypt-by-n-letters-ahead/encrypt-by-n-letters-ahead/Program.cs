using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encrypt_by_n_letters_ahead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Provide input to be encrypted: " + "\n");
            string input = Console.ReadLine();

            Console.WriteLine("By how many letters ahead? [1; 25]");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Encrypted input: ");

            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i += 1)
                {
                    char character = word[i];
                    if (char.IsLetter(character))
                    {
                        if (character >= 'A' && character <= 'Z')
                            if ((char)(character + n) > 'Z')
                                character = (char)(n - ('Z' - character) + 'A' - 1);
                            else character = (char)(character + n);

                        else if (character >= 'a' && character <= 'z')
                            if ((char)(character + n) > 'z')
                                character = (char)(n - ('z' - character) + 'z' - 1);
                            else character = (char)(character + n);

                        Console.Write(character);
                    }
                    else Console.Write(character);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
