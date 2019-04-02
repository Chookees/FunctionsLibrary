using System;
using System.IO;

namespace Functions.IO
{
    /// <summary>
    /// Class with functions for IO
    /// Created V1.1.1.0
    /// Last Change: V1.1.1.0
    /// </summary>
    public class TextFile
    {
        /// <summary>
        /// Create a TextFile
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        public static void Create(string path, string fileName)
        {
            File.Create(path + "/" +fileName + ".txt");
        }

        /// <summary>
        /// Write to the specified TextFile
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void WriteWithOverwrite(string path, string text)
        {
            File.WriteAllText(path,text);
        }

        /// <summary>
        /// Write to the specified File without overwriting it
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        public static void Write(string path, string text)
        {
            if (!path.Contains(".txt"))
            {
                path += "/File.txt";
            }
            StreamWriter writer = new StreamWriter(path,true);
            writer.Write(text);
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// Reads a specified File
        /// </summary>
        /// <param name="path">Path to the File</param>
        /// <param name="readAll">Whether the File should be read complete or not</param>
        /// <returns>The read text as string</returns>
        public static string Read(string path, bool readAll)
        {
            if (!path.Contains(".txt"))
            {
                path += "/File.txt";
            }

            StreamReader reader = new StreamReader(path);
            if (readAll)
            {
                return reader.ReadToEnd();
            }
            else
            {
                return reader.ReadLine();
            }
        }

        /// <summary>
        /// Deletes a specific File
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <returns>true when success, false when not</returns>
        public static bool Delete(string path)
        {
            try
            {
                File.Delete(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
