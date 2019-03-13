using System;

namespace MathFunctions.Algebraic
{
    public class SquareRoot
    {
        /// <summary>
        /// Calculate Square root of double
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static double Calculate(double num1)
        {
            return Math.Sqrt(num1);
        }

        /// <summary>
        /// Calculate SquareRoot with repeat
        /// </summary>
        /// <param name="num1">Number under SquareRoot</param>
        /// <param name="num2">Times it should be repeated</param>
        /// <returns></returns>
        public static double Calculate(double num1, int num2)
        {
            for (int i = 0; i == num2; i++)
            {
                num1 = Math.Sqrt(num1);
            }

            return num1;
        }
    }
}
