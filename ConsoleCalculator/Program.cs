

namespace ConsoleCalculator
{
    class Program
    {
        public double a {get; set;}
        public double b {get; set;}
        public char oper { get; set;}
        public double total { get; set;}
        public char repeate { get; set;}
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, это приложение - простой калькулятор, который может выполнять операции: сложение, вычитание, умножение, деление\n\n");
        again:
            Console.Write("Введи первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введи второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
        
            Console.Write("Введи оператор: ");
            char oper = Convert.ToChar(Console.ReadLine());

            if (oper == '+')
            {
                double total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                double total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                double total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                double total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }

            Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
            char repeate = Convert.ToChar(Console.ReadLine());

            if(repeate == 'д')
            {
                goto again;
            }
            

            //Console.WriteLine($"\nПервое число: {a}\nВторое число: {b}\nОператор: {action}");
        

            Console.ReadKey();


        }

    }


}
