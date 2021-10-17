using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.Test
{
    [TestClass]
    public class FileDetailsRepositoryTest
    {
        FileDetailsRepository fileDetails = new FileDetailsRepository();

        [TestMethod]
        public void GetFileDetails_Version1_Test()
        {
            string[] args = new string[2];
            args[0] = "-v";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Version2_Test()
        {
            string[] args = new string[2];
            args[0] = "--v";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Version3_Test()
        {
            string[] args = new string[2];
            args[0] = "/v";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Version4_Test()
        {
            string[] args = new string[2];
            args[0] = "--version";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Version_Negative_Test()
        {
            string[] args = new string[2];
            args[0] = "version";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Size1_Test()
        {
            string[] args = new string[2];
            args[0] = "-s";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Size2_Test()
        {
            string[] args = new string[2];
            args[0] = "--s";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Size3_Test()
        {
            string[] args = new string[2];
            args[0] = "/s";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Size4_Test()
        {
            string[] args = new string[2];
            args[0] = "--size";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void GetFileDetails_Size_Negative_Test()
        {
            string[] args = new string[2];
            args[0] = "size";
            args[1] = "C:/test.txt";

            string value = fileDetails.GetFileDetails(args);
            Assert.IsNull(value);
        }
    }
}
