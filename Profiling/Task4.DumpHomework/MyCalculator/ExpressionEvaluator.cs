using System;
using System.Collections.Generic;

namespace MyCalculatorv1
{
    public class ExpressionEvaluator
    {
        private readonly Dictionary<char, int> operationPriority;

        public ExpressionEvaluator()
        {
            operationPriority = new Dictionary<char, int>() {
                {'+', 0},
                {'-', 0},
                {'*', 1},
                {'/', 1}
            };
        }

        public double Calculate(string expression)
        {
            string postfixExpr = ToPostfix(expression);
            var numbers = new Stack<double>();

            for (int i = 0; i < postfixExpr.Length; i++)
            {
                char c = postfixExpr[i];

                if (char.IsDigit(c))
                {
                    string number = GetStringNumber(postfixExpr, ref i);
                    numbers.Push(Convert.ToDouble(number));
                }
                else if (operationPriority.ContainsKey(c))
                {
                    double second = numbers.Count > 0 ? numbers.Pop() : 0;
                    double first = numbers.Count > 0 ? numbers.Pop() : 0;

                    numbers.Push(Execute(c, first, second));
                }
            }

            return numbers.Pop();
        }

        private string ToPostfix(string infixExpr)
        {
            string postfix = string.Empty;
            var operators = new Stack<char>();

            for (int i = 0; i < infixExpr.Length; i++)
            {
                char c = infixExpr[i];
                if (char.IsDigit(c))
                {
                    postfix += GetStringNumber(infixExpr, ref i) + " ";
                }
                else if (operationPriority.ContainsKey(c))
                {
                    char op = c;

                    while (operators.Count > 0 && (operationPriority[operators.Peek()] >= operationPriority[op]))
                    {
                        postfix += operators.Pop();
                    }

                    operators.Push(op);
                }
            }

            foreach (char op in operators)
            {
                postfix += op;
            }

            return postfix;
        }

        private string GetStringNumber(string expr, ref int pos)
        {
            string strNumber = string.Empty;

            for (; pos < expr.Length; pos++)
            {
                char num = expr[pos];

                if (char.IsDigit(num))
                {
                    strNumber += num;
                }
                else
                {
                    pos--;
                    break;
                }
            }
            return strNumber;
        }

        private double Execute(char op, double first, double second) => op switch
        {
            '+' => first + second,
            '-' => first - second,
            '*' => first * second,
            '/' => first / second,
            _ => 0
        };
    }
}
