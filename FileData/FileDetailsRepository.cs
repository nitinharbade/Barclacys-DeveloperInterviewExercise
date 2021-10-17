using System;

namespace FileData
{
    /// <summary>
    /// Class to process file depends on input 
    /// </summary>
    public class FileDetailsRepository
    {
        IFileData fileData;
        public FileDetailsRepository()
        {
            fileData = new FileData();
        }

        /// <summary>
        /// Get version/size of the file depends on the input value
        /// </summary>
        /// <param name="args"> args input </param>
        /// <returns> Version/Size </returns>
        public string GetFileDetails(string[] args)
        {
            string retValue = null;
            try
            {
                if (args[0] == "-v" || args[0] == "--v" || args[0] == "/v" || args[0] == "--version")
                {
                    string version = fileData.GetVersion(args[1]);
                    retValue = "File Version: " + version;
                }
                else if (args[0] == "-s" || args[0] == "--s" || args[0] == "/s" || args[0] == "--size")
                {
                    int size = fileData.GetSize(args[1]);
                    retValue = "File Size: " + size;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception - Message: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                retValue = "Error";
            }
            return retValue;
        }
    }
}