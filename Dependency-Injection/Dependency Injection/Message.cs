namespace Dependency_Injection
{
    internal class Message
    {
        private readonly IDataService _dataService;
        private readonly IFileService _fileService;

        public Message(IDataService dataService, IFileService fileService)
        {
            _dataService = dataService;
            _fileService = fileService;
        }

        private void SaveMessageDataBase(string message)
        {
            _dataService.Save(message);
        }

        private void SaveMessageFile(string message)
        {
            _fileService.SaveFile(message);
        }
    }
}