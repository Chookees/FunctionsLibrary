using System;

namespace Functions.Math.Algebraic
{
    /// <summary>
    /// Class for Square root function. (Algebraic)
    /// Created V1.0.1.0
    /// Last Change: V1.1.1.0 => Variable names Changed
    /// </summary>
    public class SquareRoot
    {
        #region SquareRoot with Double

        /// <summary>
        /// Calculate Square root of double
        /// </summary>
        /// <param name="radicant"></param>
        /// <returns></returns>
        public static double Calculate(double radicant)
        {
            return System.Math.Sqrt(radicant);
        }

        /// <summary>
        /// Calculate SquareRoot with repeat
        /// </summary>
        /// <param name="radicant">Number under SquareRoot</param>
        /// <param name="rootExponent">Times it should be repeated</param>
        /// <returns></returns>
        public static double Calculate(double radicant, int rootExponent)
        {
            for (int i = 0; i == rootExponent; i++)
            {
                radicant = System.Math.Sqrt(radicant);
            }

            return radicant;
        }
        #endregion

        #region SquareRoot with Integer
        /// <summary>
        /// Calculate Square root with Integer(Int16)
        /// </summary>
        /// <param name="radicant"></param>
        /// <returns></returns>
        public static int Calculate(int radicant)
        {
            return Convert.ToInt16(System.Math.Sqrt(radicant));
        }

        /// <summary>
        /// Calculate Square root with repeat and Integer(Int16)
        /// </summary>
        /// <param name="radicant">Number under SquareRoot</param>
        /// <param name="rootExponent">Times it should be repeated</param>
        /// <returns></returns>
        public static int Calculate(int radicant, int rootExponent)
        {
            for (int i = 0; i == rootExponent; i++)
            {
                radicant = Convert.ToInt16(System.Math.Sqrt(radicant));
            }

            return radicant;
        } 
        #endregion
    }
}
