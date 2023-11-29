using System;

namespace ConsoleApp1.LeetCode
{
    internal class LongestRepeatingCharWithReplacement
    {
        public int LongestRepeatingChar(string text, int key)
        {
            int head;
            int tail = 0;
            
            int tempKey = 0;
            bool check = false;
            int currentCount = 0;
            int maxCount = 0;
            bool startMatching = false;
            for (head = 0; head < text.Length; head++)
            {
              
                {
                    if (text[tail] == text[head])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if (tempKey > 0)
                        {
                            currentCount++;
                            tempKey--;
                        }

                        else
                        {
                            check = true;

                        }

                    }


                    if (currentCount > maxCount || maxCount < 1)
                    {
                        maxCount = currentCount;

                    }

                    if (check)
                    {
                        currentCount = 0;
                        check = false;
                    }


                    tail++;
                }
            }

            return maxCount;
        }
    }
}
