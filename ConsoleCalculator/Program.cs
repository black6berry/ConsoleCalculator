
using System.Globalization;

namespace ConsoleCalculator
{
    class Program : Calculator
    {
        public Program(double num1, double num2, char oper) : base(num1, num2, oper)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Привет, это приложение - простой калькулятор, который может выполнять операции: сложение, вычитание, умножение, деление\n\n");
         again:
            var listNumbers = new List<double>();

            Console.Write("Введи число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            listNumbers.Add(num1);

            Console.Write("Введи число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            listNumbers.Add(num2);

            Console.Write("Введите оператор: ");
            char oper = Convert.ToChar(Console.ReadLine());

            Calculator calc = new Calculator(num1, num2, oper);
            calc.CheckOperator(oper);

            //calc.CheckNumber(listNumbers);

            Console.Write("Вы хотите продолжить работу с калькулятором? (д/н) ");
            char repeate = Convert.ToChar(Console.ReadLine());

            if (repeate == 'д' || repeate == 'Д')
            {
                goto again;
            }

            Console.ReadKey();
        }


    }
}
