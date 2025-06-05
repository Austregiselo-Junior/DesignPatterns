namespace Chain_of_Responsibility
{
    /// <summary>
    /// A interface Handler declara um método para criar a cadeia de handlers. Ela também declara um método para executar uma solicitação.
    /// </summary>
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}