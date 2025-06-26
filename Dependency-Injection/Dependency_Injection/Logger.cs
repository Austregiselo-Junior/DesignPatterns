namespace Dependency_Injection
{
    internal class Logger
    {
        private readonly IMessageService _messageService;

        public Logger(IMessageService message)
        {
            _messageService = message;
        }

        public Logger()
        {
        }

        public void SaveMessageDataBase(string message)
        {
            _messageService.SaveMessageDataBase(message);
        }

        public void SaveMessageFile(string message)
        {
            _messageService.SaveMessageFile(message);
        }
    }
}