namespace SpeedPDF.Core.Abstractions
{
    public interface IFileSystem
    {
        bool FileExists(string path);
        long GetFileLength(string path);
        string GetFullPath(string path);
    }
}