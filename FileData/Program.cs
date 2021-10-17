using System;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                FileDetailsRepository fileDetails = new FileDetailsRepository();
                string value = fileDetails.GetFileDetails(args);
                Console.WriteLine(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception - Message: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
