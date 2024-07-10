using System;

namespace CSC_205_week_02_6_3
{
    internal class Program
    {
        static double SquareRoot(double a)
        {
            // Initial guess
            double x0 = a / 2.0;
            double x1 = (x0 + a / x0) / 2.0;

            // Iterate until the difference between two consecutive estimates is less than 0.0001
            while (Math.Abs(x1 - x0) >= 0.0001)
            {
                x0 = x1;
                x1 = (x0 + a / x0) / 2.0;
            }

            return x1;
        }

        public static void Main(string[] args)
        {
            // Test the SquareRoot method with various values
            double number1 = 25.0;
            double number2 = 16.0;
            double number3 = 2.0;
            double number4 = 0.25;

            Console.WriteLine("Square root of {0} is approximately {1}", number1, SquareRoot(number1));
            Console.WriteLine("Square root of {0} is approximately {1}", number2, SquareRoot(number2));
            Console.WriteLine("Square root of {0} is approximately {1}", number3, SquareRoot(number3));
            Console.WriteLine("Square root of {0} is approximately {1}", number4, SquareRoot(number4));

            Console.ReadKey();
        }
    }
}