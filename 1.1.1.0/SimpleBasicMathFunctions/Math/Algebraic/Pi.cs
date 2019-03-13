using System.Security.Cryptography;

namespace Functions.Math.Algebraic
{
    /// <summary>
    /// Class of functions for PI. (Algebraic)
    /// Created V1.1.1.0
    /// Last Change: V1.1.1.0
    /// </summary>
    public class Pi
    {
        /// <summary>
        /// Multiply Pi with a given Number
        /// </summary>
        /// <param name="number"></param>
        /// <returns> |Type: double| </returns>
        public static double PiMultiplication(double number)
        {
            return System.Math.PI * number;
        }

        /// <summary>
        /// Divide Pi with a given Number
        /// </summary>
        /// <param name="number"></param>
        /// <returns> |Type: double| </returns>
        public static double PiDivision(double number)
        {
            return System.Math.PI / number;
        }

        /// <summary>
        /// Get Pi as MD5
        /// </summary>
        /// <returns> |Type: MD5| </returns>
        public static MD5 GetPiAsMd5()
        {
            return MD5.Create(System.Math.PI.ToString());
        }

        /// <summary>
        /// Get Pi with 2 Decimals
        /// </summary>
        /// <returns> |Type: double| </returns>
        public static double GetPiWith2Decimal()
        {
            return System.Math.Round(System.Math.PI, 2);
        }

        /// <summary>
        /// Get Pi with 4 Decimals
        /// </summary>
        /// <returns> |Type: double| </returns>
        public static double GetPiWith4Decimal()
        {
            return System.Math.Round(System.Math.PI, 4);
        }

        /// <summary>
        /// Get Pi with 4 Decimals
        /// </summary>
        /// <returns> |Type: double| </returns>
        public static double GetPiWith6Decimal()
        {
            return System.Math.Round(System.Math.PI, 6);
        }

        /// <summary>
        /// Get Pi
        /// </summary>
        /// <returns> |Type: double| </returns>
        public static double GetPi()
        {
            return System.Math.PI;
        }
    }
}
