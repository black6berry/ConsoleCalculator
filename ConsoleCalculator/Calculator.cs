using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Calculator : MathOperation
    {
        public Calculator( float num1, float num2, char oper)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.oper = oper;
        }

        public float num1;
        public float num2;
        public char oper;
        /// <summary>
        /// Метод для проверки входного оператора
        /// </summary>
        /// <param name="oper"></param>
        public void CheckOperator(char oper)
        {
            switch (oper) 
            {
                case '+':
                    Sum(num1, num2);
                    break;
                case '-':
                    Subtract(num1, num2);
                    break;
                case '*':
                    Multiplication(num1, num2);
                    break;
                case '/':
                    Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Не выбран оператор");
                    break;
            }
        }
        public static string mathOperation = "";
        public void ViewExample()
        {
            mathOperation = $"\n{num1} {oper} {num2} = {result}";
            Console.WriteLine(mathOperation);
        }
    }
}
