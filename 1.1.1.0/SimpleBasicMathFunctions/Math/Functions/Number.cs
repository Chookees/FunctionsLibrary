namespace Functions.Math.Functions
{
    /// <summary>
    /// Class of function to Check if a given Number.
    /// Only Integer(Int16) are possible to check.
    /// Created V1.1.1.0
    /// Last Change: V1.1.1.0
    /// </summary>
    public class Number
    {
        /// <summary>
        /// Check if the given Integer(Int16) is even
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns> |Type: bool| </returns>
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        /// <summary>
        /// Check if the given number is completely divisible by the second given number
        /// </summary>
        /// <param name="numberTo">Check this number</param>
        /// <param name="divideBy">Divide numberTo by this</param>
        /// <returns> |Type: bool| </returns>
        public static bool IsCompletlyDivisible(int numberTo, int divideBy)
        {
            return numberTo % divideBy == 0;
        }

        /// <summary>
        /// Check if the given number is a prime number
        /// </summary>
        /// <param name="number">NUmber to check</param>
        /// <returns> |Type: bool| </returns>
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)System.Math.Floor(System.Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }


    }
}
