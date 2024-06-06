using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6._6._24_wordle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            string wordguessed;
            bool wordcorrect = false;
            bool lettercorrect = false;
            int guess = 5;

            Console.Write("Person 1 enter a 5 letter word: ");
            word = Console.ReadLine();
            word = word.ToUpper();
            while(word.Length != 5)
            {
                Console.Write("Word not 5 letters, enter again: ");
                word = Console.ReadLine();
            }
            Console.Clear();
            Thread.Sleep(1000);
            Console.Write("Person 2 guess the 5 letter word: ");
            wordguessed = Console.ReadLine();
            wordguessed = wordguessed.ToUpper();
            while (wordguessed.Length != 5)
            {
                Console.Write("Word not 5 letters, enter again: ");
                wordguessed = Console.ReadLine();
            }
            while(guess != 0)
            {
                guess -= 1;
                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (wordguessed[j] == word[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        if (wordguessed.Contains(word[i]))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        if (wordguessed == word)
                        {
                            wordcorrect = true;
                        }
                        else
                        {
                            wordcorrect = false;
                            Console.WriteLine($"\n{wordguessed}\n");
                            Console.WriteLine("Enter another word: ");
                            wordguessed = Console.ReadLine();
                        }
                    }
                }
                               
            }
            if (guess == 0)
            {
                Console.WriteLine($"The word was: {word}");
                Console.WriteLine("Better Luck next time!");
                return;
            }
            if (wordcorrect)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(word);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You got it!");
            }
            Console.ReadLine();
        }
    }
}
