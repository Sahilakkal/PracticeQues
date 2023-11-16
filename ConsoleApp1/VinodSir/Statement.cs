using System;
using System.Collections.Generic;
using System.Net;

namespace VinodSir
{
    public struct s
    {
        int sa;

    }


    internal class  Statement
    {
        public static void BitwiseOperators()
        {
            int a = 9;    // binary: 1001
            int b = 5;    // binary: 0101


            // Bitwise AND
            int resultAnd = a & b;
            Console.WriteLine("a & b = " + resultAnd); // Output: 1 (binary: 0001)

            // Bitwise OR
            int resultOr = a | b;
            Console.WriteLine("a | b = " + resultOr);   // Output: 13 (binary: 1101)

            // Bitwise XOR
            int resultXor = a ^ b;
            Console.WriteLine("a ^ b = " + resultXor);   // Output: 12 (binary: 1100)

            // Bitwise NOT (Unary)
            int resultNotA = ~a;
            Console.WriteLine("~a = " + resultNotA);     // Output: -10 (binary: 11110110)

            // Bitwise Left Shift
            int resultLeftShift = a << 2;
            Console.WriteLine("a << 2 = " + resultLeftShift); // Output: 36 (binary: 100100)

            // Bitwise Right Shift
            int resultRightShift = a >> 2;
            Console.WriteLine("a >> 2 = " + resultRightShift); // Output: 2 (binary: 0010)
        }



        public static String isGoodString(String s)
        {
            string s1 = "Yes";
            string s2 = "No";
            bool goodString = false;

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Hello");
                //  Console.WriteLine((int)(s[i] - s[i + 1]));

                if (i == s.Length - 1)
                {
                    return s1;
                }

                if (i == s.Length - 1 || (((int)(s[i] - s[i + 1]) == 1 || (int)(s[i] - s[i + 1]) == -1)))

                {
                    goodString = true;
                }

                else
                {
                    goodString = false;
                }

                if (goodString == false)
                {
                    return s2;
                }
            }

            return s1;
        }

        public static bool containsString(int[] arr)
        {
            foreach (int val in arr)
            {
                if (val < 0)
                {
                    return false;
                }
            }

            return true;


        }

        public static int[] CompareTwoStrings(String s1, String s2)
        {
            int[] arr1 = new int[26];
            string largest;
            string small;

            largest = s1.Length > s2.Length ? s1 : s2;
            small = s1.Length > s2.Length ? s2 : s1;


            for (int i = 0; i < largest.Length; i++)
            {
                if (i < small.Length)
                {
                    int index = small[i] - 97;

                    arr1[index]--;

                }
            }

            for (int i = 0; i < s1.Length; i++)
            {
                int index = s1[i] - 97;

                arr1[index]--;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                int index = s2[i] - 97;
                arr1[index]++;
            }
            return arr1;

        }

        

        public static String FindLongestWord(String s, List<string> words)
        {
            int start = System.Environment.TickCount;
            String temp;

            for (int i = 0; i < words.Count; i++)
            {
                temp = "";

                temp = words[i];

                int[] arr = CompareTwoStrings(temp, s);

                containsString(arr);



            }
            int end = System.Environment.TickCount;

            return "yes";
        }



    }
}



