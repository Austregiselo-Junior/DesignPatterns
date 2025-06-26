using System;

namespace Dependency_Injection
{
    internal class DataBaseService : IDataService
    {
        public void Save(string message)
        {
            Console.WriteLine("Save the message into the data base");
        }
    }
}