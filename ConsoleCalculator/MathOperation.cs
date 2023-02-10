using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class MathOperation : IMathOperation
    {
        public float result { get; set; }

        public float Division(float num1, float num2)
        {
            result = num1 / num2;
            //Console.WriteLine($"Деление {num1} и {num2} равно {result}");
            return result;
            
        }

        public float Multiplication(float num1, float num2)
        {
            result = num1 * num2;
            //Console.WriteLine($"Умножение {num1} и {num2} равно {result}");
            return result;
        }

        public float Subtract(float num1, float num2)
        {
            result = num1 - num2;
            //Console.WriteLine($"Разность {num1} и {num2} равна {result}");
            return result;
        }

        public float Sum(float num1, float num2)
        {
            result = num1 + num2;
            //Console.WriteLine($"Сумма {num1} и {num2} равна {result}");
            return result;
        }
    }
}
