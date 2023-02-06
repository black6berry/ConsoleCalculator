using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    internal interface ICalc 
    {
        public void Sum(double num1, double num2);
        public void Subtract(double num1, double num2);
        public void Multiplication(double num1, double num2);
        
        public void Division(double num1, double num2);
        public void CheckOperator(char oper);

    }
}
