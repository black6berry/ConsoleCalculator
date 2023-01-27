using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal class ActionOperator
    {
        public string a;
        public string b;
        public ActionOperator(string a, string b) 
        {
            this.a = a;
            this.b = b;
        }
        
        public void CheckOperator(string action)
        {
            try
            {
                if(action != null && action == "")
                {
                    switch (action)
                    {
                        case "*":
                            Sum(Convert.ToInt32(a), Convert.ToInt32(b));
                            break;
                        default:
                            break;

                    }
                }
                
            }
            catch (Exception ) 
            {
                Console.WriteLine("Оператор не выбран! выберите оператор");
            }
        }

        static void Sum(int a, int b) 
        {
            Console.WriteLine(a + b);
        }

        static void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        int Sum(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }

            return sum; //Сумма всех целых чисел в массиве
        }
    }
}
