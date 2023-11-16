using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ConsoleApp1.Programss
{

    internal class Searching
    {

        public  void Final()
        {
            bool matchingStart = false;
            int sentenceIndex = 0;
            int wordIndex = 0;
            int wordfoundAtIndex = 0;
            int senLength;
            int wordLength;
            int firstCharInWordAtIndex = 0;
            void AgainCheck()
            {
                if (sentenceIndex == senLength - 1 && wordIndex == wordLength - 1)  // To come out from iteration.   //t t t 
                {
                    //sentenceIndex++;
                    wordIndex++;                                         //this //thif
                }
                // Again check from first letter of word.
                else
                {
                    wordIndex = firstCharInWordAtIndex - 1;
                    matchingStart = false;
                    sentenceIndex = wordfoundAtIndex;
                }
            }
            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter the text that you want to search in sentence: ");
            string word = Console.ReadLine();
            bool Textmatched = false;
            senLength = sentence.Length;
            wordLength = word.Length;
            while (sentenceIndex < sentence.Length)
            {
                //checking from start              
                if (!matchingStart)
                {
                    if (word[wordIndex] == ' ' && sentence[sentenceIndex] != ' ')
                    {
                        sentenceIndex--;
                    }
                    else if ((sentence[sentenceIndex] == ' ' && word[wordIndex] != ' ') || (word[wordIndex] != sentence[sentenceIndex]))
                    {
                        wordIndex--;
                    }
                    else if (word[wordIndex] == sentence[sentenceIndex] && sentence[sentenceIndex] != ' ')
                    {
                        matchingStart = true;
                        wordfoundAtIndex = sentenceIndex;
                        firstCharInWordAtIndex = wordIndex;
                    }
                }

                // After first character Match
                if (matchingStart && sentenceIndex != wordfoundAtIndex)
                {
                    if (word[wordIndex] == ' ' && sentence[sentenceIndex] != ' ')
                    {
                        sentenceIndex--;
                    }
                    else if (sentence[sentenceIndex] == ' ' && word[wordIndex] != ' ')
                    {
                        wordIndex--;
                    }
                    else if (word[wordIndex] == sentence[sentenceIndex] && sentence[sentenceIndex] != ' ')
                    {
                        if ((word[wordIndex - 1] != ' ' && sentence[sentenceIndex - 1] == ' ') ||
                            (word[wordIndex - 1] == ' ' && sentence[sentenceIndex - 1] != ' '))
                        {
                            AgainCheck();
                        }
                    }
                    else if (word[wordIndex] != sentence[sentenceIndex])
                    {
                        AgainCheck();
                    }
                }

                // when sentence is completely iterated and word is not.
                if (sentenceIndex == sentence.Length - 1 && wordIndex < word.Length - 1)
                {
                    if (word[wordIndex + 1] != ' ')
                    {
                        sentenceIndex++;
                    }
                    sentenceIndex--;
                }

                // When word completely iterated.
                if (wordIndex == word.Length - 1)
                {
                    Console.WriteLine("match at index of: " + wordfoundAtIndex);
                    Textmatched = true;
                    AgainCheck();
                }
                sentenceIndex++;
                wordIndex++;
            }
            if (!Textmatched)
            {
                Console.WriteLine("Text did not match in sentence");
            }
        }
    }
}




