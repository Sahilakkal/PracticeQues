using System;
namespace ConsoleApp1
{
    class Combination
    {
        static int numberOfCharcters = 3;
        static int maxSum = 0;
        static int maxCounterValue = 25;

        static void Main1(string[] args)
        {
            int[] values = { 65, 132, 201, 272, 345, 420, 497, 576, 657, 740, 825, 912, 1001, 1092, 1185, 1280, 1377, 1476, 1577, 1680, 1785, 1892, 2001, 2112, 2225, 2340 };
            int lastIndex = numberOfCharcters - 1;
           // int maxCount = 25;
            int[] countArray = new int[numberOfCharcters];
            string[] charSetArray = new string[maxSum + 1];
            int countOfUniqueCombinations = 0;
            int sum = 0;
            string charset;
            int newCounterValue = 0;
            while (countArray[0] < maxCounterValue || countArray[lastIndex] < maxCounterValue)
            {
                newCounterValue = 0;
                sum = 0;
                charset = " ";
                for (int i = 0; i < numberOfCharcters; i++)
                {
                    if (countArray[lastIndex] > maxCounterValue)
                    {
                        if (newCounterValue > 0)
                        {
                            countArray[i] = newCounterValue;
                        }
                        else
                        {
                            if (countArray[i + 1] >= maxCounterValue)
                            {
                                countArray[i]++;
                                newCounterValue = countArray[i];
                            }
                        }
                    }
                    sum = sum + values[countArray[i]];
                    charset = charset + (char)(countArray[i] + 'A');

                }
                charSetArray[sum] += charset + " ";
                countOfUniqueCombinations++;
                countArray[lastIndex]++;
            }
            int charSetHavingSameSum = 0;
            for (int i = 0; i < maxSum; i++)
            {
                if (charSetArray[i] != null)
                {
                    if (charSetArray[i].Length > numberOfCharcters + 1)
                    {
                        charSetHavingSameSum++;
                    }
                }
                Console.WriteLine("Sum= " + charSetHavingSameSum);
            }

        }
    }
}

