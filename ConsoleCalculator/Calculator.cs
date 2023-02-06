using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class Calculator : ICalc
    {
        private double total;
        public double num1;
        public double num2;
        public char oper;
        public Calculator(double num1, double num2, char oper) 
        {
            this.num1 = num1;
            this.num2 = num2;
            this.oper = oper;
        }
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
        public void Subtract(double num1, double num2)
        {
            total = num1 - num2;
            Console.WriteLine($"Разность {num1} и {num2} равна {total}");
        }

        public void Division(double num1, double num2)
        {
            total = num1 / num2;
            Console.WriteLine($"Деление {num1} и {num2} равно {total}");
        }

        public void Multiplication(double num1, double num2)
        {
            total = num1 * num2;
            Console.WriteLine($"Умножение {num1} и {num2} равно {total}");
        }

        public void Sum(double num1, double num2)
        {
            total = num1 + num2;
            Console.WriteLine($"Сумма {num1} и {num2} равна {total}");
        }

    }
}
