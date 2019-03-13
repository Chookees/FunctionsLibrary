using System;

namespace Functions.Math.NonAlgebraic
{
    /// <summary>
    /// Class of Exponential function. (NonAlgebraic)
    /// To use e.g: 2^4 = Calculate(2,4)
    /// Created V1.0.1.1
    /// Last Change: V1.1.1.0
    /// </summary>
    public class Exponential
    {
        /// <summary>
        /// Calculate with Integer(Int16)
        /// </summary>
        /// <param name="basis">to be exponentiated</param>
        /// <param name="exponent">to be exponentiated WITH</param>
        /// <returns>Exponentiated Integer</returns>
        public static int Calculate (int basis, int exponent)
        {
            return Convert.ToInt16(System.Math.Pow(basis, exponent));
        }

        /// <summary>
        /// Calculate with Doubles
        /// </summary>
        /// <param name="basis">to be exponentiated</param>
        /// <param name="exponent">to be exponentiated WITH</param>
        /// <returns>Exponentiated Double</returns>
        public static double Calculate(double basis, double exponent)
        {
            return System.Math.Pow(basis, exponent);
        }

        /// <summary>
        /// Calculate with Float
        /// </summary>
        /// <param name="basis">to be exponentiated</param>
        /// <param name="exponent">to be exponentiated WITH</param>
        /// <returns>Exponentiated Float</returns>
        public static float Calculate(float basis, float exponent)
        {
            return Convert.ToSingle(System.Math.Pow(basis, exponent));
        }

        /// <summary>
        /// Calculate with Long(Int64)
        /// </summary>
        /// <param name="basis">to be exponentiated</param>
        /// <param name="exponent">to be exponentiated WITH</param>
        /// <returns>Exponentiated Long(Int64)</returns>
        public static long Calculate(Int64 basis, Int64 exponent)
        {
            return Convert.ToInt64(System.Math.Pow(basis, exponent));
        }
    }
}
