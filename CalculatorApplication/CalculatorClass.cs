using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        private Formula<double> calculateEventHandler;

        public double GetSum(double arg1, double arg2) => arg1 + arg2;
        public double GetDifference(double arg1, double arg2) => arg1 - arg2;
        public double GetProduct(double arg1, double arg2) => arg1 * arg2;
        public double GetQuotient(double arg1, double arg2) => arg1 / arg2;

        public event Formula<double> CalculateEvent
        {
            add
            {
                calculateEventHandler += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                calculateEventHandler -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double Invoke(double num1, double num2)
        {
            return calculateEventHandler?.Invoke(num1, num2) ?? 0.0;
        }
    }
}

