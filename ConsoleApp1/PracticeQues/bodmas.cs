using ConsoleApp1.MyDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.PracticeQues
{
    internal class Bodmas
    {
        public static bool IsOperator(char ch)
        {
            string operators = "+-*^/%";
            return operators.IndexOf(ch) != -1; // Check if the character is an operator
        }

        public static StringBuilder TakeInput()
        {
            List<char> input = new List<char>();

            for (int index = 0; !input.Contains('='); index++)
            {
                char character = (char)Console.Read();
                input.Insert(index, character);

                // To handle checking for duplicate operators (commented out as per your code)
                // if (index < 2 || (IsOperator(input[index - 2]) && IsOperator(input[index - 1])))
                // {
                //     Console.WriteLine("Duplicate Operator ");
                // }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in input)
            {
                stringBuilder.Append(c);
            }
            return stringBuilder;
        }

        public static int PriorityOfOperator(char ch)
        {
            switch (ch)
            {
                case '(': return 0; // Parentheses have the highest priority
                case '^': return 1;
                case '/': return 2;
                case '*': return 2;
                case '+': return 3;
                case '-': return 3;
                default: return -1;
            }
        }

        public static void SolveEquation(StringBuilder str)
        {
            Stack<char> operators = new Stack<char>();
            Stack<char> operands = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];

                if (char.IsDigit(currentChar))
                {
                    operands.Push(currentChar);
                }
                else if (currentChar == '(')
                {
                    operators.Push(currentChar);
                }
                else if (currentChar == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        char op = operators.Pop();
                        char right = operands.Pop();
                        char left = operands.Pop();

                        char result = Calculate(left, right, op);
                        operands.Push(result);
                    }
                    operators.Pop(); // Pop the '('
                }
                else if (IsOperator(currentChar))
                {
                    while (operators.Count > 0 && PriorityOfOperator(currentChar) >= PriorityOfOperator(operators.Peek()))
                    {
                        char op = operators.Pop();
                        char right = operands.Pop();
                        char left = operands.Pop();

                        char result = Calculate(left, right, op);
                        operands.Push(result);
                    }
                    operators.Push(currentChar);
                }
            }

            while (operators.Count > 0)
            {
                char op = operators.Pop();
                char right = operands.Pop();
                char left = operands.Pop();

                char result = Calculate(left, right, op);
                operands.Push(result);
            }

            if (operands.Count > 0)
            {
                Console.WriteLine("Result: " + operands.Peek());
            }
        }

        public static char Calculate(char left, char right, char op)
        {
            int leftValue = int.Parse(left.ToString());
            int rightValue = int.Parse(right.ToString());
            int result = 0;

            switch (op)
            {
                case '+': result = leftValue + rightValue; break;
                case '-': result = leftValue - rightValue; break;
                case '*': result = leftValue * rightValue; break;
                case '/': result = leftValue / rightValue; break;
                case '^': result = (int)Math.Pow(leftValue, rightValue); break;
                default: break;
            }

            return (char)(result + '0'); // Convert result back to char
        }

    }

    internal class BodmasSolution
    {
        public static bool IsOperator(char ch)
        {
            string operators = "+-*^/%";
            return operators.IndexOf(ch) != -1; // Check if the character is an operator
        }
        public static int PriorityOfOperator(char ch)
        {
            switch (ch)
            {
                case '(': return 0; // Parentheses have the highest priority
                case '^': return 1;
                case '/': return 2;
                case '*': return 2;
                case '+': return 3;
                case '-': return 3;
                default: return -1;
            }
        }


        public static void Solution(String s)
        {
            int head = 0, tail = 0;
            double answer = 0;



            while (tail > s.Length)
            {
                if (IsOperator(s[head]) && IsOperator(s[tail]) && head!=tail)    //if both points to different operator than i am checking can i perform the opeartion or not like which opeartion should be performed
                {
                    
                    if (PriorityOfOperator(s[head]) == PriorityOfOperator(s[tail]))
                    {

                    }

                    else if(PriorityOfOperator(s[head]) > PriorityOfOperator(s[tail]))
                    {

                    }

                    else
                    {

                    }
                }

                else if(IsOperator(s[head]) && IsOperator(s[tail]) && head == tail)
                {
                    tail++;
                }

                else if (IsOperator(s[head]) && !IsOperator(s[tail]))
                {
                    tail++;
                }

                else
                {
                    head++;
                    tail++;

                }

            }

        }

    }

}