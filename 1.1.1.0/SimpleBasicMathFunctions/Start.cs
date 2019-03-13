using System;
using System.Diagnostics;

namespace Functions
{
    /// <summary>
    /// Class with functions for Diagnostics
    /// Created V1.1.1.0
    /// Last Change: V1.1.1.0
    /// </summary>
    public class Start
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
        /// <param name="nameOfProcess">The name of the Process - Case sensitive</param>
        /// <returns> True when successfully set|False when failed to set </returns>
        public static bool SetPriorityOfTaskRealtime(string nameOfProcess)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(nameOfProcess);

                foreach (Process process in processes)
                {
                    process.PriorityClass = ProcessPriorityClass.RealTime;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
