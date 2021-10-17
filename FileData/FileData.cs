using ThirdPartyTools;

namespace FileData
{
    /// <summary>
    /// Class to get details of the file
    /// </summary>
    public class FileData : IFileData
    {
        FileDetails fileDetails;
        public FileData()
        {
            fileDetails = new FileDetails();
        }

        /// <summary>
        /// Get size of the files
        /// </summary>
        /// <param name="filePath"> file path </param>
        /// <returns> size of the file </returns>
        public int GetSize(string filePath)
        {
            return fileDetails.Size(filePath);
        }

        /// <summary>
        /// Get Version of the file
        /// </summary>
        /// <param name="filePath">File Path </param>
        /// <returns> Version of the file  </returns>
        public string GetVersion(string filePath)
        {
            return fileDetails.Version(filePath);
        }
    }
}
