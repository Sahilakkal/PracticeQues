using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    internal class LongestSubstring
    {
        /// <summary>
        /// returns the length of the longest  substring without repeating characters.
        /// </summary>
        /// <param name="text"></param>
        public int LongestSubstringProblem(string text)
        {
            int sentencePointer = 0;
            int firstMatchingCharIndex = 0;
            string current = "";
            string max = "";
            bool check = false;

            if (text.Length == 1)
            {
                return 1;

            }
            while (sentencePointer < text.Length)
            {
                if (!(current.Contains(text[sentencePointer])))
                {
                    current = current + text[sentencePointer];

                    if (current.Length == 1)
                    {
                        firstMatchingCharIndex = sentencePointer;
                    }
                }

                else
                {
                    sentencePointer = firstMatchingCharIndex;
                    check = true;
                }

                if (current.Length > max.Length)
                {
                    max = current;
                }

                if (check)
                {
                    current = "";
                    check = false;
                }
                sentencePointer++;
            }

            return max.Length;
        }
    }
}
