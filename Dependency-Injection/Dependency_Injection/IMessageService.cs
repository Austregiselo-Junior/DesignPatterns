namespace Dependency_Injection
{
    internal interface IMessageService
    {
        void SaveMessageDataBase(string message);

        void SaveMessageFile(string message);
    }
}