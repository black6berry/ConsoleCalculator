
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;


namespace ConsoleCalculator
{
    class Program : Calculator
    {
        public Program(float num1, float num2, char oper) : base(num1, num2, oper)
        {
        }

        //public List<string>? operationsHistory;

        static void Main(string[] args)
        {
            var total = 0f;
       
            Console.WriteLine("Привет, это приложение - простой калькулятор, который может выполнять операции:" +
                "\n1.Сложение: '+'" +
                "\n2.Вычитание: '-'" +
                "\n3.Умножение '*'" +
                "\n4.Деление: '/'\n\n");
        again:
            Console.WriteLine($"Текущее значение: {total}");
            Console.Write("Введи число: ");
            float num1 = (float)Convert.ToDouble(Console.ReadLine());
            total += num1;
            
            Console.WriteLine($"Текущее значение: {total}\n");
            total = 0;

            Console.Write("Введите оператор: ");
            char oper = Convert.ToChar(Console.ReadLine());

            Console.Write("Введи число: ");
            float num2 = (float)Convert.ToDouble(Console.ReadLine());
            total += num2 ;
            
            Console.WriteLine($"Текущее значение: {total}\n");

            Calculator calc = new Calculator(num1, num2, oper);
            calc.CheckOperator(oper);
            total = 0;

            calc.ViewExample();
            

            Console.Write("Вы хотите продолжить работу с калькулятором? (д/н) ");
            Console.WriteLine("\nvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
            char repeate = Convert.ToChar(Console.ReadLine());
            
            if (repeate == 'д' || repeate == 'Д')
            {
                goto again;
            }
            
            Console.ReadKey();
        }


    }
}
