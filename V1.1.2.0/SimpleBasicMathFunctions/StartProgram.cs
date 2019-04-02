using System;
using System.Diagnostics;

namespace Functions
{
    /// <summary>
    /// Class with functions for Diagnostics
    /// Created V1.1.1.0
    /// Last Change: V1.1.1.0
    /// </summary>
    public class StartProgram
    {
        /// <summary>
        /// Start a specific Program just with it's path
        /// </summary>
        /// <param name="path">e.g C://Program Files//Notepad++//notepad++.exe </param>
        public static void SpecificProgram(string path)
        {
            Process.Start(path);
        }

        /// <summary>
        /// Function to set the Priority of a specific Process to Realtime
        /// </summary>
        /// <returns> True when successfully set|False when failed to set </returns>
        public static bool SetPriorityOfTaskRealtime()
        {
            try
            {
                using (Process p = Process.GetCurrentProcess())
                    p.PriorityClass = ProcessPriorityClass.High;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
