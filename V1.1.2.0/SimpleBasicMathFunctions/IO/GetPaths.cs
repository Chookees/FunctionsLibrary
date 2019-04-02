using System;

namespace Functions.IO
{
    /// <summary>
    /// Class with functions getting Paths
    /// Created V1.1.2.0
    /// Last Change: V1.1.2.0
    /// </summary>
    public class GetPaths
    {
        /// <summary>
        /// Gets path for the Documents Folder
        /// </summary>
        /// <returns>Documents Folder path as String</returns>
        public static string GetDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
        }

        /// <summary>
        /// Gets path for the Documents Folder combined with a given File
        /// </summary>
        /// <param name="file">Filename as "test.txt"</param>
        /// <returns>Documents Folder combined with the File as path => String</returns>
        public static string GetDocumentsPathCombined(string file)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "/" + file;
        }

        /// <summary>
        /// Gets path for the Desktop
        /// </summary>
        /// <returns>Desktop Path as string</returns>
        public static string GetDesktopPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        /// <summary>
        /// Gets path for the Desktop combined with a given File
        /// </summary>
        /// <param name="file">Filename as "test.txt"</param>
        /// <returns>Desktop Path combined with File as string</returns>
        public static string GetDesktopPathCombined(string file)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + file;
        }

        /// <summary>
        /// Gets path for the ApplicationData
        /// </summary>
        /// <returns>ApplicationData Folder path as String</returns>
        public static string GetApplicationData()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        /// <summary>
        /// Gets path for the ApplicationData combined with a given File
        /// </summary>
        /// <param name="file">Filename as "test.txt"</param>
        /// <returns>ApplicationData Folder path combined with File as String</returns>
        public static string GetApplicationDataCombined(string file)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + file;
        }

        /// <summary>
        /// Gets path for the ProgramFiles on C://
        /// </summary>
        /// <returns>ProgramFiles Folder path as String</returns>
        public static string GetProgramFiles()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
        }

        /// <summary>
        /// Gets path for the ProgramFiles on C:// combined with a given File
        /// </summary>
        /// <param name="file">Filename as "test.txt"</param>
        /// <returns>ProgramFiles Folder path combined with a File as String</returns>
        public static string GetProgramFilesCombined(string file)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)+ "/"+file;
        }
    }
}
