using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public new string Process(string str)
        {
            string result = string.Empty;

            Stack<string> rpnStack = new Stack<string>();
            List<string> parts = str.Split(' ').ToList<string>();
            foreach (string i in parts)
            {
                if (isNumber(i))
                {
                    rpnStack.Push(i);
                }
                if (isOperator(i))
                {
                    string second = rpnStack.Pop();
                    string first = rpnStack.Pop();
                    result = calculate(i, first, second);
                    rpnStack.Push(result);
                }
            }

            return result;
        }
    }
}