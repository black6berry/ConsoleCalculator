using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    /// <summary>
    ///  Интерфейс реализующий логику математичекских операций
    /// </summary>
    internal interface IMathOperation 
    {
        /// <summary>
        /// Метод суммы - складывает 2 числа
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public float Sum(float num1, float num2);
        /// <summary>
        /// Метод вычитния - вычитает из 1-го числа второе
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public float Subtract(float num1, float num2);
        /// <summary>
        /// Метод умножения - перемножает 2 числа
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public float Multiplication(float num1, float num2);
        /// <summary>
        /// Метод деления - делит первое число на второе
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public float Division(float num1, float num2);
        

    }
}
