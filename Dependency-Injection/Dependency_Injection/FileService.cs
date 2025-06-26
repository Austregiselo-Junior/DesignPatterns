using System;

namespace Dependency_Injection
{
    internal class FileService : IFileService
    {
        public void SaveFile(string message)
        {
            Console.WriteLine("Save the message into the file");
        }
    }
}