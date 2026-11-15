using System.IO;
using SpeedPDF.Core.Abstractions;
namespace SpeedPDF.Infrastructure.FileSystem
{
    public sealed class PhysicalFileSystem : IFileSystem
    {
        public bool FileExists(string path) { return File.Exists(path); }
        public long GetFileLength(string path) { return new FileInfo(path).Length; }
        public string GetFullPath(string path) { return Path.GetFullPath(path); }
    }
}