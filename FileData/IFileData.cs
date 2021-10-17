namespace FileData
{
    public interface IFileData
    {
        string GetVersion(string filePath);
        int GetSize(string filePath);
    }
}
