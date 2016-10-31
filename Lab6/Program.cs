using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Boolean vowels = true;
                string english;
                int vowel;
                do
                {
                    vowels = true;
                    Console.Write("Please enter a word to translate: ");
                    english = Console.ReadLine();    
                    vowel = First_Vowel(english);
                    if (vowel == -1)
                    {
                        Console.WriteLine("That is not a word");
                        vowels = false;
                    }
                } while (vowels == false);
                string PigLatin = Translate(english, vowel);
                Console.WriteLine(PigLatin);
                Console.Write("Do you want to translate another word? (y/n): ");
                String inpt = Console.ReadLine();
                if (inpt == "n" || inpt == "N")
                {
                    break;
                }
            }
        }

        public static int First_Vowel(String word)
        {
            word = word.ToLower();
            int letter = 0;
            while (true)
            {
                if (word[letter] == 'a' || word[letter] == 'e' || word[letter] == 'i' || word[letter] == 'o' || word[letter] == 'u')

                {
                    return letter;
                }
                letter++;

                if (letter == word.Length)
                {
                    int y = 0;
                    while (true)
                    {
                        if (word[y] == 'y')
                        {
                            return y;
                        }
                        y++;

                        if (y == word.Length)
                        {
                            return -1;
                        }
                    }
                }
            }
        }

        public static string Translate(string word, int vowel)
        {
            string pig;
            string begin;
            if (word == word.ToUpper())
            {


                if (vowel == 0)
                {
                    pig = word + "WAY";
                }
                else
                {
                    pig = word.Substring(vowel);
                    begin = word.Substring(0, vowel);
                    pig = pig + begin + "AY";
                }
            }
            else if (word == word.ToLower())
            {
                if (vowel == 0)
                {
                    pig = word + "way";
                }
                else
                {
                    pig = word.Substring(vowel);
                    begin = word.Substring(0, vowel);
                    pig = pig + begin + "ay";
                }
            }
            else
            {
                if (vowel == 0)
                {
                    pig = word + "way";
                }
                else
                {
                    string middle = word.Substring(vowel);
                    string newFirst = middle.Substring(0, 1);
                    middle = middle.Substring(1);
                    string first = word.Substring(0, 1);
                    first = first.ToLower();
                    newFirst = newFirst.ToUpper();
                    begin = word.Substring(1, vowel);
                    pig = newFirst + middle + first + begin + "ay";
                }
            }
                return pig;
            
        }
    }
}
