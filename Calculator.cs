using System;

namespace calculator
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Square(int number1)
        {
            return number1*number1;
        }

        public double SquareRoot(double number1)
        {
            return Math.Sqrt(number1);
        }

    }
}