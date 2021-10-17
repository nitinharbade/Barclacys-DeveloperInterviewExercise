using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.Test
{
    [TestClass]
    public class FileDataTest
    {
        IFileData fileData = new FileData();

        [TestMethod]
        public void GetSize_Test()
        {
            int size = fileData.GetSize("C:/test.txt");
            Assert.IsNotNull(size);
        }

        [TestMethod]
        public void GetVersion_Test()
        {
            string version = fileData.GetVersion("C:/test.txt");
            Assert.IsNotNull(version);
        }
    }
}
