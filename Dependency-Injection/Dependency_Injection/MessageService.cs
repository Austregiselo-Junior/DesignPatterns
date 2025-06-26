namespace Dependency_Injection
{
    internal class MessageService
    {
        private readonly IDataService _dataService;
        private readonly IFileService _fileService;

        public MessageService(IDataService dataService, IFileService fileService)
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